namespace Aifrus.SimGPS2
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.Label_Hostname = new System.Windows.Forms.Label();
            this.GroupBox_FlightSimulator = new System.Windows.Forms.GroupBox();
            this.ComboBox_Refresh = new System.Windows.Forms.ComboBox();
            this.Label_Refresh = new System.Windows.Forms.Label();
            this.TextBox_Hostname = new System.Windows.Forms.TextBox();
            this.Button_Defaults = new System.Windows.Forms.Button();
            this.GroupBox_COM = new System.Windows.Forms.GroupBox();
            this.GroupBox_NMEA = new System.Windows.Forms.GroupBox();
            this.GroupBox_SentenceTypes = new System.Windows.Forms.GroupBox();
            this.CheckBox_GSA = new System.Windows.Forms.CheckBox();
            this.CheckBox_GGA = new System.Windows.Forms.CheckBox();
            this.CheckBox_GSV = new System.Windows.Forms.CheckBox();
            this.CheckBox_RMC = new System.Windows.Forms.CheckBox();
            this.CheckBox_VTG = new System.Windows.Forms.CheckBox();
            this.GroupBox_DeviceType = new System.Windows.Forms.GroupBox();
            this.RadioButton_GNSS = new System.Windows.Forms.RadioButton();
            this.RadioButton_GLONASS = new System.Windows.Forms.RadioButton();
            this.RadioButton_GPS = new System.Windows.Forms.RadioButton();
            this.ComboBox_Stop = new System.Windows.Forms.ComboBox();
            this.Label_Stop = new System.Windows.Forms.Label();
            this.ComboBox_Parity = new System.Windows.Forms.ComboBox();
            this.Label_Parity = new System.Windows.Forms.Label();
            this.ComboBox_Data = new System.Windows.Forms.ComboBox();
            this.Label_Data = new System.Windows.Forms.Label();
            this.ComboBox_Port = new System.Windows.Forms.ComboBox();
            this.ComboBox_Baud = new System.Windows.Forms.ComboBox();
            this.Label_Baud = new System.Windows.Forms.Label();
            this.Label_Port = new System.Windows.Forms.Label();
            this.GroupBox_Startup = new System.Windows.Forms.GroupBox();
            this.CheckBox_AutoRecord = new System.Windows.Forms.CheckBox();
            this.CheckBox_AutoPower = new System.Windows.Forms.CheckBox();
            this.RadioButton_User = new System.Windows.Forms.RadioButton();
            this.RadioButton_Computer = new System.Windows.Forms.RadioButton();
            this.RadioButton_NoAuto = new System.Windows.Forms.RadioButton();
            this.GroupBox_Display = new System.Windows.Forms.GroupBox();
            this.GroupBox_LED_Color = new System.Windows.Forms.GroupBox();
            this.Button_LED_Color = new System.Windows.Forms.Button();
            this.CheckBox_TopMost = new System.Windows.Forms.CheckBox();
            this.CheckBox_NotifyIcon = new System.Windows.Forms.CheckBox();
            this.CheckBox_Taskbar = new System.Windows.Forms.CheckBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox_FlightSimulator.SuspendLayout();
            this.GroupBox_COM.SuspendLayout();
            this.GroupBox_NMEA.SuspendLayout();
            this.GroupBox_SentenceTypes.SuspendLayout();
            this.GroupBox_DeviceType.SuspendLayout();
            this.GroupBox_Startup.SuspendLayout();
            this.GroupBox_Display.SuspendLayout();
            this.GroupBox_LED_Color.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Hostname
            // 
            this.Label_Hostname.AutoSize = true;
            this.Label_Hostname.Location = new System.Drawing.Point(21, 21);
            this.Label_Hostname.Name = "Label_Hostname";
            this.Label_Hostname.Size = new System.Drawing.Size(82, 11);
            this.Label_Hostname.TabIndex = 0;
            this.Label_Hostname.Text = "Hostname/IP";
            // 
            // GroupBox_FlightSimulator
            // 
            this.GroupBox_FlightSimulator.Controls.Add(this.ComboBox_Refresh);
            this.GroupBox_FlightSimulator.Controls.Add(this.Label_Refresh);
            this.GroupBox_FlightSimulator.Controls.Add(this.TextBox_Hostname);
            this.GroupBox_FlightSimulator.Controls.Add(this.Label_Hostname);
            this.GroupBox_FlightSimulator.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_FlightSimulator.ForeColor = System.Drawing.Color.White;
            this.GroupBox_FlightSimulator.Location = new System.Drawing.Point(12, 37);
            this.GroupBox_FlightSimulator.Name = "GroupBox_FlightSimulator";
            this.GroupBox_FlightSimulator.Size = new System.Drawing.Size(242, 75);
            this.GroupBox_FlightSimulator.TabIndex = 1;
            this.GroupBox_FlightSimulator.TabStop = false;
            this.GroupBox_FlightSimulator.Text = "Microsoft Flight Simulator";
            // 
            // ComboBox_Refresh
            // 
            this.ComboBox_Refresh.DisplayMember = "60 FPS";
            this.ComboBox_Refresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Refresh.FormattingEnabled = true;
            this.ComboBox_Refresh.Items.AddRange(new object[] {
            "240 FPS",
            "120 FPS",
            "60 FPS",
            "30 FPS",
            "15 FPS",
            "10 FPS",
            "5 FPS",
            "4 FPS",
            "3 FPS",
            "2 FPS",
            "1 Second",
            "2 Seconds",
            "3 Seconds",
            "4 Seconds",
            "5 Seconds",
            "10 Seconds",
            "15 Seconds",
            "30 Seconds",
            "60 Seconds",
            "120 Seconds",
            "240 Seconds"});
            this.ComboBox_Refresh.Location = new System.Drawing.Point(109, 44);
            this.ComboBox_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_Refresh.Name = "ComboBox_Refresh";
            this.ComboBox_Refresh.Size = new System.Drawing.Size(122, 19);
            this.ComboBox_Refresh.TabIndex = 3;
            // 
            // Label_Refresh
            // 
            this.Label_Refresh.AutoSize = true;
            this.Label_Refresh.Location = new System.Drawing.Point(14, 47);
            this.Label_Refresh.Name = "Label_Refresh";
            this.Label_Refresh.Size = new System.Drawing.Size(89, 11);
            this.Label_Refresh.TabIndex = 2;
            this.Label_Refresh.Text = "Refresh Rate";
            // 
            // TextBox_Hostname
            // 
            this.TextBox_Hostname.Location = new System.Drawing.Point(109, 18);
            this.TextBox_Hostname.Name = "TextBox_Hostname";
            this.TextBox_Hostname.Size = new System.Drawing.Size(122, 18);
            this.TextBox_Hostname.TabIndex = 1;
            this.TextBox_Hostname.Text = "localhost";
            // 
            // Button_Defaults
            // 
            this.Button_Defaults.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Defaults.Location = new System.Drawing.Point(35, 428);
            this.Button_Defaults.Name = "Button_Defaults";
            this.Button_Defaults.Size = new System.Drawing.Size(106, 23);
            this.Button_Defaults.TabIndex = 2;
            this.Button_Defaults.Text = "&Defaults";
            this.Button_Defaults.UseVisualStyleBackColor = true;
            this.Button_Defaults.Click += new System.EventHandler(this.Button_Defaults_Click);
            // 
            // GroupBox_COM
            // 
            this.GroupBox_COM.Controls.Add(this.GroupBox_NMEA);
            this.GroupBox_COM.Controls.Add(this.ComboBox_Stop);
            this.GroupBox_COM.Controls.Add(this.Label_Stop);
            this.GroupBox_COM.Controls.Add(this.ComboBox_Parity);
            this.GroupBox_COM.Controls.Add(this.Label_Parity);
            this.GroupBox_COM.Controls.Add(this.ComboBox_Data);
            this.GroupBox_COM.Controls.Add(this.Label_Data);
            this.GroupBox_COM.Controls.Add(this.ComboBox_Port);
            this.GroupBox_COM.Controls.Add(this.ComboBox_Baud);
            this.GroupBox_COM.Controls.Add(this.Label_Baud);
            this.GroupBox_COM.Controls.Add(this.Label_Port);
            this.GroupBox_COM.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_COM.ForeColor = System.Drawing.Color.White;
            this.GroupBox_COM.Location = new System.Drawing.Point(262, 37);
            this.GroupBox_COM.Name = "GroupBox_COM";
            this.GroupBox_COM.Size = new System.Drawing.Size(242, 325);
            this.GroupBox_COM.TabIndex = 4;
            this.GroupBox_COM.TabStop = false;
            this.GroupBox_COM.Text = "Serial Output";
            // 
            // GroupBox_NMEA
            // 
            this.GroupBox_NMEA.Controls.Add(this.GroupBox_SentenceTypes);
            this.GroupBox_NMEA.Controls.Add(this.GroupBox_DeviceType);
            this.GroupBox_NMEA.ForeColor = System.Drawing.Color.White;
            this.GroupBox_NMEA.Location = new System.Drawing.Point(9, 157);
            this.GroupBox_NMEA.Name = "GroupBox_NMEA";
            this.GroupBox_NMEA.Size = new System.Drawing.Size(222, 158);
            this.GroupBox_NMEA.TabIndex = 11;
            this.GroupBox_NMEA.TabStop = false;
            this.GroupBox_NMEA.Text = "NMEA Format";
            // 
            // GroupBox_SentenceTypes
            // 
            this.GroupBox_SentenceTypes.Controls.Add(this.CheckBox_GSA);
            this.GroupBox_SentenceTypes.Controls.Add(this.CheckBox_GGA);
            this.GroupBox_SentenceTypes.Controls.Add(this.CheckBox_GSV);
            this.GroupBox_SentenceTypes.Controls.Add(this.CheckBox_RMC);
            this.GroupBox_SentenceTypes.Controls.Add(this.CheckBox_VTG);
            this.GroupBox_SentenceTypes.ForeColor = System.Drawing.Color.White;
            this.GroupBox_SentenceTypes.Location = new System.Drawing.Point(114, 15);
            this.GroupBox_SentenceTypes.Name = "GroupBox_SentenceTypes";
            this.GroupBox_SentenceTypes.Size = new System.Drawing.Size(100, 134);
            this.GroupBox_SentenceTypes.TabIndex = 1;
            this.GroupBox_SentenceTypes.TabStop = false;
            this.GroupBox_SentenceTypes.Text = "Sentences";
            // 
            // CheckBox_GSA
            // 
            this.CheckBox_GSA.AutoSize = true;
            this.CheckBox_GSA.Checked = true;
            this.CheckBox_GSA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_GSA.Location = new System.Drawing.Point(22, 111);
            this.CheckBox_GSA.Name = "CheckBox_GSA";
            this.CheckBox_GSA.Size = new System.Drawing.Size(59, 15);
            this.CheckBox_GSA.TabIndex = 9;
            this.CheckBox_GSA.Text = "GPGSA";
            this.CheckBox_GSA.UseVisualStyleBackColor = true;
            // 
            // CheckBox_GGA
            // 
            this.CheckBox_GGA.AutoSize = true;
            this.CheckBox_GGA.Checked = true;
            this.CheckBox_GGA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_GGA.Location = new System.Drawing.Point(22, 19);
            this.CheckBox_GGA.Name = "CheckBox_GGA";
            this.CheckBox_GGA.Size = new System.Drawing.Size(59, 15);
            this.CheckBox_GGA.TabIndex = 5;
            this.CheckBox_GGA.Text = "GPGGA";
            this.CheckBox_GGA.UseVisualStyleBackColor = true;
            // 
            // CheckBox_GSV
            // 
            this.CheckBox_GSV.AutoSize = true;
            this.CheckBox_GSV.Checked = true;
            this.CheckBox_GSV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_GSV.Location = new System.Drawing.Point(22, 88);
            this.CheckBox_GSV.Name = "CheckBox_GSV";
            this.CheckBox_GSV.Size = new System.Drawing.Size(59, 15);
            this.CheckBox_GSV.TabIndex = 8;
            this.CheckBox_GSV.Text = "GPGSV";
            this.CheckBox_GSV.UseVisualStyleBackColor = true;
            // 
            // CheckBox_RMC
            // 
            this.CheckBox_RMC.AutoSize = true;
            this.CheckBox_RMC.Checked = true;
            this.CheckBox_RMC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_RMC.Location = new System.Drawing.Point(22, 42);
            this.CheckBox_RMC.Name = "CheckBox_RMC";
            this.CheckBox_RMC.Size = new System.Drawing.Size(59, 15);
            this.CheckBox_RMC.TabIndex = 6;
            this.CheckBox_RMC.Text = "GPRMC";
            this.CheckBox_RMC.UseVisualStyleBackColor = true;
            // 
            // CheckBox_VTG
            // 
            this.CheckBox_VTG.AutoSize = true;
            this.CheckBox_VTG.Checked = true;
            this.CheckBox_VTG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_VTG.Location = new System.Drawing.Point(22, 65);
            this.CheckBox_VTG.Name = "CheckBox_VTG";
            this.CheckBox_VTG.Size = new System.Drawing.Size(59, 15);
            this.CheckBox_VTG.TabIndex = 7;
            this.CheckBox_VTG.Text = "GPVTG";
            this.CheckBox_VTG.UseVisualStyleBackColor = true;
            // 
            // GroupBox_DeviceType
            // 
            this.GroupBox_DeviceType.Controls.Add(this.RadioButton_GNSS);
            this.GroupBox_DeviceType.Controls.Add(this.RadioButton_GLONASS);
            this.GroupBox_DeviceType.Controls.Add(this.RadioButton_GPS);
            this.GroupBox_DeviceType.ForeColor = System.Drawing.Color.White;
            this.GroupBox_DeviceType.Location = new System.Drawing.Point(8, 15);
            this.GroupBox_DeviceType.Name = "GroupBox_DeviceType";
            this.GroupBox_DeviceType.Size = new System.Drawing.Size(100, 134);
            this.GroupBox_DeviceType.TabIndex = 0;
            this.GroupBox_DeviceType.TabStop = false;
            this.GroupBox_DeviceType.Text = "Device Type";
            // 
            // RadioButton_GNSS
            // 
            this.RadioButton_GNSS.AutoSize = true;
            this.RadioButton_GNSS.Checked = true;
            this.RadioButton_GNSS.Location = new System.Drawing.Point(14, 65);
            this.RadioButton_GNSS.Name = "RadioButton_GNSS";
            this.RadioButton_GNSS.Size = new System.Drawing.Size(51, 15);
            this.RadioButton_GNSS.TabIndex = 2;
            this.RadioButton_GNSS.TabStop = true;
            this.RadioButton_GNSS.Text = "GNSS";
            this.RadioButton_GNSS.UseVisualStyleBackColor = true;
            // 
            // RadioButton_GLONASS
            // 
            this.RadioButton_GLONASS.AutoSize = true;
            this.RadioButton_GLONASS.Location = new System.Drawing.Point(14, 42);
            this.RadioButton_GLONASS.Name = "RadioButton_GLONASS";
            this.RadioButton_GLONASS.Size = new System.Drawing.Size(72, 15);
            this.RadioButton_GLONASS.TabIndex = 1;
            this.RadioButton_GLONASS.Text = "GLONASS";
            this.RadioButton_GLONASS.UseVisualStyleBackColor = true;
            // 
            // RadioButton_GPS
            // 
            this.RadioButton_GPS.AutoSize = true;
            this.RadioButton_GPS.Location = new System.Drawing.Point(14, 19);
            this.RadioButton_GPS.Name = "RadioButton_GPS";
            this.RadioButton_GPS.Size = new System.Drawing.Size(44, 15);
            this.RadioButton_GPS.TabIndex = 0;
            this.RadioButton_GPS.Text = "GPS";
            this.RadioButton_GPS.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Stop
            // 
            this.ComboBox_Stop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Stop.Enabled = false;
            this.ComboBox_Stop.FormattingEnabled = true;
            this.ComboBox_Stop.Items.AddRange(new object[] {
            "2",
            "1.5",
            "1"});
            this.ComboBox_Stop.Location = new System.Drawing.Point(109, 123);
            this.ComboBox_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_Stop.Name = "ComboBox_Stop";
            this.ComboBox_Stop.Size = new System.Drawing.Size(122, 19);
            this.ComboBox_Stop.TabIndex = 10;
            // 
            // Label_Stop
            // 
            this.Label_Stop.AutoSize = true;
            this.Label_Stop.Location = new System.Drawing.Point(70, 126);
            this.Label_Stop.Name = "Label_Stop";
            this.Label_Stop.Size = new System.Drawing.Size(33, 11);
            this.Label_Stop.TabIndex = 9;
            this.Label_Stop.Text = "Stop";
            // 
            // ComboBox_Parity
            // 
            this.ComboBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Parity.Enabled = false;
            this.ComboBox_Parity.FormattingEnabled = true;
            this.ComboBox_Parity.Items.AddRange(new object[] {
            "N - None",
            "O - Odd",
            "E - Even",
            "M - Mark",
            "S - Space"});
            this.ComboBox_Parity.Location = new System.Drawing.Point(109, 96);
            this.ComboBox_Parity.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_Parity.Name = "ComboBox_Parity";
            this.ComboBox_Parity.Size = new System.Drawing.Size(122, 19);
            this.ComboBox_Parity.TabIndex = 8;
            // 
            // Label_Parity
            // 
            this.Label_Parity.AutoSize = true;
            this.Label_Parity.Location = new System.Drawing.Point(56, 99);
            this.Label_Parity.Name = "Label_Parity";
            this.Label_Parity.Size = new System.Drawing.Size(47, 11);
            this.Label_Parity.TabIndex = 7;
            this.Label_Parity.Text = "Parity";
            // 
            // ComboBox_Data
            // 
            this.ComboBox_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Data.Enabled = false;
            this.ComboBox_Data.FormattingEnabled = true;
            this.ComboBox_Data.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.ComboBox_Data.Location = new System.Drawing.Point(109, 70);
            this.ComboBox_Data.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_Data.Name = "ComboBox_Data";
            this.ComboBox_Data.Size = new System.Drawing.Size(122, 19);
            this.ComboBox_Data.TabIndex = 6;
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Location = new System.Drawing.Point(70, 73);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(33, 11);
            this.Label_Data.TabIndex = 5;
            this.Label_Data.Text = "Data";
            // 
            // ComboBox_Port
            // 
            this.ComboBox_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Port.FormattingEnabled = true;
            this.ComboBox_Port.Items.AddRange(new object[] {
            "Disabled",
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.ComboBox_Port.Location = new System.Drawing.Point(109, 17);
            this.ComboBox_Port.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_Port.Name = "ComboBox_Port";
            this.ComboBox_Port.Size = new System.Drawing.Size(122, 19);
            this.ComboBox_Port.TabIndex = 4;
            // 
            // ComboBox_Baud
            // 
            this.ComboBox_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Baud.Enabled = false;
            this.ComboBox_Baud.FormattingEnabled = true;
            this.ComboBox_Baud.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "2400",
            "1200",
            "300"});
            this.ComboBox_Baud.Location = new System.Drawing.Point(109, 43);
            this.ComboBox_Baud.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_Baud.Name = "ComboBox_Baud";
            this.ComboBox_Baud.Size = new System.Drawing.Size(122, 19);
            this.ComboBox_Baud.TabIndex = 3;
            // 
            // Label_Baud
            // 
            this.Label_Baud.AutoSize = true;
            this.Label_Baud.Location = new System.Drawing.Point(35, 46);
            this.Label_Baud.Name = "Label_Baud";
            this.Label_Baud.Size = new System.Drawing.Size(68, 11);
            this.Label_Baud.TabIndex = 2;
            this.Label_Baud.Text = "Baud Rate";
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Location = new System.Drawing.Point(70, 20);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(33, 11);
            this.Label_Port.TabIndex = 0;
            this.Label_Port.Text = "Port";
            // 
            // GroupBox_Startup
            // 
            this.GroupBox_Startup.Controls.Add(this.CheckBox_AutoRecord);
            this.GroupBox_Startup.Controls.Add(this.CheckBox_AutoPower);
            this.GroupBox_Startup.Controls.Add(this.RadioButton_User);
            this.GroupBox_Startup.Controls.Add(this.RadioButton_Computer);
            this.GroupBox_Startup.Controls.Add(this.RadioButton_NoAuto);
            this.GroupBox_Startup.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Startup.ForeColor = System.Drawing.Color.White;
            this.GroupBox_Startup.Location = new System.Drawing.Point(12, 118);
            this.GroupBox_Startup.Name = "GroupBox_Startup";
            this.GroupBox_Startup.Size = new System.Drawing.Size(242, 147);
            this.GroupBox_Startup.TabIndex = 5;
            this.GroupBox_Startup.TabStop = false;
            this.GroupBox_Startup.Text = "Startup";
            // 
            // CheckBox_AutoRecord
            // 
            this.CheckBox_AutoRecord.AutoSize = true;
            this.CheckBox_AutoRecord.Location = new System.Drawing.Point(23, 123);
            this.CheckBox_AutoRecord.Name = "CheckBox_AutoRecord";
            this.CheckBox_AutoRecord.Size = new System.Drawing.Size(164, 15);
            this.CheckBox_AutoRecord.TabIndex = 11;
            this.CheckBox_AutoRecord.Text = "Record Automatically";
            this.CheckBox_AutoRecord.UseVisualStyleBackColor = true;
            // 
            // CheckBox_AutoPower
            // 
            this.CheckBox_AutoPower.AutoSize = true;
            this.CheckBox_AutoPower.Location = new System.Drawing.Point(23, 100);
            this.CheckBox_AutoPower.Name = "CheckBox_AutoPower";
            this.CheckBox_AutoPower.Size = new System.Drawing.Size(178, 15);
            this.CheckBox_AutoPower.TabIndex = 10;
            this.CheckBox_AutoPower.Text = "Power On Automatically";
            this.CheckBox_AutoPower.UseVisualStyleBackColor = true;
            // 
            // RadioButton_User
            // 
            this.RadioButton_User.AutoSize = true;
            this.RadioButton_User.Location = new System.Drawing.Point(23, 65);
            this.RadioButton_User.Name = "RadioButton_User";
            this.RadioButton_User.Size = new System.Drawing.Size(184, 15);
            this.RadioButton_User.TabIndex = 5;
            this.RadioButton_User.Text = "Start when User Logs In";
            this.RadioButton_User.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Computer
            // 
            this.RadioButton_Computer.AutoSize = true;
            this.RadioButton_Computer.Location = new System.Drawing.Point(23, 42);
            this.RadioButton_Computer.Name = "RadioButton_Computer";
            this.RadioButton_Computer.Size = new System.Drawing.Size(205, 15);
            this.RadioButton_Computer.TabIndex = 4;
            this.RadioButton_Computer.Text = "Start when Computer Starts";
            this.RadioButton_Computer.UseVisualStyleBackColor = true;
            // 
            // RadioButton_NoAuto
            // 
            this.RadioButton_NoAuto.AutoSize = true;
            this.RadioButton_NoAuto.Checked = true;
            this.RadioButton_NoAuto.Location = new System.Drawing.Point(23, 19);
            this.RadioButton_NoAuto.Name = "RadioButton_NoAuto";
            this.RadioButton_NoAuto.Size = new System.Drawing.Size(142, 15);
            this.RadioButton_NoAuto.TabIndex = 3;
            this.RadioButton_NoAuto.TabStop = true;
            this.RadioButton_NoAuto.Text = "Do Not Auto-Start";
            this.RadioButton_NoAuto.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Display
            // 
            this.GroupBox_Display.Controls.Add(this.GroupBox_LED_Color);
            this.GroupBox_Display.Controls.Add(this.CheckBox_TopMost);
            this.GroupBox_Display.Controls.Add(this.CheckBox_NotifyIcon);
            this.GroupBox_Display.Controls.Add(this.CheckBox_Taskbar);
            this.GroupBox_Display.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Display.ForeColor = System.Drawing.Color.White;
            this.GroupBox_Display.Location = new System.Drawing.Point(12, 271);
            this.GroupBox_Display.Name = "GroupBox_Display";
            this.GroupBox_Display.Size = new System.Drawing.Size(242, 91);
            this.GroupBox_Display.TabIndex = 13;
            this.GroupBox_Display.TabStop = false;
            this.GroupBox_Display.Text = "Display";
            // 
            // GroupBox_LED_Color
            // 
            this.GroupBox_LED_Color.Controls.Add(this.Button_LED_Color);
            this.GroupBox_LED_Color.ForeColor = System.Drawing.Color.White;
            this.GroupBox_LED_Color.Location = new System.Drawing.Point(180, 17);
            this.GroupBox_LED_Color.Name = "GroupBox_LED_Color";
            this.GroupBox_LED_Color.Size = new System.Drawing.Size(48, 38);
            this.GroupBox_LED_Color.TabIndex = 13;
            this.GroupBox_LED_Color.TabStop = false;
            this.GroupBox_LED_Color.Text = "LEDs";
            // 
            // Button_LED_Color
            // 
            this.Button_LED_Color.BackColor = System.Drawing.Color.Cyan;
            this.Button_LED_Color.Location = new System.Drawing.Point(6, 11);
            this.Button_LED_Color.Name = "Button_LED_Color";
            this.Button_LED_Color.Size = new System.Drawing.Size(35, 23);
            this.Button_LED_Color.TabIndex = 0;
            this.Button_LED_Color.UseVisualStyleBackColor = false;
            this.Button_LED_Color.Click += new System.EventHandler(this.Button_LED_Color_Click);
            // 
            // CheckBox_TopMost
            // 
            this.CheckBox_TopMost.AutoSize = true;
            this.CheckBox_TopMost.Location = new System.Drawing.Point(23, 20);
            this.CheckBox_TopMost.Name = "CheckBox_TopMost";
            this.CheckBox_TopMost.Size = new System.Drawing.Size(115, 15);
            this.CheckBox_TopMost.TabIndex = 10;
            this.CheckBox_TopMost.Text = "Always On Top";
            this.CheckBox_TopMost.UseVisualStyleBackColor = true;
            // 
            // CheckBox_NotifyIcon
            // 
            this.CheckBox_NotifyIcon.AutoSize = true;
            this.CheckBox_NotifyIcon.Checked = true;
            this.CheckBox_NotifyIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_NotifyIcon.Location = new System.Drawing.Point(23, 66);
            this.CheckBox_NotifyIcon.Name = "CheckBox_NotifyIcon";
            this.CheckBox_NotifyIcon.Size = new System.Drawing.Size(143, 15);
            this.CheckBox_NotifyIcon.TabIndex = 12;
            this.CheckBox_NotifyIcon.Text = "Notification Icon";
            this.CheckBox_NotifyIcon.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Taskbar
            // 
            this.CheckBox_Taskbar.AutoSize = true;
            this.CheckBox_Taskbar.Location = new System.Drawing.Point(23, 43);
            this.CheckBox_Taskbar.Name = "CheckBox_Taskbar";
            this.CheckBox_Taskbar.Size = new System.Drawing.Size(129, 15);
            this.CheckBox_Taskbar.TabIndex = 11;
            this.CheckBox_Taskbar.Text = "Show in Taskbar";
            this.CheckBox_Taskbar.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.Location = new System.Drawing.Point(387, 428);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(106, 23);
            this.Button_Cancel.TabIndex = 14;
            this.Button_Cancel.Text = "&Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(271, 428);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(106, 23);
            this.Button_Save.TabIndex = 15;
            this.Button_Save.Text = "&Save / Apply";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "SimGPS² Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recordings Folder";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(375, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "&Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.Button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(514, 463);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.GroupBox_Display);
            this.Controls.Add(this.GroupBox_Startup);
            this.Controls.Add(this.GroupBox_COM);
            this.Controls.Add(this.Button_Defaults);
            this.Controls.Add(this.GroupBox_FlightSimulator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimGPS² Settings";
            this.TopMost = true;
            this.GroupBox_FlightSimulator.ResumeLayout(false);
            this.GroupBox_FlightSimulator.PerformLayout();
            this.GroupBox_COM.ResumeLayout(false);
            this.GroupBox_COM.PerformLayout();
            this.GroupBox_NMEA.ResumeLayout(false);
            this.GroupBox_SentenceTypes.ResumeLayout(false);
            this.GroupBox_SentenceTypes.PerformLayout();
            this.GroupBox_DeviceType.ResumeLayout(false);
            this.GroupBox_DeviceType.PerformLayout();
            this.GroupBox_Startup.ResumeLayout(false);
            this.GroupBox_Startup.PerformLayout();
            this.GroupBox_Display.ResumeLayout(false);
            this.GroupBox_Display.PerformLayout();
            this.GroupBox_LED_Color.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Hostname;
        private System.Windows.Forms.GroupBox GroupBox_FlightSimulator;
        private System.Windows.Forms.Label Label_Refresh;
        private System.Windows.Forms.Button Button_Defaults;
        private System.Windows.Forms.GroupBox GroupBox_COM;
        private System.Windows.Forms.Label Label_Baud;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Label Label_Stop;
        private System.Windows.Forms.Label Label_Parity;
        private System.Windows.Forms.GroupBox GroupBox_NMEA;
        private System.Windows.Forms.GroupBox GroupBox_SentenceTypes;
        private System.Windows.Forms.GroupBox GroupBox_DeviceType;
        private System.Windows.Forms.GroupBox GroupBox_Startup;
        private System.Windows.Forms.RadioButton RadioButton_User;
        private System.Windows.Forms.RadioButton RadioButton_Computer;
        private System.Windows.Forms.RadioButton RadioButton_NoAuto;
        private System.Windows.Forms.GroupBox GroupBox_Display;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.GroupBox GroupBox_LED_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TextBox_Hostname;
        public System.Windows.Forms.ComboBox ComboBox_Refresh;
        public System.Windows.Forms.ComboBox ComboBox_Baud;
        public System.Windows.Forms.ComboBox ComboBox_Port;
        public System.Windows.Forms.ComboBox ComboBox_Data;
        public System.Windows.Forms.ComboBox ComboBox_Stop;
        public System.Windows.Forms.ComboBox ComboBox_Parity;
        public System.Windows.Forms.CheckBox CheckBox_GSA;
        public System.Windows.Forms.CheckBox CheckBox_GGA;
        public System.Windows.Forms.CheckBox CheckBox_GSV;
        public System.Windows.Forms.CheckBox CheckBox_RMC;
        public System.Windows.Forms.CheckBox CheckBox_VTG;
        public System.Windows.Forms.RadioButton RadioButton_GNSS;
        public System.Windows.Forms.RadioButton RadioButton_GLONASS;
        public System.Windows.Forms.RadioButton RadioButton_GPS;
        public System.Windows.Forms.CheckBox CheckBox_AutoPower;
        public System.Windows.Forms.CheckBox CheckBox_TopMost;
        public System.Windows.Forms.CheckBox CheckBox_NotifyIcon;
        public System.Windows.Forms.CheckBox CheckBox_Taskbar;
        public System.Windows.Forms.CheckBox CheckBox_AutoRecord;
        public System.Windows.Forms.Button Button_LED_Color;
        public System.Windows.Forms.TextBox textBox1;
    }
}