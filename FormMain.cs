﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aifrus.SimGPS2
{
    public partial class FormMain : Form
    {
        private readonly Properties.Settings Settings = Properties.Settings.Default;
        private readonly FormSettings FormSettings = new FormSettings();
        private bool bPowerOn = false;
        private bool bWindowDragging = false;
        private Point CursorAtDragStart;
        private Point WindowAtDragStart;

        public FormMain()
        {
            InitializeComponent();

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
            ApplyViewPreferences();
            PowerOff();
            if (Settings.AutoPower) PowerOn();
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

        private void PowerOn()
        {
            bPowerOn = true;
            var LEDColor = Settings.LEDColor;
            Label_Power_Label.ForeColor = Color.White;
            Label_Power_LED.BackColor = LEDColor;
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
            //Label_GPS_LED.BackColor = LEDColor;

            // Start the COM Output
            //Label_COM_LED.BackColor = LEDColor;

            // Start the recording
            //Label_Timer_Label.ForeColor = Color.White;
            //Label_Timer_Value.ForeColor = Color.Red;
        }

        private void PowerOff()
        {
            bPowerOn = false;
            // Stop the recording
            // Stop the COM Output
            // Disconnect the Simulator
            Color DarkGray = Color.FromArgb(32, 32, 32);
            Label_Power_Label.ForeColor = DarkGray;
            Label_Power_LED.BackColor = DarkGray;
            Label_GPS_Label.ForeColor = DarkGray;
            Label_GPS_LED.BackColor = DarkGray;
            Label_COM_Label.ForeColor = DarkGray;
            Label_COM_LED.BackColor = DarkGray;
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
            Label_Compass_Value.Text = "---";
            Label_Timer_Value.Text = "---:--:--";
            Label_Latitude_Value.Text = "----° --' --\"";
            Label_Longitude_Value.Text = "----° --' --\"";
            Label_Altitude_Value.Text = "- FT";
            Label_VSpeed_Value.Text = "--";
            Label_Speed_Value.Text = "-- KT";
            Label_Mag_Value.Text = "---";
            Label_Rev_Value.Text = "---";
            Label_Distance_Value.Text = "- NM";
            Label_Total_Value.Text = "- NM";
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
    }
}
