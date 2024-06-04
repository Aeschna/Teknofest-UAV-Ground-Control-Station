using AvionicsInstrumentControlDemo;

namespace Youtube3D_Simulasyon
{
    partial class Form1
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
            this.TimerXYZ = new System.Windows.Forms.Timer(this.components);
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.TelemetreButton = new System.Windows.Forms.Button();
            this.BaudRateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OkumaNesnesi = new System.IO.Ports.SerialPort(this.components);
            this.btnDurdur = new System.Windows.Forms.Button();
            this.Zamanlayıcı = new System.Windows.Forms.Timer(this.components);
            this.labelX2 = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelZ2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.labelz = new System.Windows.Forms.Label();
            this.compassLabel = new System.Windows.Forms.Label();
            this.compass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label80 = new System.Windows.Forms.Label();
            this.trackBarAirSpeed = new System.Windows.Forms.TrackBar();
            this.label70 = new System.Windows.Forms.Label();
            this.trackBarVerticalSpeed = new System.Windows.Forms.TrackBar();
            this.label60 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.trackBarTurnQuality = new System.Windows.Forms.TrackBar();
            this.trackBarTurnRate = new System.Windows.Forms.TrackBar();
            this.trackBarAltitude = new System.Windows.Forms.TrackBar();
            this.trackBarRollAngle = new System.Windows.Forms.TrackBar();
            this.trackPitchAngle = new System.Windows.Forms.TrackBar();
            this.label110 = new System.Windows.Forms.Label();
            this.trackBarHeading = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggleTestModeButton = new System.Windows.Forms.Button();
            this.clearLinesButton = new System.Windows.Forms.Button();
            this.ShowPathButton = new System.Windows.Forms.Button();
            this.LongitudeTextBox = new System.Windows.Forms.TextBox();
            this.LatitudeTextBox = new System.Windows.Forms.TextBox();
            this.Longitude = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.verticalSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.VerticalSpeedIndicatorInstrumentControl();
            this.turnCoordinatorInstrumentControl2 = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            this.headingIndicatorInstrumentControl2 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.altimeterInstrumentControl2 = new AvionicsInstrumentControlDemo.AltimeterInstrumentControl();
            this.airSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl();
            this.verticalSpeedInstrumentControl1 = new AvionicsInstrumentControlDemo.VerticalSpeedIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.horizonInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.altimeterInstrumentControl1 = new AvionicsInstrumentControlDemo.AltimeterInstrumentControl();
            this.airSpeedInstrumentControl1 = new AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl();
            this.turnCoordinatorInstrumentControl1 = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAirSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurnQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRollAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPitchAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeading)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(964, 145);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(1079, 145);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 25);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            this.lblY.Click += new System.EventHandler(this.lblY_Click);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(1190, 145);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(24, 25);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "Z";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(1043, 265);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(110, 33);
            this.SerialPortComboBox.TabIndex = 8;
            this.SerialPortComboBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortComboBox_SelectedIndexChanged);
            // 
            // TelemetreButton
            // 
            this.TelemetreButton.Location = new System.Drawing.Point(969, 386);
            this.TelemetreButton.Name = "TelemetreButton";
            this.TelemetreButton.Size = new System.Drawing.Size(110, 35);
            this.TelemetreButton.TabIndex = 9;
            this.TelemetreButton.Text = "BAĞLAN";
            this.TelemetreButton.UseVisualStyleBackColor = true;
            this.TelemetreButton.Click += new System.EventHandler(this.TelemetreButton_Click);
            // 
            // BaudRateTextBox
            // 
            this.BaudRateTextBox.Location = new System.Drawing.Point(1043, 338);
            this.BaudRateTextBox.Name = "BaudRateTextBox";
            this.BaudRateTextBox.Size = new System.Drawing.Size(110, 30);
            this.BaudRateTextBox.TabIndex = 11;
            this.BaudRateTextBox.Text = "9600";
            this.BaudRateTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Serial Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Baud Rate";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(1094, 386);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(110, 35);
            this.btnDurdur.TabIndex = 14;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // Zamanlayıcı
            // 
            this.Zamanlayıcı.Tick += new System.EventHandler(this.Zamanlayıcı_Tick);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(1202, 268);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(22, 25);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "x";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(1247, 338);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(63, 25);
            this.labely.TabIndex = 16;
            this.labely.Text = "labely";
            // 
            // labelZ2
            // 
            this.labelZ2.AutoSize = true;
            this.labelZ2.Location = new System.Drawing.Point(1334, 268);
            this.labelZ2.Name = "labelZ2";
            this.labelZ2.Size = new System.Drawing.Size(22, 25);
            this.labelZ2.TabIndex = 17;
            this.labelZ2.Text = "z";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(1267, 268);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(22, 25);
            this.labelY2.TabIndex = 18;
            this.labelY2.Text = "y";
            this.labelY2.Click += new System.EventHandler(this.labelY2_Click);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(1178, 338);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(63, 25);
            this.labelx.TabIndex = 19;
            this.labelx.Text = "labelx";
            this.labelx.Click += new System.EventHandler(this.labelx_Click);
            // 
            // labelz
            // 
            this.labelz.AutoSize = true;
            this.labelz.Location = new System.Drawing.Point(1316, 338);
            this.labelz.Name = "labelz";
            this.labelz.Size = new System.Drawing.Size(63, 25);
            this.labelz.TabIndex = 20;
            this.labelz.Text = "labelz";
            // 
            // compassLabel
            // 
            this.compassLabel.AutoSize = true;
            this.compassLabel.Location = new System.Drawing.Point(1057, 647);
            this.compassLabel.Name = "compassLabel";
            this.compassLabel.Size = new System.Drawing.Size(96, 25);
            this.compassLabel.TabIndex = 21;
            this.compassLabel.Text = "Compass";
            this.compassLabel.Click += new System.EventHandler(this.compassLabel_Click);
            // 
            // compass
            // 
            this.compass.AutoSize = true;
            this.compass.Location = new System.Drawing.Point(1057, 602);
            this.compass.Name = "compass";
            this.compass.Size = new System.Drawing.Size(96, 25);
            this.compass.TabIndex = 22;
            this.compass.Text = "Compass";
            this.compass.Click += new System.EventHandler(this.compass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1324, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "deneme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Youtube3D_Simulasyon.Properties.Resources.Ostim_Teknik_Üniversitesi_Logosu2;
            this.pictureBox2.Location = new System.Drawing.Point(1325, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 107);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Youtube3D_Simulasyon.Properties.Resources.Ostim_Teknik_Üniversitesi_Logosu2;
            this.pictureBox1.Location = new System.Drawing.Point(908, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 114);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label80);
            this.groupBox1.Controls.Add(this.trackBarAirSpeed);
            this.groupBox1.Controls.Add(this.label70);
            this.groupBox1.Controls.Add(this.trackBarVerticalSpeed);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label90);
            this.groupBox1.Controls.Add(this.label100);
            this.groupBox1.Controls.Add(this.trackBarTurnQuality);
            this.groupBox1.Controls.Add(this.trackBarTurnRate);
            this.groupBox1.Controls.Add(this.trackBarAltitude);
            this.groupBox1.Controls.Add(this.trackBarRollAngle);
            this.groupBox1.Controls.Add(this.trackPitchAngle);
            this.groupBox1.Controls.Add(this.label110);
            this.groupBox1.Controls.Add(this.trackBarHeading);
            this.groupBox1.Location = new System.Drawing.Point(257, 734);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(883, 294);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(516, 161);
            this.label80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(99, 25);
            this.label80.TabIndex = 15;
            this.label80.Text = "Air Speed";
            this.label80.Click += new System.EventHandler(this.label80_Click);
            // 
            // trackBarAirSpeed
            // 
            this.trackBarAirSpeed.Location = new System.Drawing.Point(0, 0);
            this.trackBarAirSpeed.Name = "trackBarAirSpeed";
            this.trackBarAirSpeed.Size = new System.Drawing.Size(104, 56);
            this.trackBarAirSpeed.TabIndex = 16;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(457, 38);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(140, 25);
            this.label70.TabIndex = 13;
            this.label70.Text = "Vertical Speed";
            this.label70.Click += new System.EventHandler(this.label70_Click);
            // 
            // trackBarVerticalSpeed
            // 
            this.trackBarVerticalSpeed.Location = new System.Drawing.Point(0, 0);
            this.trackBarVerticalSpeed.Name = "trackBarVerticalSpeed";
            this.trackBarVerticalSpeed.Size = new System.Drawing.Size(104, 56);
            this.trackBarVerticalSpeed.TabIndex = 17;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(484, 226);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(119, 25);
            this.label60.TabIndex = 11;
            this.label60.Text = "Turn Quality";
            this.label60.Click += new System.EventHandler(this.label60_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(8, 226);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(98, 25);
            this.label50.TabIndex = 10;
            this.label50.Text = "Turn Rate";
            this.label50.Click += new System.EventHandler(this.label50_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(8, 161);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(77, 25);
            this.label40.TabIndex = 9;
            this.label40.Text = "Altitude";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(500, 98);
            this.label90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(100, 25);
            this.label90.TabIndex = 8;
            this.label90.Text = "Roll Angle";
            this.label90.Click += new System.EventHandler(this.label90_Click);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(8, 98);
            this.label100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(111, 25);
            this.label100.TabIndex = 7;
            this.label100.Text = "Pitch Angle";
            this.label100.Click += new System.EventHandler(this.label100_Click);
            // 
            // trackBarTurnQuality
            // 
            this.trackBarTurnQuality.Location = new System.Drawing.Point(0, 0);
            this.trackBarTurnQuality.Name = "trackBarTurnQuality";
            this.trackBarTurnQuality.Size = new System.Drawing.Size(104, 56);
            this.trackBarTurnQuality.TabIndex = 16;
            // 
            // trackBarTurnRate
            // 
            this.trackBarTurnRate.Location = new System.Drawing.Point(0, 0);
            this.trackBarTurnRate.Name = "trackBarTurnRate";
            this.trackBarTurnRate.Size = new System.Drawing.Size(104, 56);
            this.trackBarTurnRate.TabIndex = 17;
            // 
            // trackBarAltitude
            // 
            this.trackBarAltitude.Location = new System.Drawing.Point(0, 0);
            this.trackBarAltitude.Name = "trackBarAltitude";
            this.trackBarAltitude.Size = new System.Drawing.Size(104, 56);
            this.trackBarAltitude.TabIndex = 18;
            // 
            // trackBarRollAngle
            // 
            this.trackBarRollAngle.Location = new System.Drawing.Point(0, 0);
            this.trackBarRollAngle.Name = "trackBarRollAngle";
            this.trackBarRollAngle.Size = new System.Drawing.Size(104, 56);
            this.trackBarRollAngle.TabIndex = 19;
            // 
            // trackPitchAngle
            // 
            this.trackPitchAngle.Location = new System.Drawing.Point(0, 0);
            this.trackPitchAngle.Name = "trackPitchAngle";
            this.trackPitchAngle.Size = new System.Drawing.Size(104, 56);
            this.trackPitchAngle.TabIndex = 20;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(8, 38);
            this.label110.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(85, 25);
            this.label110.TabIndex = 1;
            this.label110.Text = "Heading";
            this.label110.Click += new System.EventHandler(this.label110_Click);
            // 
            // trackBarHeading
            // 
            this.trackBarHeading.Location = new System.Drawing.Point(0, 0);
            this.trackBarHeading.Name = "trackBarHeading";
            this.trackBarHeading.Size = new System.Drawing.Size(104, 56);
            this.trackBarHeading.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.panel1.Controls.Add(this.toggleTestModeButton);
            this.panel1.Controls.Add(this.clearLinesButton);
            this.panel1.Controls.Add(this.ShowPathButton);
            this.panel1.Controls.Add(this.LongitudeTextBox);
            this.panel1.Controls.Add(this.LatitudeTextBox);
            this.panel1.Controls.Add(this.Longitude);
            this.panel1.Controls.Add(this.Latitude);
            this.panel1.Controls.Add(this.gMapControl1);
            this.panel1.Controls.Add(this.verticalSpeedIndicatorInstrumentControl1);
            this.panel1.Controls.Add(this.turnCoordinatorInstrumentControl2);
            this.panel1.Controls.Add(this.headingIndicatorInstrumentControl2);
            this.panel1.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.panel1.Controls.Add(this.altimeterInstrumentControl2);
            this.panel1.Controls.Add(this.airSpeedIndicatorInstrumentControl1);
            this.panel1.Controls.Add(this.compassLabel);
            this.panel1.Controls.Add(this.compass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDurdur);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.lblY);
            this.panel1.Controls.Add(this.lblZ);
            this.panel1.Controls.Add(this.labelz);
            this.panel1.Controls.Add(this.TelemetreButton);
            this.panel1.Controls.Add(this.SerialPortComboBox);
            this.panel1.Controls.Add(this.labely);
            this.panel1.Controls.Add(this.labelx);
            this.panel1.Controls.Add(this.BaudRateTextBox);
            this.panel1.Controls.Add(this.labelZ2);
            this.panel1.Controls.Add(this.labelY2);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 778);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toggleTestModeButton
            // 
            this.toggleTestModeButton.Location = new System.Drawing.Point(586, 414);
            this.toggleTestModeButton.Name = "toggleTestModeButton";
            this.toggleTestModeButton.Size = new System.Drawing.Size(160, 36);
            this.toggleTestModeButton.TabIndex = 47;
            this.toggleTestModeButton.Text = "Test Modu";
            this.toggleTestModeButton.UseVisualStyleBackColor = true;
            this.toggleTestModeButton.Click += new System.EventHandler(this.toggleTestModeButton_Click);
            // 
            // clearLinesButton
            // 
            this.clearLinesButton.Location = new System.Drawing.Point(586, 355);
            this.clearLinesButton.Name = "clearLinesButton";
            this.clearLinesButton.Size = new System.Drawing.Size(160, 36);
            this.clearLinesButton.TabIndex = 46;
            this.clearLinesButton.Text = "Haritayı Temizle";
            this.clearLinesButton.UseVisualStyleBackColor = true;
            this.clearLinesButton.Click += new System.EventHandler(this.clearLinesButton_Click);
            // 
            // ShowPathButton
            // 
            this.ShowPathButton.Location = new System.Drawing.Point(586, 300);
            this.ShowPathButton.Name = "ShowPathButton";
            this.ShowPathButton.Size = new System.Drawing.Size(160, 36);
            this.ShowPathButton.TabIndex = 45;
            this.ShowPathButton.Text = "Yolu Göster";
            this.ShowPathButton.UseVisualStyleBackColor = true;
            this.ShowPathButton.Click += new System.EventHandler(this.ShowPathButton_Click);
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.Location = new System.Drawing.Point(595, 231);
            this.LongitudeTextBox.Name = "LongitudeTextBox";
            this.LongitudeTextBox.Size = new System.Drawing.Size(100, 30);
            this.LongitudeTextBox.TabIndex = 38;
            this.LongitudeTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Location = new System.Drawing.Point(595, 116);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.Size = new System.Drawing.Size(100, 30);
            this.LatitudeTextBox.TabIndex = 37;
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(590, 191);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(98, 25);
            this.Longitude.TabIndex = 36;
            this.Longitude.Text = "Longitude";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(590, 77);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(81, 25);
            this.Latitude.TabIndex = 35;
            this.Latitude.Text = "Latitude";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(16, -123);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(553, 547);
            this.gMapControl1.TabIndex = 34;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // verticalSpeedIndicatorInstrumentControl1
            // 
            this.verticalSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(874, 565);
            this.verticalSpeedIndicatorInstrumentControl1.Name = "verticalSpeedIndicatorInstrumentControl1";
            this.verticalSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(170, 177);
            this.verticalSpeedIndicatorInstrumentControl1.TabIndex = 32;
            this.verticalSpeedIndicatorInstrumentControl1.Text = "verticalSpeedIndicatorInstrumentControl1";
            // 
            // turnCoordinatorInstrumentControl2
            // 
            this.turnCoordinatorInstrumentControl2.Location = new System.Drawing.Point(697, 566);
            this.turnCoordinatorInstrumentControl2.Name = "turnCoordinatorInstrumentControl2";
            this.turnCoordinatorInstrumentControl2.Size = new System.Drawing.Size(171, 202);
            this.turnCoordinatorInstrumentControl2.TabIndex = 31;
            this.turnCoordinatorInstrumentControl2.Text = "turnCoordinatorInstrumentControl2";
            // 
            // headingIndicatorInstrumentControl2
            // 
            this.headingIndicatorInstrumentControl2.Location = new System.Drawing.Point(527, 568);
            this.headingIndicatorInstrumentControl2.Name = "headingIndicatorInstrumentControl2";
            this.headingIndicatorInstrumentControl2.Size = new System.Drawing.Size(165, 200);
            this.headingIndicatorInstrumentControl2.TabIndex = 30;
            this.headingIndicatorInstrumentControl2.Text = "headingIndicatorInstrumentControl2";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(356, 568);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 174);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 29;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // altimeterInstrumentControl2
            // 
            this.altimeterInstrumentControl2.Location = new System.Drawing.Point(183, 568);
            this.altimeterInstrumentControl2.Name = "altimeterInstrumentControl2";
            this.altimeterInstrumentControl2.Size = new System.Drawing.Size(167, 174);
            this.altimeterInstrumentControl2.TabIndex = 28;
            this.altimeterInstrumentControl2.Text = "altimeterInstrumentControl2";
            // 
            // airSpeedIndicatorInstrumentControl1
            // 
            this.airSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(12, 568);
            this.airSpeedIndicatorInstrumentControl1.Name = "airSpeedIndicatorInstrumentControl1";
            this.airSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 174);
            this.airSpeedIndicatorInstrumentControl1.TabIndex = 27;
            this.airSpeedIndicatorInstrumentControl1.Text = "airSpeedIndicatorInstrumentControl1";
            // 
            // verticalSpeedInstrumentControl1
            // 
            this.verticalSpeedInstrumentControl1.Location = new System.Drawing.Point(632, 268);
            this.verticalSpeedInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.verticalSpeedInstrumentControl1.Name = "verticalSpeedInstrumentControl1";
            this.verticalSpeedInstrumentControl1.Size = new System.Drawing.Size(267, 246);
            this.verticalSpeedInstrumentControl1.TabIndex = 5;
            this.verticalSpeedInstrumentControl1.Text = "verticalSpeedInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(323, 330);
            this.headingIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(267, 246);
            this.headingIndicatorInstrumentControl1.TabIndex = 4;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // horizonInstrumentControl1
            // 
            this.horizonInstrumentControl1.Location = new System.Drawing.Point(291, 15);
            this.horizonInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.horizonInstrumentControl1.Name = "horizonInstrumentControl1";
            this.horizonInstrumentControl1.Size = new System.Drawing.Size(333, 308);
            this.horizonInstrumentControl1.TabIndex = 3;
            this.horizonInstrumentControl1.Text = "horizonInstrumentControl1";
            // 
            // altimeterInstrumentControl1
            // 
            this.altimeterInstrumentControl1.Location = new System.Drawing.Point(632, 15);
            this.altimeterInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.altimeterInstrumentControl1.Name = "altimeterInstrumentControl1";
            this.altimeterInstrumentControl1.Size = new System.Drawing.Size(267, 246);
            this.altimeterInstrumentControl1.TabIndex = 2;
            this.altimeterInstrumentControl1.Text = "altimeterInstrumentControl1";
            // 
            // airSpeedInstrumentControl1
            // 
            this.airSpeedInstrumentControl1.Location = new System.Drawing.Point(16, 15);
            this.airSpeedInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.airSpeedInstrumentControl1.Name = "airSpeedInstrumentControl1";
            this.airSpeedInstrumentControl1.Size = new System.Drawing.Size(267, 246);
            this.airSpeedInstrumentControl1.TabIndex = 1;
            this.airSpeedInstrumentControl1.Text = "airSpeedInstrumentControl1";
            // 
            // turnCoordinatorInstrumentControl1
            // 
            this.turnCoordinatorInstrumentControl1.Location = new System.Drawing.Point(16, 268);
            this.turnCoordinatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.turnCoordinatorInstrumentControl1.Name = "turnCoordinatorInstrumentControl1";
            this.turnCoordinatorInstrumentControl1.Size = new System.Drawing.Size(267, 246);
            this.turnCoordinatorInstrumentControl1.TabIndex = 0;
            this.turnCoordinatorInstrumentControl1.Text = "turnCoordinatorInstrumentControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verticalSpeedInstrumentControl1);
            this.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.Controls.Add(this.horizonInstrumentControl1);
            this.Controls.Add(this.altimeterInstrumentControl1);
            this.Controls.Add(this.airSpeedInstrumentControl1);
            this.Controls.Add(this.turnCoordinatorInstrumentControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAirSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurnQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRollAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPitchAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TurnCoordinatorInstrumentControl turnCoordinatorInstrumentControl1;
        private AirSpeedIndicatorInstrumentControl airSpeedInstrumentControl1;
        private AltimeterInstrumentControl altimeterInstrumentControl1;
        private AttitudeIndicatorInstrumentControl horizonInstrumentControl1;
        private HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private VerticalSpeedIndicatorInstrumentControl verticalSpeedInstrumentControl1;
        private System.Windows.Forms.Timer TimerXYZ;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SerialPortComboBox;
        private System.Windows.Forms.Button TelemetreButton;
        private System.Windows.Forms.TextBox BaudRateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Timer Zamanlayıcı;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelZ2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labelz;
        private System.IO.Ports.SerialPort OkumaNesnesi;
        private System.Windows.Forms.Label compassLabel;
        private System.Windows.Forms.Label compass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TrackBar trackBarVerticalSpeed;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TrackBar trackBarTurnQuality;
        private System.Windows.Forms.TrackBar trackBarTurnRate;
        private System.Windows.Forms.TrackBar trackBarAltitude;
        private System.Windows.Forms.TrackBar trackBarRollAngle;
        private System.Windows.Forms.TrackBar trackPitchAngle;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TrackBar trackBarHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarAirSpeed;
        private AirSpeedIndicatorInstrumentControl airSpeedIndicatorInstrumentControl1;
        private VerticalSpeedIndicatorInstrumentControl verticalSpeedIndicatorInstrumentControl1;
        private TurnCoordinatorInstrumentControl turnCoordinatorInstrumentControl2;
        private HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl2;
        private AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private AltimeterInstrumentControl altimeterInstrumentControl2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.TextBox LongitudeTextBox;
        private System.Windows.Forms.TextBox LatitudeTextBox;
        private System.Windows.Forms.Button ShowPathButton;
        private System.Windows.Forms.Button clearLinesButton;
        private System.Windows.Forms.Button toggleTestModeButton;
    }
}

