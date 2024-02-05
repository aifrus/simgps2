using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aifrus.SimGPS2
{
    public partial class FormMain : Form
    {
        private bool WindowDragging = false;
        private Point CursorAtDragStart;
        private Point WindowAtDragStart;

        public FormMain()
        {
            InitializeComponent();

            this.Location = new Point(Properties.Settings.Default.WindowLocationX, Properties.Settings.Default.WindowLocationY);
            this.MouseDown += FormMain_MouseDown;
            this.MouseMove += FormMain_MouseMove;
            this.MouseUp += FormMain_MouseUp;
            this.Label_Hamburger.Click += Label_Hamburger_Click;
            this.FormClosing += FormMain_FormClosing;
            this.IconNotifyIcon.Click += NotifyIcon_Click;
            this.MenuItem_Exit.Click += MenuItem_Exit_Click;
        }

        void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            WindowDragging = true;
            CursorAtDragStart = Cursor.Position;
            WindowAtDragStart = this.Location;
        }

        void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!WindowDragging) return;
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

        void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            WindowDragging = false;
            Properties.Settings.Default.WindowLocationX = this.Location.X;
            Properties.Settings.Default.WindowLocationY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowLocationX = this.Location.X;
            Properties.Settings.Default.WindowLocationY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void Label_Hamburger_Click(object sender, EventArgs e)
        {
            MenuContextMenu.Show(Label_Hamburger, 0, Label_Hamburger.Height);
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}
