using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PowerSupplyManager.Dto;

namespace PowerSupplyManager
{
    public partial class FloatValueControl : UserControl
    {
        public FloatValueControl(int integerCount, int divisionalCount, float maxValue)
        {
            _integerCount = integerCount;
            _divisionalCount = divisionalCount;
            _maxValue = maxValue;

            _prevValue = new FloatValue(divisionalCount);

            InitializeComponent();

            CreateComponents();
        }

        public delegate void ValueChangedEventHandler(object sender, FloatValue e);

        public event ValueChangedEventHandler ValueChanged;

        public FloatValue Value
        {
            get => new FloatValue(_divisionalCount)
            {
                Integer = CalculateSum(_controlsInteger),
                Divisional = CalculateSum(_controlsDivisional)
            };

            set
            {
                SetValues(value.Integer, _controlsInteger);
                SetValues(value.Divisional, _controlsDivisional);

                if (!CheckAndRevertValue())
                {
                    _prevValue.SetValue(value);
                }
            }
        }

        private int CalculateSum(IList<NumericUpDown> controls)
        {
            return (int) controls.Select(x => (int) x.Value)
                                 .Reverse()
                                 .Select((x, i) => x * Math.Pow(10, i))
                                 .Sum();
        }

        private void SetValues(int value, IList<NumericUpDown> controls)
        {
            var integer = value.ToString()
                               .PadLeft(controls.Count, '0');

            for (var i = 0; i < controls.Count; i++)
            {
                controls[i].Value = int.Parse(integer[i].ToString());
            }
        }

        private void CreateComponents()
        {
            var left = 0;

            for (var i = 0; i < _integerCount; i++)
            {
                var ctl = CreateNumericUpDown($"ctlInteger{i}",
                                              left,
                                              new ControlPosition(_controlsInteger.Count, ControlType.Integer));
                Controls.Add(ctl);

                left += ctl.Width;

                _controlsInteger.Add(ctl);
            }

            var label = new Label
            {
                Text = @".",
                AutoSize = true,
                Font = _controlFont
            };

            Controls.Add(label);
            label.Top = Controls[0].Top + Controls[0].Height - label.Height;
            label.Left = left;
            left += label.Width;

            for (var i = 0; i < _divisionalCount; i++)
            {
                var ctl = CreateNumericUpDown($"ctlDivisional{i}",
                                              left,
                                              new ControlPosition(_controlsDivisional.Count, ControlType.Divisional));
                Controls.Add(ctl);

                left += ctl.Width;

                _controlsDivisional.Add(ctl);
            }
        }

        private NumericUpDown CreateNumericUpDown(string name, int left, ControlPosition position)
        {
            var ctl = new NumericUpDown
            {
                Name = name,
                Top = 0,
                Left = left,
                Font = _controlFont,
                Minimum = -1,
                Maximum = 10,
                Increment = 1,
                Value = 0,
                Tag = position
            };
            ctl.Width = ctl.Height;
            ctl.ValueChanged += Ctl_ValueChanged;
            ctl.GotFocus += Ctl_GotFocus;
            ctl.Click += Ctl_Click;
            ctl.KeyUp += Ctl_KeyUp;

            return ctl;
        }

        private void Ctl_Click(object sender, EventArgs e)
        {
            ((NumericUpDown) sender).Select(0, 1);
        }

        private void Ctl_GotFocus(object sender, EventArgs e)
        {
            ((NumericUpDown) sender).Select(0, 1);
        }

        private void Ctl_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57) ||
                (e.KeyValue >= 96 && e.KeyValue <= 105))
            {
                var position = (ControlPosition) ((NumericUpDown) sender).Tag;
                var ctl = GetNextControl(position);

                if (ctl == null) return;

                ctl.Focus();
                ctl.Select(0, 1);
            }
        }

        private NumericUpDown GetNextControl(ControlPosition position)
        {
            if (position.Type == ControlType.Integer)
            {
                if (position.Index == _controlsInteger.Count - 1)
                {
                    return _controlsDivisional.First();
                }

                return _controlsInteger[position.Index + 1];
            }

            if (position.Index < _controlsDivisional.Count - 1)
            {
                return _controlsDivisional[position.Index + 1];
            }

            return null;
        }

        private bool CheckAndRevertValue()
        {
            var value = Value.ToFloat();
            if (value < 0 || value > _maxValue)
            {
                _skipEvent = true;

                Value = _prevValue;

                _skipEvent = false;

                return true;
            }

            return false;
        }

        private void Ctl_ValueChanged(object sender, EventArgs e)
        {
            if (_skipEvent) return;

            var ctl = (NumericUpDown) sender;
            var position = (ControlPosition) ctl.Tag;

            // ignore duplicate change value events of same control
            if (position.Equals(_eventPosition)) return;

            if (_eventPosition == null)
            {
                _eventPosition = position;
            }

            if (ctl.Value == -1)
            {
                if (position.Type == ControlType.Integer)
                {
                    if (position.Index > 0 &&
                        _controlsInteger.Take(position.Index)
                                        .Any(x => x.Value != 0))
                    {
                        ctl.Value = 9;
                        _controlsInteger[position.Index - 1].Value--;
                    }
                    else
                    {
                        ctl.Value = 0;
                    }
                }
                else
                {
                    if (position.Index == 0)
                    {
                        if (_controlsInteger.Any(x => x.Value != 0))
                        {
                            ctl.Value = 9;
                            _controlsInteger.Last().Value--;
                        }
                        else
                        {
                            ctl.Value = 0;
                        }
                    }
                    else
                    {
                        if (_controlsDivisional.Take(position.Index)
                                               .Any(x => x.Value != 0) ||
                            _controlsInteger.Any(x => x.Value != 0))
                        {
                            ctl.Value = 9;
                            _controlsDivisional[position.Index - 1].Value--;
                        }
                        else
                        {
                            ctl.Value = 0;
                        }
                    }
                }
            }
            else if (ctl.Value == 10)
            {
                ctl.Value = 0;

                if (position.Type == ControlType.Integer)
                {
                    if (position.Index > 0)
                    {
                        _controlsInteger[position.Index - 1].Value++;
                    }
                }
                else
                {
                    if (position.Index == 0)
                    {
                        _controlsInteger.Last().Value++;
                    }
                    else
                    {
                        _controlsDivisional[position.Index - 1].Value++;
                    }
                }
            }

            if (position.Equals(_eventPosition))
            {
                _eventPosition = null;

                if (CheckAndRevertValue()) return;

                var value = Value;
                _prevValue.SetValue(value);

                ValueChanged?.Invoke(this, value);
            }
        }

        private bool _skipEvent;
        private ControlPosition _eventPosition;
        private readonly FloatValue _prevValue;
        private readonly List<NumericUpDown> _controlsInteger = new List<NumericUpDown>();
        private readonly List<NumericUpDown> _controlsDivisional = new List<NumericUpDown>();
        private readonly int _integerCount;
        private readonly int _divisionalCount;
        private readonly float _maxValue;
        private readonly Font _controlFont = new Font(FontFamily.GenericSansSerif, 20F);

        private class ControlPosition
        {
            public ControlPosition(int index, ControlType type)
            {
                Index = index;
                Type = type;
            }

            public int Index { get; }

            public ControlType Type { get; }

            public override bool Equals(object obj)
            {
                return obj is ControlPosition x &&
                       x.Type == Type &&
                       x.Index == Index;
            }

            public override int GetHashCode()
            {
                return (Index + 1) ^ (int) Type;
            }
        }

        private enum ControlType
        {
            Integer = 1,
            Divisional = 2
        }
    }
}
