namespace Aifrus.SimGPS2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Label_Hamburger = new System.Windows.Forms.Label();
            this.IconNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Power = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Power_LED = new System.Windows.Forms.Label();
            this.Label_GPS_LED = new System.Windows.Forms.Label();
            this.Label_COM_LED = new System.Windows.Forms.Label();
            this.Label_Record_LED = new System.Windows.Forms.Label();
            this.Label_Power_Label = new System.Windows.Forms.Label();
            this.Label_GPS_Label = new System.Windows.Forms.Label();
            this.Label_COM_Label = new System.Windows.Forms.Label();
            this.Label_Record_Label = new System.Windows.Forms.Label();
            this.Label_Record_Button = new System.Windows.Forms.Label();
            this.MenuContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Hamburger
            // 
            this.Label_Hamburger.BackColor = System.Drawing.Color.Transparent;
            this.Label_Hamburger.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Hamburger.ForeColor = System.Drawing.Color.White;
            this.Label_Hamburger.Location = new System.Drawing.Point(19, 16);
            this.Label_Hamburger.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Hamburger.Name = "Label_Hamburger";
            this.Label_Hamburger.Size = new System.Drawing.Size(19, 16);
            this.Label_Hamburger.TabIndex = 0;
            this.Label_Hamburger.Text = "☰";
            // 
            // IconNotifyIcon
            // 
            this.IconNotifyIcon.ContextMenuStrip = this.MenuContextMenu;
            this.IconNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("IconNotifyIcon.Icon")));
            this.IconNotifyIcon.Text = "SimGPS if off.";
            this.IconNotifyIcon.Visible = true;
            // 
            // MenuContextMenu
            // 
            this.MenuContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Power,
            this.MenuItem_Exit});
            this.MenuContextMenu.Name = "ContextMenu";
            this.MenuContextMenu.Size = new System.Drawing.Size(127, 48);
            // 
            // MenuItem_Power
            // 
            this.MenuItem_Power.Name = "MenuItem_Power";
            this.MenuItem_Power.Size = new System.Drawing.Size(126, 22);
            this.MenuItem_Power.Text = "Power On";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(126, 22);
            this.MenuItem_Exit.Text = "Exit";
            // 
            // Label_Power_LED
            // 
            this.Label_Power_LED.BackColor = System.Drawing.Color.Cyan;
            this.Label_Power_LED.Location = new System.Drawing.Point(72, 15);
            this.Label_Power_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Power_LED.Name = "Label_Power_LED";
            this.Label_Power_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_Power_LED.TabIndex = 1;
            // 
            // Label_GPS_LED
            // 
            this.Label_GPS_LED.BackColor = System.Drawing.Color.Cyan;
            this.Label_GPS_LED.Location = new System.Drawing.Point(142, 15);
            this.Label_GPS_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_GPS_LED.Name = "Label_GPS_LED";
            this.Label_GPS_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_GPS_LED.TabIndex = 2;
            // 
            // Label_COM_LED
            // 
            this.Label_COM_LED.BackColor = System.Drawing.Color.Cyan;
            this.Label_COM_LED.Location = new System.Drawing.Point(212, 15);
            this.Label_COM_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_COM_LED.Name = "Label_COM_LED";
            this.Label_COM_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_COM_LED.TabIndex = 3;
            // 
            // Label_Record_LED
            // 
            this.Label_Record_LED.BackColor = System.Drawing.Color.Red;
            this.Label_Record_LED.Location = new System.Drawing.Point(282, 15);
            this.Label_Record_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Record_LED.Name = "Label_Record_LED";
            this.Label_Record_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_Record_LED.TabIndex = 4;
            // 
            // Label_Power_Label
            // 
            this.Label_Power_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Power_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Power_Label.Location = new System.Drawing.Point(64, 25);
            this.Label_Power_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Power_Label.Name = "Label_Power_Label";
            this.Label_Power_Label.Size = new System.Drawing.Size(24, 10);
            this.Label_Power_Label.TabIndex = 5;
            this.Label_Power_Label.Text = "PWR";
            this.Label_Power_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_GPS_Label
            // 
            this.Label_GPS_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GPS_Label.ForeColor = System.Drawing.Color.White;
            this.Label_GPS_Label.Location = new System.Drawing.Point(134, 25);
            this.Label_GPS_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_GPS_Label.Name = "Label_GPS_Label";
            this.Label_GPS_Label.Size = new System.Drawing.Size(24, 10);
            this.Label_GPS_Label.TabIndex = 6;
            this.Label_GPS_Label.Text = "GPS";
            this.Label_GPS_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_COM_Label
            // 
            this.Label_COM_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_COM_Label.ForeColor = System.Drawing.Color.White;
            this.Label_COM_Label.Location = new System.Drawing.Point(204, 25);
            this.Label_COM_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_COM_Label.Name = "Label_COM_Label";
            this.Label_COM_Label.Size = new System.Drawing.Size(24, 10);
            this.Label_COM_Label.TabIndex = 7;
            this.Label_COM_Label.Text = "COM";
            this.Label_COM_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Record_Label
            // 
            this.Label_Record_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Record_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Record_Label.Location = new System.Drawing.Point(274, 25);
            this.Label_Record_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Record_Label.Name = "Label_Record_Label";
            this.Label_Record_Label.Size = new System.Drawing.Size(24, 10);
            this.Label_Record_Label.TabIndex = 8;
            this.Label_Record_Label.Text = "REC";
            this.Label_Record_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Record_Button
            // 
            this.Label_Record_Button.BackColor = System.Drawing.Color.Transparent;
            this.Label_Record_Button.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Record_Button.ForeColor = System.Drawing.Color.Red;
            this.Label_Record_Button.Location = new System.Drawing.Point(322, 16);
            this.Label_Record_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Record_Button.Name = "Label_Record_Button";
            this.Label_Record_Button.Size = new System.Drawing.Size(19, 16);
            this.Label_Record_Button.TabIndex = 9;
            this.Label_Record_Button.Text = "■";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aifrus.SimGPS2.Properties.Resources.FormMain_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(360, 120);
            this.Controls.Add(this.Label_Record_Button);
            this.Controls.Add(this.Label_Record_Label);
            this.Controls.Add(this.Label_COM_Label);
            this.Controls.Add(this.Label_GPS_Label);
            this.Controls.Add(this.Label_Power_Label);
            this.Controls.Add(this.Label_Record_LED);
            this.Controls.Add(this.Label_COM_LED);
            this.Controls.Add(this.Label_GPS_LED);
            this.Controls.Add(this.Label_Power_LED);
            this.Controls.Add(this.Label_Hamburger);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimGPS²";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.MenuContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Hamburger;
        private System.Windows.Forms.NotifyIcon IconNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip MenuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Power;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.Label Label_Power_LED;
        private System.Windows.Forms.Label Label_GPS_LED;
        private System.Windows.Forms.Label Label_COM_LED;
        private System.Windows.Forms.Label Label_Record_LED;
        private System.Windows.Forms.Label Label_Power_Label;
        private System.Windows.Forms.Label Label_GPS_Label;
        private System.Windows.Forms.Label Label_COM_Label;
        private System.Windows.Forms.Label Label_Record_Label;
        private System.Windows.Forms.Label Label_Record_Button;
    }
}

