using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aifrus.SimGPS2
{
    public partial class FormSettings : Form
    {
        private const int AutoStartNoAuto = 0;
        private const int AutoStartComputer = 1;
        private const int AutoStartUser = 2;
        private bool isWindowDragging = false;
        private Point CursorAtDragStart;
        private Point WindowAtDragStart;
        private Properties.Settings Settings = Properties.Settings.Default;


        public FormSettings()
        {
            InitializeComponent();
            this.GroupBox_AllSettings.MouseDown += GroupBox_AllSettings_MouseDown;
            this.GroupBox_AllSettings.MouseMove += GroupBox_AllSettings_MouseMove;
            this.GroupBox_AllSettings.MouseUp += GroupBox_AllSettings_MouseUp;
            this.FormClosing += FormSettings_FormClosing;
            this.Location = new Point(Settings.SettingsLocationX, Settings.SettingsLocationY);
            this.RadioButton_GPS.CheckedChanged += RadioButton_DeviceType_Changed;
            this.RadioButton_GNSS.CheckedChanged += RadioButton_DeviceType_Changed;
            this.RadioButton_GLONASS.CheckedChanged += RadioButton_DeviceType_Changed;
            LoadSettings();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (SaveSettings()) this.Hide();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            LoadSettings();
            this.Hide();
        }

        void GroupBox_AllSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isWindowDragging = true;
            CursorAtDragStart = Cursor.Position;
            WindowAtDragStart = this.Location;
        }

        void GroupBox_AllSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isWindowDragging) return;
            Point dif = Point.Subtract(Cursor.Position, new Size(CursorAtDragStart));
            Point newLocation = Point.Add(WindowAtDragStart, new Size(dif));
            Rectangle combinedBounds = Screen.AllScreens[0].Bounds;
            foreach (Screen screen in Screen.AllScreens) combinedBounds = Rectangle.Union(combinedBounds, screen.Bounds);
            if (newLocation.X < combinedBounds.Left) newLocation.X = combinedBounds.Left;
            if (newLocation.Y < combinedBounds.Top) newLocation.Y = combinedBounds.Top;
            if (newLocation.X > combinedBounds.Right - this.Width) newLocation.X = combinedBounds.Right - this.Width;
            if (newLocation.Y > combinedBounds.Bottom - this.Height) newLocation.Y = combinedBounds.Bottom - this.Height;
            this.Location = newLocation;
        }

        void GroupBox_AllSettings_MouseUp(object sender, MouseEventArgs e)
        {
            isWindowDragging = false;
            SaveWindowLocation();
        }

        void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowLocation();
        }

        private void SaveWindowLocation()
        {
            Settings.SettingsLocationX = this.Location.X;
            Settings.SettingsLocationY = this.Location.Y;
            Settings.Save();
        }

        private void EnableDisable()
        {
            bool isEnabled = ComboBox_Port.SelectedItem.ToString() != "Disabled";

            ComboBox_Baud.Enabled = isEnabled;
            ComboBox_Data.Enabled = isEnabled;
            ComboBox_Parity.Enabled = isEnabled;
            ComboBox_Stop.Enabled = isEnabled;
            GroupBox_DeviceType.Enabled = isEnabled;
            GroupBox_NMEA.Enabled = isEnabled;
        }


        void LoadSettings()
        {
            TextBox_Hostname.Text = Settings.Hostname;
            ComboBox_Refresh.SelectedItem = Settings.RefreshRate;
            RadioButton_User.Checked = Settings.AutoStart == AutoStartUser;
            RadioButton_Computer.Checked = Settings.AutoStart == AutoStartComputer;
            RadioButton_NoAuto.Checked = Settings.AutoStart == AutoStartNoAuto;
            CheckBox_AutoPower.Checked = Settings.AutoPower;
            CheckBox_AutoRecord.Checked = Settings.AutoRecord;
            CheckBox_TopMost.Checked = Settings.TopMost;
            CheckBox_Taskbar.Checked = Settings.ShowTaskbar;
            CheckBox_NotifyIcon.Checked = Settings.NotifyIcon;
            Button_LED_Color.BackColor = Settings.LEDColor;
            ComboBox_Port.Items.Clear();
            ComboBox_Port.Items.Add("Disabled");
            var portNames = System.IO.Ports.SerialPort.GetPortNames();
            Array.Sort(portNames);
            foreach (string port in portNames) ComboBox_Port.Items.Add(port);
            ComboBox_Port.SelectedIndex = 0;
            if (ComboBox_Port.Items.Contains(Settings.Port)) ComboBox_Port.SelectedItem = Settings.Port;
            ComboBox_Baud.SelectedItem = Settings.Baud;
            ComboBox_Data.SelectedItem = Settings.Data;
            ComboBox_Parity.SelectedItem = Settings.Parity;
            ComboBox_Stop.SelectedItem = Settings.Stop;
            RadioButton_GNSS.Checked = Settings.DeviceType == "GNSS";
            RadioButton_GLONASS.Checked = Settings.DeviceType == "GLONASS";
            RadioButton_GPS.Checked = Settings.DeviceType == "GPS";
            CheckBox_GGA.Checked = Settings.GGA;
            CheckBox_RMC.Checked = Settings.RMC;
            CheckBox_VTG.Checked = Settings.VTG;
            CheckBox_GSV.Checked = Settings.GSV;
            CheckBox_GSA.Checked = Settings.GSA;
            RadioButton_Hemi_NESW.Checked = Settings.HemisphereNESW;
            RadioButton_Hemi_PM.Checked = !Settings.HemisphereNESW;
            RadioButton_Num_DMS.Checked = Settings.LatLonFormat == "DMS";
            RadioButton_Num_Decimal.Checked = Settings.LatLonFormat == "Decimal";
            RadioButton_Altitude_FT.Checked = Settings.UnitsAltitude == "FT";
            RadioButton_Altitude_M.Checked = Settings.UnitsAltitude == "M";
            RadioButton_Speed_KMH.Checked = Settings.UnitsSpeed == "KPH";
            RadioButton_Speed_MPH.Checked = Settings.UnitsSpeed == "MPH";
            RadioButton_Speed_KT.Checked = Settings.UnitsSpeed == "KT";
            RadioButton_Distance_KM.Checked = Settings.UnitsDistance == "KM";
            RadioButton_Distance_SM.Checked = Settings.UnitsDistance == "SM";
            RadioButton_Distance_NM.Checked = Settings.UnitsDistance == "NM";
            if (Settings.RecordPath.Contains("{My Documents}")) Settings.RecordPath = Settings.RecordPath.Replace("{My Documents}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            TextBox_RecordPath.Text = Settings.RecordPath;
            if (!System.IO.Directory.Exists(Settings.RecordPath)) System.IO.Directory.CreateDirectory(Settings.RecordPath);
            EnableDisable();
            SetSentences(Settings.DeviceType);
        }

        private bool SaveSettings()
        {
            if (!IsValidHostnameOrIP(TextBox_Hostname.Text))
            {
                MessageBox.Show("Please enter a valid hostname or IP address.");
                TextBox_Hostname.Focus();
                TextBox_Hostname.SelectAll();
                return false;
            }
            if (!IsValidRecordPath(TextBox_RecordPath.Text))
            {
                MessageBox.Show("Please enter a valid record path.");
                TextBox_RecordPath.Focus();
                TextBox_RecordPath.SelectAll();
                return false;
            }
            Settings.Hostname = TextBox_Hostname.Text;
            Settings.RefreshRate = ComboBox_Refresh.SelectedItem.ToString();
            Settings.AutoStart = RadioButton_User.Checked ? AutoStartUser : RadioButton_Computer.Checked ? AutoStartComputer : AutoStartNoAuto;
            Settings.AutoPower = CheckBox_AutoPower.Checked;
            Settings.AutoRecord = CheckBox_AutoRecord.Checked;
            Settings.TopMost = CheckBox_TopMost.Checked;
            Settings.ShowTaskbar = CheckBox_Taskbar.Checked;
            Settings.NotifyIcon = CheckBox_NotifyIcon.Checked;
            Settings.LEDColor = Button_LED_Color.BackColor;
            Settings.Port = ComboBox_Port.SelectedItem.ToString();
            Settings.Baud = ComboBox_Baud.SelectedItem.ToString();
            Settings.Data = ComboBox_Data.SelectedItem.ToString();
            Settings.Parity = ComboBox_Parity.SelectedItem.ToString();
            Settings.Stop = ComboBox_Stop.SelectedItem.ToString();
            Settings.DeviceType = RadioButton_GNSS.Checked ? "GNSS" :
                                  RadioButton_GLONASS.Checked ? "GLONASS" :
                                  RadioButton_GPS.Checked ? "GPS" : Settings.DeviceType;
            Settings.GGA = CheckBox_GGA.Checked;
            Settings.RMC = CheckBox_RMC.Checked;
            Settings.VTG = CheckBox_VTG.Checked;
            Settings.GSV = CheckBox_GSV.Checked;
            Settings.GSA = CheckBox_GSA.Checked;
            Settings.HemisphereNESW = RadioButton_Hemi_NESW.Checked;
            Settings.LatLonFormat = GetSelectedRadioButton(RadioButton_Num_DMS, RadioButton_Num_Decimal);
            Settings.UnitsAltitude = GetSelectedRadioButton(RadioButton_Altitude_FT, RadioButton_Altitude_M);
            Settings.UnitsSpeed = GetSelectedRadioButton(RadioButton_Speed_KMH, RadioButton_Speed_MPH, RadioButton_Speed_KT);
            Settings.UnitsDistance = GetSelectedRadioButton(RadioButton_Distance_KM, RadioButton_Distance_SM, RadioButton_Distance_NM);
            try { Settings.Save(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}");
                return false;
            }
            return true;
        }

        private string GetSelectedRadioButton(params RadioButton[] radioButtons)
        {
            foreach (var radioButton in radioButtons) if (radioButton.Checked) return radioButton.Text;
            return null;
        }

        bool IsValidHostnameOrIP(string hostname)
        {
            if (IPAddress.TryParse(hostname, out _)) return true;
            string FQDNPattern = @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$";
            if (Regex.IsMatch(hostname, FQDNPattern)) return true;
            return false;
        }

        bool IsValidRecordPath(string recordPath)
        {
            if (string.IsNullOrWhiteSpace(recordPath)) return false;
            if (recordPath.Contains("{My Documents}")) recordPath = recordPath.Replace("{My Documents}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            if (System.IO.Directory.Exists(recordPath)) return true;
            return false;
        }

        private void Button_LED_Color_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.Color = Button_LED_Color.BackColor;
            colorDialog.ShowDialog();
            Button_LED_Color.BackColor = colorDialog.Color;
        }

        private void Button_Defaults_Click(object sender, EventArgs e)
        {
            TextBox_Hostname.Text = "localhost";
            ComboBox_Refresh.SelectedItem = "60 FPS";
            RadioButton_User.Checked = false;
            RadioButton_Computer.Checked = false;
            RadioButton_NoAuto.Checked = true;
            CheckBox_AutoPower.Checked = false;
            CheckBox_AutoRecord.Checked = false;
            CheckBox_TopMost.Checked = false;
            CheckBox_Taskbar.Checked = false;
            CheckBox_NotifyIcon.Checked = true;
            Button_LED_Color.BackColor = Color.Cyan;
            ComboBox_Port.SelectedItem = "Disabled";
            ComboBox_Baud.SelectedItem = "4800";
            ComboBox_Data.SelectedItem = "8";
            ComboBox_Parity.SelectedItem = "N - None";
            ComboBox_Stop.SelectedItem = "1";
            RadioButton_GNSS.Checked = true;
            RadioButton_GLONASS.Checked = false;
            RadioButton_GPS.Checked = false;
            CheckBox_GGA.Checked = true;
            CheckBox_RMC.Checked = true;
            CheckBox_VTG.Checked = true;
            CheckBox_GSV.Checked = true;
            CheckBox_GSA.Checked = true;
            RadioButton_Hemi_NESW.Checked = true;
            RadioButton_Hemi_PM.Checked = false;
            RadioButton_Num_DMS.Checked = true;
            RadioButton_Num_Decimal.Checked = false;
            RadioButton_Altitude_FT.Checked = true;
            RadioButton_Altitude_M.Checked = false;
            RadioButton_Speed_KMH.Checked = false;
            RadioButton_Speed_MPH.Checked = false;
            RadioButton_Speed_KT.Checked = true;
            RadioButton_Distance_KM.Checked = false;
            RadioButton_Distance_SM.Checked = false;
            RadioButton_Distance_NM.Checked = true;
            EnableDisable();
            SetSentences("GNSS");
            SaveSettings();
        }

        private void ComboBox_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void RadioButton_DeviceType_Changed(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;
            SetSentences(rb.Text);
        }

        void SetSentences(string DeviceType)
        {
            string DeviceTypeShort = DeviceType.Substring(0, 2);
            CheckBox_GGA.Text = $"{DeviceTypeShort}GGA";
            CheckBox_RMC.Text = $"{DeviceTypeShort}RMC";
            CheckBox_VTG.Text = $"{DeviceTypeShort}VTG";
            CheckBox_GSV.Text = $"{DeviceTypeShort}GSV";
            CheckBox_GSA.Text = $"{DeviceTypeShort}GSA";
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = TextBox_RecordPath.Text;
            folderBrowserDialog.ShowDialog();
            TextBox_RecordPath.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
