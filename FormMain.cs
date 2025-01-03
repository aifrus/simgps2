﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aifrus.SimGPS2
{
    public partial class FormMain : Form
    {
        private readonly Properties.Settings Settings = Properties.Settings.Default;
        private readonly FormSettings FormSettings = new FormSettings();
        private readonly SimConnectClient simConnectClient;
        private SimConnectClient.Struct1 simData;
        private bool bPowerOn = false;
        private bool bWindowDragging = false;
        private bool bShowTop = false;
        private bool bShowTopMin = false;
        private double MaxSpeed = 0;
        private double MaxAltitude = 0;
        private double MaxVSpeed = 0;
        private double MinVSpeed = 0;
        private double MaxDistance = 0;
        private double TotalDistance = 0;
        private double PinLatitude = 0;
        private double PinLongitude = 0;
        private double LastLatitude = 0;
        private double LastLongitude = 0;
        private Point CursorAtDragStart;
        private Point WindowAtDragStart;

        public FormMain()
        {
            InitializeComponent();
            simConnectClient = new SimConnectClient(this);
            Location = new Point(Properties.Settings.Default.MainLocationX, Properties.Settings.Default.MainLocationY);
            MouseDown += FormMain_MouseDown;
            MouseMove += FormMain_MouseMove;
            MouseUp += FormMain_MouseUp;
            Resize += FormMain_Resize;
            FormClosing += FormMain_FormClosing;
            Button_Hamburger.Click += Button_Hamburger_Click;
            IconNotifyIcon.Click += NotifyIcon_Click;
            MenuItem_ShowHide.Click += MenuItem_ShowHide_Click;
            MenuItem_Power.Click += MenuItem_Power_Click;
            MenuItem_Settings.Click += MenuItem_Settings_Click;
            MenuItem_Exit.Click += MenuItem_Exit_Click;
            Button_Top.MouseDown += Button_Top_MouseDown;
            Button_Top.MouseUp += Button_Top_MouseUp;
            ApplyViewPreferences();
            PowerOff();
            if (Settings.AutoPower) PowerOn();
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg != SimConnectClient.WM_USER_SIMCONNECT)
            {
                base.DefWndProc(ref m);
                return;
            }
            simConnectClient.ReceiveMessage();
        }

        void ApplyViewPreferences()
        {
            TopMost = Settings.TopMost;
            ShowInTaskbar = Settings.ShowTaskbar;
            IconNotifyIcon.Visible = Settings.NotifyIcon;
        }

        void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) MenuItem_ShowHide.Text = "S&how";
            else MenuItem_ShowHide.Text = "&Hide";
        }


        void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            bWindowDragging = true;
            CursorAtDragStart = Cursor.Position;
            WindowAtDragStart = Location;
        }

        void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!bWindowDragging) return;
            Point dif = Point.Subtract(Cursor.Position, new Size(CursorAtDragStart));
            Point newLocation = Point.Add(WindowAtDragStart, new Size(dif));
            Rectangle combinedBounds = Screen.AllScreens[0].Bounds;
            foreach (Screen screen in Screen.AllScreens) combinedBounds = Rectangle.Union(combinedBounds, screen.Bounds);
            if (newLocation.X < combinedBounds.Left) newLocation.X = combinedBounds.Left;
            if (newLocation.Y < combinedBounds.Top) newLocation.Y = combinedBounds.Top;
            if (newLocation.X > combinedBounds.Right - Width) newLocation.X = combinedBounds.Right - Width;
            if (newLocation.Y > combinedBounds.Bottom - Height) newLocation.Y = combinedBounds.Bottom - Height;
            Location = newLocation;
        }

        void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            bWindowDragging = false;
            Properties.Settings.Default.MainLocationX = Location.X;
            Properties.Settings.Default.MainLocationY = Location.Y;
            Properties.Settings.Default.Save();
        }

        void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainLocationX = Location.X;
            Properties.Settings.Default.MainLocationY = Location.Y;
            Properties.Settings.Default.Save();
        }

        private void MenuItem_Settings_Click(object sender, EventArgs e)
        {
            FormSettings.ShowDialog();
            ApplyViewPreferences();
            if (bPowerOn)
            {
                PowerOff();
                PowerOn();
            }
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void Button_Hamburger_Click(object sender, EventArgs e)
        {
            MenuContextMenu.Show(Button_Hamburger, 0, Button_Hamburger.Height);
        }

        private void Button_Set_Click(object sender, EventArgs e)
        {
            InfoClear();
        }

        private void Button_Top_MouseDown(object sender, MouseEventArgs e)
        {
            bShowTop = true;
            Timer_Top_Min.Start();
        }

        private void Button_Top_MouseUp(object sender, MouseEventArgs e)
        {
            bShowTop = false;
            Timer_Top_Min.Stop();
        }

        private void InfoClear()
        {
            MaxAltitude = 0;
            MaxSpeed = 0;
            MaxVSpeed = 0;
            MinVSpeed = 0;
            MaxDistance = 0;
            TotalDistance = 0;
            PinLatitude = 0;
            PinLongitude = 0;
            LastLatitude = 0;
            LastLongitude = 0;
        }

        private void PowerOn()
        {
            InfoClear();
            bPowerOn = true;
            var LEDColor = Settings.LEDColor;
            Label_Power_Label.ForeColor = Color.White;
            Label_Power_LED.ForeColor = LEDColor;
            Label_GPS_Label.ForeColor = Color.White;
            Label_COM_Label.ForeColor = Color.White;
            Label_Compass_Value.ForeColor = LEDColor;
            Label_Latitude_Label.ForeColor = Color.White;
            Label_Latitude_Value.ForeColor = LEDColor;
            Label_Longitude_Label.ForeColor = Color.White;
            Label_Longitude_Value.ForeColor = LEDColor;
            Label_Altitude_Label.ForeColor = Color.White;
            Label_Altitude_Value.ForeColor = LEDColor;
            Label_VSpeed_Label.ForeColor = Color.White;
            Label_VSpeed_Value.ForeColor = LEDColor;
            Label_Speed_Label.ForeColor = Color.White;
            Label_Speed_Value.ForeColor = LEDColor;
            Label_Mag_Label.ForeColor = Color.White;
            Label_Mag_Value.ForeColor = LEDColor;
            Label_Mag_Deg_Label.ForeColor = Color.White;
            Label_Rev_Label.ForeColor = Color.White;
            Label_Rev_Value.ForeColor = LEDColor;
            Label_Rev_Deg_Label.ForeColor = Color.White;
            Label_Distance_Label.ForeColor = Color.White;
            Label_Distance_Value.ForeColor = LEDColor;
            Label_Total_Label.ForeColor = Color.White;
            Label_Total_Value.ForeColor = LEDColor;
            Button_Record.Enabled = true;
            Button_Top.Enabled = true;
            Button_Set.Enabled = true;
            Button_Record.FlatAppearance.BorderColor = Color.DarkGray;
            Button_Top.FlatAppearance.BorderColor = Color.DarkGray;
            Button_Set.FlatAppearance.BorderColor = Color.DarkGray;
            IconNotifyIcon.Text = "SimGPS is on.";
            MenuItem_Power.Text = "Power Off";

            // Connect the Simulator
            Timer_GPS_SlowBlink.Start();
            if (!simConnectClient.Connect(Settings.Hostname))
            {
                Label_GPS_LED.ForeColor = Color.Red;
                return;
            }

            if (Settings.EnableOverlay) Timer_Overlay_Write.Start();

            // Start the COM Output
            //Label_COM_LED.ForeColor = LEDColor;

            // Start the recording
            //Label_Timer_Label.ForeColor = Color.White;
            //Label_Timer_Value.ForeColor = Color.Red;
        }

        private void PowerOff()
        {
            InfoClear();
            bPowerOn = false;
            // Stop the recording
            // Stop the COM Output

            // Disconnect the Simulator
            Timer_Overlay_Write.Stop();
            Timer_GPS_SlowBlink.Stop();
            Timer_GPS_FastBlink.Stop();
            Timer_GPS_Update.Stop();
            simConnectClient.Disconnect();

            Color DarkGray = Color.FromArgb(32, 32, 32);
            Label_Power_Label.ForeColor = DarkGray;
            Label_Power_LED.ForeColor = DarkGray;
            Label_GPS_Label.ForeColor = DarkGray;
            Label_GPS_LED.ForeColor = DarkGray;
            Label_COM_Label.ForeColor = DarkGray;
            Label_COM_LED.ForeColor = DarkGray;
            Label_Compass_Value.ForeColor = DarkGray;
            Label_Timer_Label.ForeColor = DarkGray;
            Label_Timer_Value.ForeColor = DarkGray;
            Label_Latitude_Label.ForeColor = DarkGray;
            Label_Latitude_Value.ForeColor = DarkGray;
            Label_Longitude_Label.ForeColor = DarkGray;
            Label_Longitude_Value.ForeColor = DarkGray;
            Label_Altitude_Label.ForeColor = DarkGray;
            Label_Altitude_Value.ForeColor = DarkGray;
            Label_VSpeed_Label.ForeColor = DarkGray;
            Label_VSpeed_Value.ForeColor = DarkGray;
            Label_Speed_Label.ForeColor = DarkGray;
            Label_Speed_Value.ForeColor = DarkGray;
            Label_Mag_Label.ForeColor = DarkGray;
            Label_Mag_Value.ForeColor = DarkGray;
            Label_Mag_Deg_Label.ForeColor = DarkGray;
            Label_Rev_Label.ForeColor = DarkGray;
            Label_Rev_Value.ForeColor = DarkGray;
            Label_Rev_Deg_Label.ForeColor = DarkGray;
            Label_VSpeed_Label.ForeColor = DarkGray;
            Label_VSpeed_Value.ForeColor = DarkGray;
            Label_Distance_Label.ForeColor = DarkGray;
            Label_Distance_Value.ForeColor = DarkGray;
            Label_Total_Label.ForeColor = DarkGray;
            Label_Total_Value.ForeColor = DarkGray;
            Button_Record.Enabled = false;
            Button_Top.Enabled = false;
            Button_Set.Enabled = false;
            Button_Record.FlatAppearance.BorderColor = DarkGray;
            Button_Top.FlatAppearance.BorderColor = DarkGray;
            Button_Set.FlatAppearance.BorderColor = DarkGray;
            Label_Compass_Value.Text = "▣▣▣";
            Label_Timer_Value.Text = "▣▣▣▣▣▣▣▣▣";
            Label_Latitude_Value.Text = "▣▣▣▣▣▣▣▣▣▣▣▣▣";
            Label_Longitude_Value.Text = "▣▣▣▣▣▣▣▣▣▣▣▣▣";
            Label_Altitude_Value.Text = "▣▣▣▣▣▣▣▣▣";
            Label_VSpeed_Value.Text = "▣▣▣";
            Label_Speed_Value.Text = "▣▣▣▣▣▣";
            Label_Mag_Value.Text = "▣▣▣";
            Label_Rev_Value.Text = "▣▣▣";
            Label_Distance_Value.Text = "▣▣▣▣▣▣";
            Label_Total_Value.Text = "▣▣▣▣▣▣";
            IconNotifyIcon.Text = "SimGPS is off.";
            MenuItem_Power.Text = "Power On";
        }

        private void MenuItem_Power_Click(object sender, EventArgs e)
        {
            if (bPowerOn) PowerOff();
            else PowerOn();
        }

        private void MenuItem_ShowHide_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                Activate();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        public void SimConnected()
        {
            Timer_GPS_SlowBlink.Stop();
            Timer_GPS_FastBlink.Start();
            Timer_GPS_Update.Start();
        }

        public void SimDisconnected()
        {
            Timer_GPS_Update.Stop();
            Timer_GPS_FastBlink.Stop();
            Label_GPS_LED.ForeColor = Color.FromArgb(32, 32, 32);
        }

        private void Timer_GPS_SlowBlink_Tick(object sender, EventArgs e)
        {
            Label_GPS_LED.ForeColor = Label_GPS_LED.ForeColor == Settings.LEDColor ? Color.FromArgb(32, 32, 32) : Settings.LEDColor;
        }

        private void Timer_GPS_FastBlink_Tick(object sender, EventArgs e)
        {
            Label_GPS_LED.ForeColor = Label_GPS_LED.ForeColor == Settings.LEDColor ? Color.FromArgb(32, 32, 32) : Settings.LEDColor;
        }

        private void Timer_GPS_Update_Tick(object sender, EventArgs e)
        {
            simConnectClient.RequestData();
        }

        private void Timer_Top_Min_Tick(object sender, EventArgs e)
        {
            bShowTopMin = !bShowTopMin;
        }

        public void UpdateSimData(SimConnectClient.Struct1 data)
        {
            simData = data;
            if (data.groundSpeed > MaxSpeed) MaxSpeed = data.groundSpeed;
            if (data.altitude > MaxAltitude) MaxAltitude = data.altitude;
            if (data.verticalSpeed > MaxVSpeed) MaxVSpeed = data.verticalSpeed;
            if (data.verticalSpeed < MinVSpeed) MinVSpeed = data.verticalSpeed;

            if (PinLatitude == 0) PinLatitude = data.latitude;
            if (PinLongitude == 0) PinLongitude = data.longitude;
            if (LastLatitude == 0) LastLatitude = data.latitude;
            if (LastLongitude == 0) LastLongitude = data.longitude;
            TotalDistance += Distance(LastLatitude, LastLongitude, data.latitude, data.longitude);
            Label_Total_Value.Text = Display_Distance(TotalDistance);
            LastLatitude = data.latitude;
            LastLongitude = data.longitude;
            double CurrentDistance = Distance(PinLatitude, PinLongitude, data.latitude, data.longitude);
            if (CurrentDistance > MaxDistance) MaxDistance = CurrentDistance;
            if (bShowTop) Label_Distance_Value.Text = Display_Distance(MaxDistance);
            else Label_Distance_Value.Text = Display_Distance(CurrentDistance);

            Label_GPS_LED.ForeColor = Settings.LEDColor;
            Label_Latitude_Value.Text = Display_Latitude(data.latitude);
            Label_Longitude_Value.Text = Display_Longitude(data.longitude);
            Label_Compass_Value.Text = Display_Compass(data.magCourse);
            Label_Mag_Value.Text = Display_MagCourse(data.magCourse);
            Label_Rev_Value.Text = Display_RevCourse(data.magCourse);
            if (bShowTop)
            {
                Label_Altitude_Value.Text = Display_Altitude(MaxAltitude);
                Label_Speed_Value.Text = Display_Speed(MaxSpeed);
                if (bShowTopMin) Label_VSpeed_Value.Text = Display_VSpeed(MinVSpeed);
                else Label_VSpeed_Value.Text = Display_VSpeed(MaxVSpeed);
                return;
            }
            Label_Altitude_Value.Text = Display_Altitude(data.altitude);
            Label_VSpeed_Value.Text = Display_VSpeed(data.verticalSpeed);
            Label_Speed_Value.Text = Display_Speed(data.groundSpeed);
        }

        private double Distance(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371; // Radius of the earth in km
            double dLat = (lat2 - lat1) * Math.PI / 180;  // deg2rad below
            double dLon = (lon2 - lon1) * Math.PI / 180;
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c; // Distance in km
        }

        private string Display_Distance(double distance)
        {
            if (Settings.UnitsDistance == "NM")
            {
                return (distance * 0.539957).ToString("#,##0.0") + " NM";
            }
            else if (Settings.UnitsDistance == "KM")
            {
                return distance.ToString("#,##0.0") + " KM";
            }
            else
            {
                return (distance * 0.621371).ToString("#,##0.0") + " SM";
            }
        }

        private string Display_Latitude(double latitude)
        {
            string result = Settings.HemisphereNESW ? latitude >= 0 ? "N" : "S" : latitude >= 0 ? "+" : "-";
            if (Settings.LatLonFormat == "Decimal")
            {
                result += " " + Math.Abs(latitude).ToString("00.000000");
            }
            else
            {
                double absLat = Math.Abs(latitude);
                int degrees = (int)Math.Floor(absLat);
                double decimalMinutes = (absLat - degrees) * 60;
                int minutes = (int)Math.Floor(decimalMinutes);
                double seconds = (decimalMinutes - minutes) * 60;
                result += $" {degrees:00}° {minutes:00}' {seconds:00}\"";
            }
            return result;
        }

        private string Display_Longitude(double longitude)
        {
            string result = Settings.HemisphereNESW ? longitude >= 0 ? "E" : "W" : longitude >= 0 ? "+" : "-";
            if (Settings.LatLonFormat == "Decimal")
            {
                result += Math.Abs(longitude).ToString("000.000000");
            }
            else
            {
                double absLon = Math.Abs(longitude);
                int degrees = (int)Math.Floor(absLon);
                double decimalMinutes = (absLon - degrees) * 60;
                int minutes = (int)Math.Floor(decimalMinutes);
                double seconds = (decimalMinutes - minutes) * 60;
                result += $"{degrees:000}° {minutes:00}' {seconds:00}\"";
            }
            return result;
        }


        private string Display_Altitude(double altitude)
        {
            if (Settings.UnitsAltitude == "FT")
            {
                return $"{altitude * 3.28084:N0} FT";
            }
            else
            {
                return $"{altitude:N0} M";
            }
        }


        private string Display_Compass(double magCourse)
        {
            string[] compass = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW" };
            return compass[(int)Math.Round(magCourse / 22.5) % 16];
        }

        private string Display_MagCourse(double magCourse)
        {
            return $"{Math.Round(magCourse):000}°";
        }

        private string Display_RevCourse(double magCourse)
        {
            return $"{Math.Round((magCourse + 180) % 360):000}°";
        }

        private string Display_VSpeed(double verticalSpeed)
        {
            if (Settings.UnitsAltitude == "FT")
            {
                return (verticalSpeed * 3.28084).ToString("+#,##0;-#,##0");
            }
            else
            {
                return verticalSpeed.ToString("+#,##0;-#,##0");
            }
        }

        private string Display_Speed(double groundSpeed)
        {
            if (Settings.UnitsSpeed == "KT")
            {
                return (Math.Abs(groundSpeed) * 1.94384).ToString("#,##0") + " KT";
            }
            else if (Settings.UnitsSpeed == "KMH")
            {
                return (Math.Abs(groundSpeed) * 3.6).ToString("#,##0") + " KMH";
            }
            else if (Settings.UnitsSpeed == "MPH")
            {
                return (Math.Abs(groundSpeed) * 2.23694).ToString("#,##0") + " MPH";
            }
            return Math.Abs(groundSpeed).ToString("#,##0") + " M/S";
        }

        private void Timer_Overlay_Write_Tick(object sender, EventArgs e)
        {
            string overlayPath = Settings.OBSPath;
            string content = $"LAT: {Display_Latitude(simData.latitude)}\n" +
                             $"LON: {Display_Longitude(simData.longitude)}\n" +
                             $"ALT: {Display_Altitude(simData.altitude)}\n" +
                             $"V/S: {Display_VSpeed(simData.verticalSpeed)}\n" +
                             $"G/S: {Display_Speed(simData.groundSpeed)}\n" +
                             $"HDG: {Display_MagCourse(simData.magCourse)} ({Display_Compass(simData.magCourse)})\n";

            System.IO.File.WriteAllText(overlayPath, content);
        }

    }
}
