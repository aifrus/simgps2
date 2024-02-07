using System;
using System.Drawing;
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
            this.MouseDown += FormSettings_MouseDown;
            this.MouseMove += FormSettings_MouseMove;
            this.MouseUp += FormSettings_MouseUp;
            this.FormClosing += FormSettings_FormClosing;
            this.Location = new Point(Settings.SettingsLocationX, Settings.SettingsLocationY);
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void FormSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            bWindowDragging = true;
            CursorAtDragStart = Cursor.Position;
            WindowAtDragStart = this.Location;
        }

        void FormSettings_MouseMove(object sender, MouseEventArgs e)
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

        void FormSettings_MouseUp(object sender, MouseEventArgs e)
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
    }
}
