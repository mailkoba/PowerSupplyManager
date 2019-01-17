using System;
using System.Linq;
using System.Windows.Forms;
using PowerSupplyManager.Dto;

namespace PowerSupplyManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private ComHandler _comHandler;
        private readonly DiagramData _dataVoltage = new DiagramData();
        private readonly DiagramData _dataCurrent = new DiagramData();

        private void FormMain_Load(object sender, EventArgs e)
        {
            statusCom.Text = @"-";

            CreateFloatValuePanels();
            CreateHandler();
            UpdateCharts();

            timerCharts.Enabled = true;
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            if (_comHandler == null) return;

            if (_comHandler.IsOn())
            {
                _comHandler.Off();
            }
            else
            {
                _comHandler.On();
            }

            UpdateOnButton();
        }

        private void CreateHandler()
        {
            var port = ComManager.GetComPort();

            panelControls.Enabled = !string.IsNullOrWhiteSpace(port);

            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show(@"COM port not found!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                statusCom.Text = port;
                _comHandler = new ComHandler(port);
                _comHandler.DataReceived += _comHandler_DataReceived;
                _comHandler.Start();
            }

            UpdateOnButton();
        }

        private void _comHandler_DataReceived(object sender, OutInfo e)
        {
            if (IsDisposed) return;
            try
            {
                Invoke((Action) delegate
                {
                    if (IsDisposed) return;

                    labelOutVoltage.Text = e.Voltage.ToString("00.00V");
                    labelOutCurrent.Text = e.Current.ToString("0.000A");

                    _dataVoltage.AddValue(e.Voltage);
                    _dataCurrent.AddValue(e.Current);
                });
            }
            catch
            {
                // empty
            }
        }

        private void DestroyHandler()
        {
            _comHandler?.Off();
            _comHandler?.Stop();
            _comHandler = null;
        }

        private void UpdateOnButton()
        {
            buttonOn.Text = (_comHandler?.IsOn()).GetValueOrDefault() ? "OFF" : "ON";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DestroyHandler();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using (var form = new FormSettings())
            {
                if (form.ShowDialog() == DialogResult.Cancel) return;

                DestroyHandler();
                CreateHandler();
            }
        }

        private void timerCharts_Tick(object sender, EventArgs e)
        {
            UpdateCharts();
        }

        private void UpdateCharts()
        {
            chartVoltage.Series
                        .First()
                        .Points
                        .DataBind(_dataVoltage.Data,
                                  nameof (DiagramDataItem.Title),
                                  nameof (DiagramDataItem.Value),
                                  string.Empty);
            chartCurrent.Series
                        .First()
                        .Points
                        .DataBind(_dataCurrent.Data,
                                  nameof (DiagramDataItem.Title),
                                  nameof (DiagramDataItem.Value),
                                  string.Empty);
        }

        private void CreateFloatValuePanels()
        {
            var ctlVoltage = new FloatValueControl(2, 2, 31F);
            panelVoltage.Controls.Add(ctlVoltage);
            ctlVoltage.ValueChanged += (sender, e) =>
            {
                var value = ((FloatValueControl) sender).Value;
                _comHandler?.SetVoltage(value.Integer, value.Divisional);
            };
            ctlVoltage.Value = new FloatValue(2)
            {
                Integer = 30,
                Divisional = 0
            };

            var ctlCurrent = new FloatValueControl(1, 3, 5F);
            panelCurrent.Controls.Add(ctlCurrent);
            ctlCurrent.ValueChanged += (sender, e) =>
            {
                var value = ((FloatValueControl)sender).Value;
                _comHandler?.SetCurrent(value.Integer, value.Divisional);
            };
            ctlCurrent.Value = new FloatValue(3)
            {
                Integer = 5,
                Divisional = 0
            };
        }
    }
}
