namespace PowerSupplyManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusCom = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartVoltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOutCurrent = new System.Windows.Forms.Label();
            this.labelOutVoltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboOverCurrent = new System.Windows.Forms.ComboBox();
            this.panelCurrent = new System.Windows.Forms.Panel();
            this.panelVoltage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartCurrent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerCharts = new System.Windows.Forms.Timer(this.components);
            this.labelOvercurrent = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCom});
            this.statusStrip.Location = new System.Drawing.Point(0, 639);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusCom
            // 
            this.statusCom.Name = "statusCom";
            this.statusCom.Size = new System.Drawing.Size(35, 17);
            this.statusCom.Text = "COM";
            // 
            // chartVoltage
            // 
            this.chartVoltage.BackColor = System.Drawing.Color.Black;
            chartArea3.AxisX.Interval = 10D;
            chartArea3.AxisX.IntervalOffset = 10D;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorGrid.Interval = 10D;
            chartArea3.AxisX.MajorGrid.IntervalOffset = 10D;
            chartArea3.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Interval = 10D;
            chartArea3.AxisX.MajorTickMark.IntervalOffset = 10D;
            chartArea3.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Interval = 10D;
            chartArea3.AxisY.IntervalOffset = 10D;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.Interval = 10D;
            chartArea3.AxisY.LabelStyle.IntervalOffset = 10D;
            chartArea3.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorGrid.Interval = 10D;
            chartArea3.AxisY.MajorGrid.IntervalOffset = 10D;
            chartArea3.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Interval = 10D;
            chartArea3.AxisY.MajorTickMark.IntervalOffset = 10D;
            chartArea3.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.AxisY.Maximum = 40D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chartVoltage.ChartAreas.Add(chartArea3);
            this.chartVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartVoltage.Location = new System.Drawing.Point(0, 0);
            this.chartVoltage.Name = "chartVoltage";
            series3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Divot;
            series3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Gold;
            series3.LabelBackColor = System.Drawing.Color.Black;
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartVoltage.Series.Add(series3);
            this.chartVoltage.Size = new System.Drawing.Size(700, 319);
            this.chartVoltage.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelControls);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSettings);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 639);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 12;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.groupBox2);
            this.panelControls.Controls.Add(this.groupBox1);
            this.panelControls.Location = new System.Drawing.Point(12, 12);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(277, 496);
            this.panelControls.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOvercurrent);
            this.groupBox2.Controls.Add(this.labelOutCurrent);
            this.groupBox2.Controls.Add(this.labelOutVoltage);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(7, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 170);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Out";
            // 
            // labelOutCurrent
            // 
            this.labelOutCurrent.AutoSize = true;
            this.labelOutCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutCurrent.Location = new System.Drawing.Point(100, 85);
            this.labelOutCurrent.Name = "labelOutCurrent";
            this.labelOutCurrent.Size = new System.Drawing.Size(60, 20);
            this.labelOutCurrent.TabIndex = 14;
            this.labelOutCurrent.Text = "0.000A";
            // 
            // labelOutVoltage
            // 
            this.labelOutVoltage.AutoSize = true;
            this.labelOutVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutVoltage.Location = new System.Drawing.Point(100, 37);
            this.labelOutVoltage.Name = "labelOutVoltage";
            this.labelOutVoltage.Size = new System.Drawing.Size(60, 20);
            this.labelOutVoltage.TabIndex = 14;
            this.labelOutVoltage.Text = "00.00V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Voltage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboOverCurrent);
            this.groupBox1.Controls.Add(this.panelCurrent);
            this.groupBox1.Controls.Add(this.panelVoltage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonOn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(261, 283);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Overcurrent mode";
            // 
            // comboOverCurrent
            // 
            this.comboOverCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOverCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboOverCurrent.FormattingEnabled = true;
            this.comboOverCurrent.Items.AddRange(new object[] {
            "Steady output",
            "Trip output"});
            this.comboOverCurrent.Location = new System.Drawing.Point(76, 181);
            this.comboOverCurrent.Name = "comboOverCurrent";
            this.comboOverCurrent.Size = new System.Drawing.Size(176, 28);
            this.comboOverCurrent.TabIndex = 15;
            this.comboOverCurrent.SelectedIndexChanged += new System.EventHandler(this.comboOverCurrent_SelectedIndexChanged);
            // 
            // panelCurrent
            // 
            this.panelCurrent.Location = new System.Drawing.Point(76, 96);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(176, 43);
            this.panelCurrent.TabIndex = 14;
            // 
            // panelVoltage
            // 
            this.panelVoltage.Location = new System.Drawing.Point(76, 24);
            this.panelVoltage.Name = "panelVoltage";
            this.panelVoltage.Size = new System.Drawing.Size(176, 43);
            this.panelVoltage.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Voltage";
            // 
            // buttonOn
            // 
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOn.Location = new System.Drawing.Point(8, 232);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(244, 33);
            this.buttonOn.TabIndex = 9;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(18, 514);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 15;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.chartVoltage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.chartCurrent);
            this.splitContainer2.Size = new System.Drawing.Size(700, 639);
            this.splitContainer2.SplitterDistance = 319;
            this.splitContainer2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 289);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label8.Size = new System.Drawing.Size(40, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 286);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label7.Size = new System.Drawing.Size(40, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "A";
            // 
            // chartCurrent
            // 
            this.chartCurrent.BackColor = System.Drawing.Color.Black;
            chartArea4.AxisX.Interval = 10D;
            chartArea4.AxisX.IntervalOffset = 10D;
            chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorGrid.Interval = 10D;
            chartArea4.AxisX.MajorGrid.IntervalOffset = 10D;
            chartArea4.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Interval = 10D;
            chartArea4.AxisX.MajorTickMark.IntervalOffset = 10D;
            chartArea4.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea4.AxisX.Maximum = 100D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Interval = 1D;
            chartArea4.AxisY.IntervalOffset = 1D;
            chartArea4.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.Format = "  {0}";
            chartArea4.AxisY.LabelStyle.Interval = 1D;
            chartArea4.AxisY.LabelStyle.IntervalOffset = 1D;
            chartArea4.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorGrid.Interval = 1D;
            chartArea4.AxisY.MajorGrid.IntervalOffset = 1D;
            chartArea4.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorTickMark.Interval = 1D;
            chartArea4.AxisY.MajorTickMark.IntervalOffset = 1D;
            chartArea4.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea4.AxisY.Maximum = 6D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.MinorGrid.Interval = 1D;
            chartArea4.AxisY.MinorGrid.IntervalOffset = 1D;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chartCurrent.ChartAreas.Add(chartArea4);
            this.chartCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCurrent.Location = new System.Drawing.Point(0, 0);
            this.chartCurrent.Name = "chartCurrent";
            series4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Divot;
            series4.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Gold;
            series4.LabelBackColor = System.Drawing.Color.Black;
            series4.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartCurrent.Series.Add(series4);
            this.chartCurrent.Size = new System.Drawing.Size(700, 316);
            this.chartCurrent.TabIndex = 10;
            // 
            // timerCharts
            // 
            this.timerCharts.Interval = 500;
            this.timerCharts.Tick += new System.EventHandler(this.timerCharts_Tick);
            // 
            // labelOvercurrent
            // 
            this.labelOvercurrent.AutoSize = true;
            this.labelOvercurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOvercurrent.ForeColor = System.Drawing.Color.Red;
            this.labelOvercurrent.Location = new System.Drawing.Point(10, 133);
            this.labelOvercurrent.Name = "labelOvercurrent";
            this.labelOvercurrent.Size = new System.Drawing.Size(92, 20);
            this.labelOvercurrent.TabIndex = 15;
            this.labelOvercurrent.Text = "Overcurrent";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "305DB power supply manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusCom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoltage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Timer timerCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurrent;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelOutCurrent;
        private System.Windows.Forms.Label labelOutVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelVoltage;
        private System.Windows.Forms.Panel panelCurrent;
        private System.Windows.Forms.ComboBox comboOverCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOvercurrent;
    }
}

