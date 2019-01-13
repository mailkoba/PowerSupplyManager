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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusCom = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartVoltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericCurrentInteger = new System.Windows.Forms.NumericUpDown();
            this.numericCurrentDivisional = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericVoltageInteger = new System.Windows.Forms.NumericUpDown();
            this.numericVoltageDivisional = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.timerCharts = new System.Windows.Forms.Timer(this.components);
            this.chartCurrent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOutCurrent = new System.Windows.Forms.Label();
            this.labelOutVoltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentDivisional)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVoltageInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVoltageDivisional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrent)).BeginInit();
            this.panelControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1065, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            chartArea9.AxisX.Interval = 10D;
            chartArea9.AxisX.IntervalOffset = 10D;
            chartArea9.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisX.MajorGrid.Interval = 10D;
            chartArea9.AxisX.MajorGrid.IntervalOffset = 10D;
            chartArea9.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisX.MajorTickMark.Enabled = false;
            chartArea9.AxisX.MajorTickMark.Interval = 10D;
            chartArea9.AxisX.MajorTickMark.IntervalOffset = 10D;
            chartArea9.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea9.AxisX.Maximum = 100D;
            chartArea9.AxisX.Minimum = 0D;
            chartArea9.AxisY.Interval = 10D;
            chartArea9.AxisY.IntervalOffset = 10D;
            chartArea9.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LabelStyle.Interval = 10D;
            chartArea9.AxisY.LabelStyle.IntervalOffset = 10D;
            chartArea9.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisY.MajorGrid.Interval = 10D;
            chartArea9.AxisY.MajorGrid.IntervalOffset = 10D;
            chartArea9.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisY.MajorTickMark.Enabled = false;
            chartArea9.AxisY.MajorTickMark.Interval = 10D;
            chartArea9.AxisY.MajorTickMark.IntervalOffset = 10D;
            chartArea9.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea9.AxisY.Maximum = 40D;
            chartArea9.AxisY.Minimum = 0D;
            chartArea9.BackColor = System.Drawing.Color.Black;
            chartArea9.Name = "ChartArea1";
            this.chartVoltage.ChartAreas.Add(chartArea9);
            this.chartVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartVoltage.Location = new System.Drawing.Point(0, 0);
            this.chartVoltage.Name = "chartVoltage";
            series9.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Divot;
            series9.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Gold;
            series9.LabelBackColor = System.Drawing.Color.Black;
            series9.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.Name = "Series1";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartVoltage.Series.Add(series9);
            this.chartVoltage.Size = new System.Drawing.Size(786, 320);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 641);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 12;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(19, 440);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 15;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonOn);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(243, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericCurrentInteger);
            this.panel2.Controls.Add(this.numericCurrentDivisional);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(76, 91);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(150, 54);
            this.panel2.TabIndex = 13;
            // 
            // numericCurrentInteger
            // 
            this.numericCurrentInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericCurrentInteger.Location = new System.Drawing.Point(8, 8);
            this.numericCurrentInteger.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCurrentInteger.Name = "numericCurrentInteger";
            this.numericCurrentInteger.Size = new System.Drawing.Size(51, 38);
            this.numericCurrentInteger.TabIndex = 5;
            this.numericCurrentInteger.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCurrentInteger.ValueChanged += new System.EventHandler(this.numericCurrentInteger_ValueChanged);
            // 
            // numericCurrentDivisional
            // 
            this.numericCurrentDivisional.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericCurrentDivisional.Location = new System.Drawing.Point(75, 8);
            this.numericCurrentDivisional.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericCurrentDivisional.Name = "numericCurrentDivisional";
            this.numericCurrentDivisional.Size = new System.Drawing.Size(68, 38);
            this.numericCurrentDivisional.TabIndex = 5;
            this.numericCurrentDivisional.ValueChanged += new System.EventHandler(this.numericCurrentDivisional_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = ",";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericVoltageInteger);
            this.panel1.Controls.Add(this.numericVoltageDivisional);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(78, 16);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(148, 54);
            this.panel1.TabIndex = 12;
            // 
            // numericVoltageInteger
            // 
            this.numericVoltageInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericVoltageInteger.Location = new System.Drawing.Point(8, 8);
            this.numericVoltageInteger.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericVoltageInteger.Name = "numericVoltageInteger";
            this.numericVoltageInteger.Size = new System.Drawing.Size(51, 38);
            this.numericVoltageInteger.TabIndex = 5;
            this.numericVoltageInteger.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericVoltageInteger.ValueChanged += new System.EventHandler(this.numericVoltageInteger_ValueChanged);
            // 
            // numericVoltageDivisional
            // 
            this.numericVoltageDivisional.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericVoltageDivisional.Location = new System.Drawing.Point(75, 8);
            this.numericVoltageDivisional.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericVoltageDivisional.Name = "numericVoltageDivisional";
            this.numericVoltageDivisional.Size = new System.Drawing.Size(66, 38);
            this.numericVoltageDivisional.TabIndex = 5;
            this.numericVoltageDivisional.ValueChanged += new System.EventHandler(this.numericVoltageDivisional_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Voltage";
            // 
            // buttonOn
            // 
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOn.Location = new System.Drawing.Point(8, 155);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(227, 33);
            this.buttonOn.TabIndex = 9;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
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
            this.splitContainer2.Size = new System.Drawing.Size(786, 641);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 10;
            // 
            // timerCharts
            // 
            this.timerCharts.Interval = 500;
            this.timerCharts.Tick += new System.EventHandler(this.timerCharts_Tick);
            // 
            // chartCurrent
            // 
            this.chartCurrent.BackColor = System.Drawing.Color.Black;
            chartArea10.AxisX.Interval = 10D;
            chartArea10.AxisX.IntervalOffset = 10D;
            chartArea10.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisX.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisX.MajorGrid.Interval = 10D;
            chartArea10.AxisX.MajorGrid.IntervalOffset = 10D;
            chartArea10.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisX.MajorTickMark.Enabled = false;
            chartArea10.AxisX.MajorTickMark.Interval = 10D;
            chartArea10.AxisX.MajorTickMark.IntervalOffset = 10D;
            chartArea10.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea10.AxisX.Maximum = 100D;
            chartArea10.AxisX.Minimum = 0D;
            chartArea10.AxisY.Interval = 1D;
            chartArea10.AxisY.IntervalOffset = 1D;
            chartArea10.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisY.LabelStyle.Format = "  {0}";
            chartArea10.AxisY.LabelStyle.Interval = 1D;
            chartArea10.AxisY.LabelStyle.IntervalOffset = 1D;
            chartArea10.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisY.MajorGrid.Interval = 1D;
            chartArea10.AxisY.MajorGrid.IntervalOffset = 1D;
            chartArea10.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisY.MajorTickMark.Interval = 1D;
            chartArea10.AxisY.MajorTickMark.IntervalOffset = 1D;
            chartArea10.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea10.AxisY.Maximum = 6D;
            chartArea10.AxisY.Minimum = 0D;
            chartArea10.AxisY.MinorGrid.Interval = 1D;
            chartArea10.AxisY.MinorGrid.IntervalOffset = 1D;
            chartArea10.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.BackColor = System.Drawing.Color.Black;
            chartArea10.Name = "ChartArea1";
            this.chartCurrent.ChartAreas.Add(chartArea10);
            this.chartCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCurrent.Location = new System.Drawing.Point(0, 0);
            this.chartCurrent.Name = "chartCurrent";
            series10.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Divot;
            series10.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Gold;
            series10.LabelBackColor = System.Drawing.Color.Black;
            series10.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series10.Name = "Series1";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartCurrent.Series.Add(series10);
            this.chartCurrent.Size = new System.Drawing.Size(786, 317);
            this.chartCurrent.TabIndex = 10;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.groupBox2);
            this.panelControls.Controls.Add(this.groupBox1);
            this.panelControls.Location = new System.Drawing.Point(12, 12);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(257, 422);
            this.panelControls.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOutCurrent);
            this.groupBox2.Controls.Add(this.labelOutVoltage);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 204);
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
            this.labelOutCurrent.Size = new System.Drawing.Size(18, 20);
            this.labelOutCurrent.TabIndex = 14;
            this.labelOutCurrent.Text = "0";
            // 
            // labelOutVoltage
            // 
            this.labelOutVoltage.AutoSize = true;
            this.labelOutVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutVoltage.Location = new System.Drawing.Point(100, 37);
            this.labelOutVoltage.Name = "labelOutVoltage";
            this.labelOutVoltage.Size = new System.Drawing.Size(18, 20);
            this.labelOutVoltage.TabIndex = 14;
            this.labelOutVoltage.Text = "0";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 287);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label7.Size = new System.Drawing.Size(40, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 290);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label8.Size = new System.Drawing.Size(40, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "V";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 663);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "305DB power supply manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrentDivisional)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVoltageInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVoltageDivisional)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrent)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusCom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoltage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericCurrentInteger;
        private System.Windows.Forms.NumericUpDown numericCurrentDivisional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericVoltageInteger;
        private System.Windows.Forms.NumericUpDown numericVoltageDivisional;
        private System.Windows.Forms.Label label3;
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
    }
}

