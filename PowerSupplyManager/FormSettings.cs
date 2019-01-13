using System;
using System.Linq;
using System.Windows.Forms;

namespace PowerSupplyManager
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void RefreshComPorts()
        {
            comboPorts.Items.Clear();
            // ReSharper disable once CoVariantArrayConversion
            comboPorts.Items.AddRange(ComManager.ListComPorts()
                                                .Select(x => x.Name)
                                                .ToArray());

            var selectedComPort = ComManager.GetComPort();
            if (!string.IsNullOrEmpty(selectedComPort) && comboPorts.Items.Contains(selectedComPort))
            {
                comboPorts.SelectedItem = selectedComPort;
            }
            else
            {
                if (comboPorts.Items.Count > 0)
                {
                    comboPorts.SelectedIndex = 0;
                }
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboPorts.SelectedIndex > -1)
            {
                ComManager.SetComPort(comboPorts.SelectedItem
                                                .ToString());
            }

            Close();
        }
    }
}
