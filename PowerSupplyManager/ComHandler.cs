﻿using System;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PowerSupplyManager.Dto;

namespace PowerSupplyManager
{
    internal class ComHandler
    {
        public delegate void DataReceivedEventHandler(object sender, OutInfo e);

        public ComHandler(string comPort)
        {
            Assertion.IsNullOrEmpty(comPort, nameof (comPort));

            _comPort = comPort;
        }

        public void Start()
        {
            if (_task != null) return;

            _token = new CancellationTokenSource();
            _task = Task.Run(() => Processing(_token.Token), _token.Token);
        }

        public void Stop()
        {
            if (_task == null) return;

            if (_token.Token.CanBeCanceled &&
                !_token.IsCancellationRequested)
            {
                _token.Cancel();
                _task = null;
            }
        }

        public void On()
        {
            _outOn = true;
        }

        public void Off()
        {
            _outOn = false;
        }

        public bool IsOn()
        {
            return _outOn;
        }

        public void SetVoltage(int integer, int divisional)
        {
            var value = integer + ((float) divisional / 10);

            if (value < 0 || value > 31)
            {
                throw new Exception("Voltage must be between 0 and 31!");
            }

            _voltage.Integer = integer;
            _voltage.Divisional = divisional;
        }

        public void SetCurrent(int integer, int divisional)
        {
            //var value = integer + ((float) divisional / 10);

            //if (value < 0 || value > 5)
            //{
            //    throw new Exception("Current must be between 0 and 5!");
            //}

            _current.Integer = integer;
            _current.Divisional = divisional;
        }

        public event DataReceivedEventHandler DataReceived;

        private Task _task;
        private CancellationTokenSource _token;
        private readonly string _comPort;
        private bool _outOn;

        private readonly FloatValue _voltage = new FloatValue
        {
            Integer = 30
        };

        private readonly FloatValue _current = new FloatValue
        {
            Integer = 5
        };

        private const int BaudRate = 9600;
        private const Parity ParityValue = Parity.Space;
        private const int DataBits = 8;
        private const string CommandPrefix = "YHPPSU";

        private void Processing(CancellationToken token)
        {
            if (token.IsCancellationRequested) return;

            using (var port = new SerialPort(_comPort, BaudRate, ParityValue, DataBits))
            {
                var ev = new AutoResetEvent(false);

                port.DataReceived += (sender, e) => ev.Set();
                port.WriteTimeout = 500;
                port.ReadTimeout = 500;
                port.Open();

                while (true)
                {
                    if (token.IsCancellationRequested) break;

                    var message = CreateSendMessage();
                    port.WriteLine(message);

                    ev.WaitOne();
                    var value = port.ReadExisting();
                    ev.Reset();

                    ParseReceivedMessage(value);

                    Task.Delay(100, CancellationToken.None)
                        .Wait(CancellationToken.None);
                }

                port.Close();
            }
        }

        private string CreateSendMessage()
        {
            return string.Format("{0}{1:00}{2:00}H{3:0}{4:000}{5}Y",
                                 CommandPrefix,
                                 _voltage.Integer,
                                 _voltage.Divisional,
                                 _current.Integer,
                                 _current.Divisional,
                                 _outOn ? "O" : "N");
        }

        private void ParseReceivedMessage(string value)
        {
            //YHPPSU0000A0000W

            value = SplitMessage(value).LastOrDefault();
            if (string.IsNullOrWhiteSpace(value)) return;

            if (!value.StartsWith(CommandPrefix, StringComparison.Ordinal)) return;
            if (!value.EndsWith("W")) return;

            var voltage = float.Parse(string.Format("{0}.{1}",
                                                    value.Substring(6, 2),
                                                    value.Substring(8, 2)),
                                      CultureInfo.InvariantCulture);

            if (value.Substring(10, 1) != "A") return;

            var current = float.Parse(string.Format("{0}.{1}",
                                                    value.Substring(11, 1),
                                                    value.Substring(12, 3)),
                                      CultureInfo.InvariantCulture);

            var outInfo = new OutInfo
            {
                Voltage = voltage,
                Current = current
            };

            var handler = DataReceived;
            handler?.Invoke(this, outInfo);
        }

        private string[] SplitMessage(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return new string[] { };


            return value.Split(new[] {CommandPrefix}, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x.Length == 10)
                        .Select(x => $"{CommandPrefix}{x}")
                        .ToArray();
        }
    }
}