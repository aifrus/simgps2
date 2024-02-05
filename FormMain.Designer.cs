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
            this.Label_Latitude_Label = new System.Windows.Forms.Label();
            this.Label_Longitude_Label = new System.Windows.Forms.Label();
            this.Label_Altitude_Label = new System.Windows.Forms.Label();
            this.Label_Status_Value = new System.Windows.Forms.Label();
            this.Label_True_Label = new System.Windows.Forms.Label();
            this.Label_Mag_Label = new System.Windows.Forms.Label();
            this.Label_Speed_Label = new System.Windows.Forms.Label();
            this.Label_Speed_Value = new System.Windows.Forms.Label();
            this.Label_True_Value = new System.Windows.Forms.Label();
            this.Label_Mag_Value = new System.Windows.Forms.Label();
            this.Label_Altitude_Value = new System.Windows.Forms.Label();
            this.Label_Longitude_Value = new System.Windows.Forms.Label();
            this.Label_Latitude_Value = new System.Windows.Forms.Label();
            this.Label_Timer_Value = new System.Windows.Forms.Label();
            this.Label_Timer_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Hamburger
            // 
            this.Label_Hamburger.BackColor = System.Drawing.Color.Transparent;
            this.Label_Hamburger.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Label_Record_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Record_Button.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Record_Button.ForeColor = System.Drawing.Color.Red;
            this.Label_Record_Button.Location = new System.Drawing.Point(322, 16);
            this.Label_Record_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Record_Button.Name = "Label_Record_Button";
            this.Label_Record_Button.Size = new System.Drawing.Size(19, 16);
            this.Label_Record_Button.TabIndex = 9;
            this.Label_Record_Button.Text = "■";
            // 
            // Label_Latitude_Label
            // 
            this.Label_Latitude_Label.AutoSize = true;
            this.Label_Latitude_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Latitude_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Latitude_Label.Location = new System.Drawing.Point(21, 51);
            this.Label_Latitude_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Latitude_Label.Name = "Label_Latitude_Label";
            this.Label_Latitude_Label.Size = new System.Drawing.Size(53, 9);
            this.Label_Latitude_Label.TabIndex = 10;
            this.Label_Latitude_Label.Text = "LATITUDE";
            this.Label_Latitude_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Longitude_Label
            // 
            this.Label_Longitude_Label.AutoSize = true;
            this.Label_Longitude_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Longitude_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Longitude_Label.Location = new System.Drawing.Point(20, 72);
            this.Label_Longitude_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Longitude_Label.Name = "Label_Longitude_Label";
            this.Label_Longitude_Label.Size = new System.Drawing.Size(59, 9);
            this.Label_Longitude_Label.TabIndex = 11;
            this.Label_Longitude_Label.Text = "LONGITUDE";
            this.Label_Longitude_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Altitude_Label
            // 
            this.Label_Altitude_Label.AutoSize = true;
            this.Label_Altitude_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Altitude_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Altitude_Label.Location = new System.Drawing.Point(20, 91);
            this.Label_Altitude_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Altitude_Label.Name = "Label_Altitude_Label";
            this.Label_Altitude_Label.Size = new System.Drawing.Size(53, 9);
            this.Label_Altitude_Label.TabIndex = 12;
            this.Label_Altitude_Label.Text = "ALTITUDE";
            this.Label_Altitude_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Status_Value
            // 
            this.Label_Status_Value.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Status_Value.Location = new System.Drawing.Point(15, 101);
            this.Label_Status_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Status_Value.Name = "Label_Status_Value";
            this.Label_Status_Value.Size = new System.Drawing.Size(332, 10);
            this.Label_Status_Value.TabIndex = 13;
            this.Label_Status_Value.Text = "CONNECTED TO SIMULATOR";
            this.Label_Status_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_True_Label
            // 
            this.Label_True_Label.AutoSize = true;
            this.Label_True_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_True_Label.ForeColor = System.Drawing.Color.White;
            this.Label_True_Label.Location = new System.Drawing.Point(165, 72);
            this.Label_True_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_True_Label.Name = "Label_True_Label";
            this.Label_True_Label.Size = new System.Drawing.Size(29, 9);
            this.Label_True_Label.TabIndex = 14;
            this.Label_True_Label.Text = "TRUE";
            this.Label_True_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Mag_Label
            // 
            this.Label_Mag_Label.AutoSize = true;
            this.Label_Mag_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mag_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Mag_Label.Location = new System.Drawing.Point(167, 51);
            this.Label_Mag_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Mag_Label.Name = "Label_Mag_Label";
            this.Label_Mag_Label.Size = new System.Drawing.Size(23, 9);
            this.Label_Mag_Label.TabIndex = 15;
            this.Label_Mag_Label.Text = "MAG";
            this.Label_Mag_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Speed_Label
            // 
            this.Label_Speed_Label.AutoSize = true;
            this.Label_Speed_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Speed_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Speed_Label.Location = new System.Drawing.Point(162, 92);
            this.Label_Speed_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Speed_Label.Name = "Label_Speed_Label";
            this.Label_Speed_Label.Size = new System.Drawing.Size(35, 9);
            this.Label_Speed_Label.TabIndex = 16;
            this.Label_Speed_Label.Text = "SPEED";
            this.Label_Speed_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Speed_Value
            // 
            this.Label_Speed_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Speed_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Speed_Value.Location = new System.Drawing.Point(137, 82);
            this.Label_Speed_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Speed_Value.Name = "Label_Speed_Value";
            this.Label_Speed_Value.Size = new System.Drawing.Size(83, 10);
            this.Label_Speed_Value.TabIndex = 17;
            this.Label_Speed_Value.Text = "420 KT";
            this.Label_Speed_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_True_Value
            // 
            this.Label_True_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_True_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_True_Value.Location = new System.Drawing.Point(137, 62);
            this.Label_True_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_True_Value.Name = "Label_True_Value";
            this.Label_True_Value.Size = new System.Drawing.Size(83, 10);
            this.Label_True_Value.TabIndex = 18;
            this.Label_True_Value.Text = "238";
            this.Label_True_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Mag_Value
            // 
            this.Label_Mag_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mag_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Mag_Value.Location = new System.Drawing.Point(137, 41);
            this.Label_Mag_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Mag_Value.Name = "Label_Mag_Value";
            this.Label_Mag_Value.Size = new System.Drawing.Size(83, 10);
            this.Label_Mag_Value.TabIndex = 19;
            this.Label_Mag_Value.Text = "222";
            this.Label_Mag_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Altitude_Value
            // 
            this.Label_Altitude_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Altitude_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Altitude_Value.Location = new System.Drawing.Point(20, 81);
            this.Label_Altitude_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Altitude_Value.Name = "Label_Altitude_Value";
            this.Label_Altitude_Value.Size = new System.Drawing.Size(117, 11);
            this.Label_Altitude_Value.TabIndex = 20;
            this.Label_Altitude_Value.Text = "43,201 FT";
            this.Label_Altitude_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Longitude_Value
            // 
            this.Label_Longitude_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Longitude_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Longitude_Value.Location = new System.Drawing.Point(20, 62);
            this.Label_Longitude_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Longitude_Value.Name = "Label_Longitude_Value";
            this.Label_Longitude_Value.Size = new System.Drawing.Size(117, 11);
            this.Label_Longitude_Value.TabIndex = 21;
            this.Label_Longitude_Value.Text = "W117* 14\' 22\"";
            this.Label_Longitude_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Latitude_Value
            // 
            this.Label_Latitude_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Latitude_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Latitude_Value.Location = new System.Drawing.Point(20, 41);
            this.Label_Latitude_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Latitude_Value.Name = "Label_Latitude_Value";
            this.Label_Latitude_Value.Size = new System.Drawing.Size(117, 11);
            this.Label_Latitude_Value.TabIndex = 22;
            this.Label_Latitude_Value.Text = "N 29* 11\' 33\"";
            this.Label_Latitude_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Timer_Value
            // 
            this.Label_Timer_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer_Value.ForeColor = System.Drawing.Color.Red;
            this.Label_Timer_Value.Location = new System.Drawing.Point(229, 41);
            this.Label_Timer_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Timer_Value.Name = "Label_Timer_Value";
            this.Label_Timer_Value.Size = new System.Drawing.Size(83, 10);
            this.Label_Timer_Value.TabIndex = 23;
            this.Label_Timer_Value.Text = "000:00:00";
            this.Label_Timer_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Timer_Label
            // 
            this.Label_Timer_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Timer_Label.Location = new System.Drawing.Point(276, 50);
            this.Label_Timer_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Timer_Label.Name = "Label_Timer_Label";
            this.Label_Timer_Label.Size = new System.Drawing.Size(36, 10);
            this.Label_Timer_Label.TabIndex = 24;
            this.Label_Timer_Label.Text = "TIMER";
            this.Label_Timer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "↑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 9);
            this.label2.TabIndex = 26;
            this.label2.Text = "°";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 9);
            this.label3.TabIndex = 27;
            this.label3.Text = "°";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aifrus.SimGPS2.Properties.Resources.FormMain_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(360, 120);
            this.Controls.Add(this.Label_Latitude_Label);
            this.Controls.Add(this.Label_Speed_Label);
            this.Controls.Add(this.Label_Mag_Label);
            this.Controls.Add(this.Label_True_Label);
            this.Controls.Add(this.Label_Altitude_Label);
            this.Controls.Add(this.Label_Longitude_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Timer_Value);
            this.Controls.Add(this.Label_Timer_Label);
            this.Controls.Add(this.Label_Latitude_Value);
            this.Controls.Add(this.Label_Longitude_Value);
            this.Controls.Add(this.Label_Altitude_Value);
            this.Controls.Add(this.Label_Mag_Value);
            this.Controls.Add(this.Label_True_Value);
            this.Controls.Add(this.Label_Speed_Value);
            this.Controls.Add(this.Label_Status_Value);
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
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimGPS²";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.MenuContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Label_Latitude_Label;
        private System.Windows.Forms.Label Label_Longitude_Label;
        private System.Windows.Forms.Label Label_Altitude_Label;
        private System.Windows.Forms.Label Label_Status_Value;
        private System.Windows.Forms.Label Label_True_Label;
        private System.Windows.Forms.Label Label_Mag_Label;
        private System.Windows.Forms.Label Label_Speed_Label;
        private System.Windows.Forms.Label Label_Speed_Value;
        private System.Windows.Forms.Label Label_True_Value;
        private System.Windows.Forms.Label Label_Mag_Value;
        private System.Windows.Forms.Label Label_Altitude_Value;
        private System.Windows.Forms.Label Label_Longitude_Value;
        private System.Windows.Forms.Label Label_Latitude_Value;
        private System.Windows.Forms.Label Label_Timer_Value;
        private System.Windows.Forms.Label Label_Timer_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

