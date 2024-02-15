using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aifrus.SimGPS2
{
    public partial class FormSettings : Form
    {
        private bool bWindowDragging = false;
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
            LoadSettings();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Hide();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            LoadSettings();
            this.Hide();
        }

        void GroupBox_AllSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            bWindowDragging = true;
            CursorAtDragStart = Cursor.Position;
            WindowAtDragStart = this.Location;
        }

        void GroupBox_AllSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (!bWindowDragging) return;
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
            bWindowDragging = false;
            Settings.SettingsLocationX = this.Location.X;
            Settings.SettingsLocationY = this.Location.Y;
            Settings.Save();
        }

        void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.SettingsLocationX = this.Location.X;
            Settings.SettingsLocationY = this.Location.Y;
            Settings.Save();
        }

        void LoadSettings()
        {
            TextBox_Hostname.Text = Settings.Hostname;
            ComboBox_Refresh.SelectedItem = Settings.RefreshRate;
            RadioButton_User.Checked = Settings.AutoStart == 2;
            RadioButton_Computer.Checked = Settings.AutoStart == 1;
            RadioButton_NoAuto.Checked = Settings.AutoStart == 0;
            CheckBox_AutoPower.Checked = Settings.AutoPower;
            CheckBox_AutoRecord.Checked = Settings.AutoRecord;
            CheckBox_TopMost.Checked = Settings.TopMost;
            CheckBox_Taskbar.Checked = Settings.ShowTaskbar;
            CheckBox_NotifyIcon.Checked = Settings.NotifyIcon;
            Button_LED_Color.BackColor = Settings.LEDColor;
            ComboBox_Port.SelectedItem = Settings.Port;
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
        }

        void SaveSettings()
        {
            if (!IsValidHostnameOrIP(TextBox_Hostname.Text))
            {
                MessageBox.Show("Please enter a valid hostname or IP address.");
                return;
            }
            Settings.Hostname = TextBox_Hostname.Text;
            Settings.RefreshRate = ComboBox_Refresh.SelectedItem.ToString();
            Settings.AutoStart = RadioButton_User.Checked ? 2 : RadioButton_Computer.Checked ? 1 : 0;
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
            if (RadioButton_GNSS.Checked) Settings.DeviceType = "GNSS";
            if (RadioButton_GLONASS.Checked) Settings.DeviceType = "GLONASS";
            if (RadioButton_GPS.Checked) Settings.DeviceType = "GPS";
            Settings.GGA = CheckBox_GGA.Checked;
            Settings.RMC = CheckBox_RMC.Checked;
            Settings.VTG = CheckBox_VTG.Checked;
            Settings.GSV = CheckBox_GSV.Checked;
            Settings.GSA = CheckBox_GSA.Checked;
            Settings.HemisphereNESW = RadioButton_Hemi_NESW.Checked;
            if (RadioButton_Num_DMS.Checked) Settings.LatLonFormat = "DMS";
            if (RadioButton_Num_Decimal.Checked) Settings.LatLonFormat = "Decimal";
            if (RadioButton_Altitude_FT.Checked) Settings.UnitsAltitude = "FT";
            if (RadioButton_Altitude_M.Checked) Settings.UnitsAltitude = "M";
            if (RadioButton_Speed_KMH.Checked) Settings.UnitsSpeed = "KPH";
            if (RadioButton_Speed_MPH.Checked) Settings.UnitsSpeed = "MPH";
            if (RadioButton_Speed_KT.Checked) Settings.UnitsSpeed = "KT";
            if (RadioButton_Distance_KM.Checked) Settings.UnitsDistance = "KM";
            if (RadioButton_Distance_SM.Checked) Settings.UnitsDistance = "SM";
            if (RadioButton_Distance_NM.Checked) Settings.UnitsDistance = "NM";
            Settings.Save();
        }

        bool IsValidHostnameOrIP(string hostname)
        {
            if (IPAddress.TryParse(hostname, out _)) return true;
            string FQDNPattern = @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$";
            if (Regex.IsMatch(hostname, FQDNPattern)) return true;
            return false;
        }

        private void Button_LED_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
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
            ComboBox_Baud.Enabled = false;
            ComboBox_Data.SelectedItem = "8";
            ComboBox_Data.Enabled = false;
            ComboBox_Parity.SelectedItem = "N - None";
            ComboBox_Parity.Enabled = false;
            ComboBox_Stop.SelectedItem = "1";
            ComboBox_Stop.Enabled = false;
            RadioButton_GNSS.Checked = true;
            RadioButton_GNSS.Enabled = false;
            RadioButton_GLONASS.Checked = false;
            RadioButton_GLONASS.Enabled = false;
            RadioButton_GPS.Checked = false;
            RadioButton_GPS.Enabled = false;
            CheckBox_GGA.Checked = true;
            CheckBox_GGA.Enabled = false;
            CheckBox_RMC.Checked = true;
            CheckBox_RMC.Enabled = false;
            CheckBox_VTG.Checked = true;
            CheckBox_VTG.Enabled = false;
            CheckBox_GSV.Checked = true;
            CheckBox_GSV.Enabled = false;
            CheckBox_GSA.Checked = true;
            CheckBox_GSA.Enabled = false;
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
            SaveSettings();
        }
    }
}
