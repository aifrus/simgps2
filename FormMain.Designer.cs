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
            this.IconNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Power = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Power_LED = new System.Windows.Forms.Label();
            this.Label_GPS_LED = new System.Windows.Forms.Label();
            this.Label_COM_LED = new System.Windows.Forms.Label();
            this.Label_Power_Label = new System.Windows.Forms.Label();
            this.Label_GPS_Label = new System.Windows.Forms.Label();
            this.Label_COM_Label = new System.Windows.Forms.Label();
            this.Label_Latitude_Label = new System.Windows.Forms.Label();
            this.Label_Longitude_Label = new System.Windows.Forms.Label();
            this.Label_Altitude_Label = new System.Windows.Forms.Label();
            this.Label_Rev_Label = new System.Windows.Forms.Label();
            this.Label_Mag_Label = new System.Windows.Forms.Label();
            this.Label_Speed_Label = new System.Windows.Forms.Label();
            this.Label_Speed_Value = new System.Windows.Forms.Label();
            this.Label_Rev_Value = new System.Windows.Forms.Label();
            this.Label_Mag_Value = new System.Windows.Forms.Label();
            this.Label_Altitude_Value = new System.Windows.Forms.Label();
            this.Label_Longitude_Value = new System.Windows.Forms.Label();
            this.Label_Latitude_Value = new System.Windows.Forms.Label();
            this.Label_Timer_Value = new System.Windows.Forms.Label();
            this.Label_Timer_Label = new System.Windows.Forms.Label();
            this.Label_Rev_Deg_Label = new System.Windows.Forms.Label();
            this.Label_Mag_Deg_Label = new System.Windows.Forms.Label();
            this.Button_Record = new System.Windows.Forms.Button();
            this.Button_Top = new System.Windows.Forms.Button();
            this.Button_Hamburger = new System.Windows.Forms.Button();
            this.Button_Set = new System.Windows.Forms.Button();
            this.Label_Distance_Label = new System.Windows.Forms.Label();
            this.Label_Total_Label = new System.Windows.Forms.Label();
            this.Label_Distance_Value = new System.Windows.Forms.Label();
            this.Label_Total_Value = new System.Windows.Forms.Label();
            this.Label_Compass_Value = new System.Windows.Forms.Label();
            this.MenuContextMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.Label_Power_LED.Location = new System.Drawing.Point(72, 18);
            this.Label_Power_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Power_LED.Name = "Label_Power_LED";
            this.Label_Power_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_Power_LED.TabIndex = 1;
            // 
            // Label_GPS_LED
            // 
            this.Label_GPS_LED.BackColor = System.Drawing.Color.Cyan;
            this.Label_GPS_LED.Location = new System.Drawing.Point(142, 18);
            this.Label_GPS_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_GPS_LED.Name = "Label_GPS_LED";
            this.Label_GPS_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_GPS_LED.TabIndex = 2;
            // 
            // Label_COM_LED
            // 
            this.Label_COM_LED.BackColor = System.Drawing.Color.Cyan;
            this.Label_COM_LED.Location = new System.Drawing.Point(212, 18);
            this.Label_COM_LED.Margin = new System.Windows.Forms.Padding(0);
            this.Label_COM_LED.Name = "Label_COM_LED";
            this.Label_COM_LED.Size = new System.Drawing.Size(6, 10);
            this.Label_COM_LED.TabIndex = 3;
            // 
            // Label_Power_Label
            // 
            this.Label_Power_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Power_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Power_Label.Location = new System.Drawing.Point(64, 28);
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
            this.Label_GPS_Label.Location = new System.Drawing.Point(134, 28);
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
            this.Label_COM_Label.Location = new System.Drawing.Point(204, 28);
            this.Label_COM_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_COM_Label.Name = "Label_COM_Label";
            this.Label_COM_Label.Size = new System.Drawing.Size(24, 10);
            this.Label_COM_Label.TabIndex = 7;
            this.Label_COM_Label.Text = "COM";
            this.Label_COM_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Latitude_Label
            // 
            this.Label_Latitude_Label.AutoSize = true;
            this.Label_Latitude_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Latitude_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Latitude_Label.Location = new System.Drawing.Point(23, 56);
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
            this.Label_Longitude_Label.Location = new System.Drawing.Point(22, 76);
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
            this.Label_Altitude_Label.Location = new System.Drawing.Point(22, 97);
            this.Label_Altitude_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Altitude_Label.Name = "Label_Altitude_Label";
            this.Label_Altitude_Label.Size = new System.Drawing.Size(53, 9);
            this.Label_Altitude_Label.TabIndex = 12;
            this.Label_Altitude_Label.Text = "ALTITUDE";
            this.Label_Altitude_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Rev_Label
            // 
            this.Label_Rev_Label.AutoSize = true;
            this.Label_Rev_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rev_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Rev_Label.Location = new System.Drawing.Point(168, 76);
            this.Label_Rev_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Rev_Label.Name = "Label_Rev_Label";
            this.Label_Rev_Label.Size = new System.Drawing.Size(23, 9);
            this.Label_Rev_Label.TabIndex = 14;
            this.Label_Rev_Label.Text = "REV";
            this.Label_Rev_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Mag_Label
            // 
            this.Label_Mag_Label.AutoSize = true;
            this.Label_Mag_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mag_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Mag_Label.Location = new System.Drawing.Point(168, 56);
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
            this.Label_Speed_Label.Location = new System.Drawing.Point(162, 97);
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
            this.Label_Speed_Value.Location = new System.Drawing.Point(137, 86);
            this.Label_Speed_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Speed_Value.Name = "Label_Speed_Value";
            this.Label_Speed_Value.Size = new System.Drawing.Size(83, 10);
            this.Label_Speed_Value.TabIndex = 17;
            this.Label_Speed_Value.Text = "420 KT";
            this.Label_Speed_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Rev_Value
            // 
            this.Label_Rev_Value.BackColor = System.Drawing.Color.Black;
            this.Label_Rev_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rev_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Rev_Value.Location = new System.Drawing.Point(161, 66);
            this.Label_Rev_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Rev_Value.Name = "Label_Rev_Value";
            this.Label_Rev_Value.Size = new System.Drawing.Size(36, 10);
            this.Label_Rev_Value.TabIndex = 18;
            this.Label_Rev_Value.Text = "042";
            this.Label_Rev_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Mag_Value
            // 
            this.Label_Mag_Value.BackColor = System.Drawing.Color.Black;
            this.Label_Mag_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mag_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Mag_Value.Location = new System.Drawing.Point(164, 46);
            this.Label_Mag_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Mag_Value.Name = "Label_Mag_Value";
            this.Label_Mag_Value.Size = new System.Drawing.Size(32, 10);
            this.Label_Mag_Value.TabIndex = 19;
            this.Label_Mag_Value.Text = "222";
            this.Label_Mag_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Altitude_Value
            // 
            this.Label_Altitude_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Altitude_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Altitude_Value.Location = new System.Drawing.Point(22, 86);
            this.Label_Altitude_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Altitude_Value.Name = "Label_Altitude_Value";
            this.Label_Altitude_Value.Size = new System.Drawing.Size(111, 11);
            this.Label_Altitude_Value.TabIndex = 20;
            this.Label_Altitude_Value.Text = "43,201 FT";
            this.Label_Altitude_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Longitude_Value
            // 
            this.Label_Longitude_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Longitude_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Longitude_Value.Location = new System.Drawing.Point(22, 66);
            this.Label_Longitude_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Longitude_Value.Name = "Label_Longitude_Value";
            this.Label_Longitude_Value.Size = new System.Drawing.Size(111, 10);
            this.Label_Longitude_Value.TabIndex = 21;
            this.Label_Longitude_Value.Text = "W117° 14\' 22\"";
            this.Label_Longitude_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Latitude_Value
            // 
            this.Label_Latitude_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Latitude_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Latitude_Value.Location = new System.Drawing.Point(22, 46);
            this.Label_Latitude_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Latitude_Value.Name = "Label_Latitude_Value";
            this.Label_Latitude_Value.Size = new System.Drawing.Size(111, 12);
            this.Label_Latitude_Value.TabIndex = 22;
            this.Label_Latitude_Value.Text = "N 29° 11\' 33\"";
            this.Label_Latitude_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Timer_Value
            // 
            this.Label_Timer_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer_Value.ForeColor = System.Drawing.Color.Red;
            this.Label_Timer_Value.Location = new System.Drawing.Point(226, 18);
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
            this.Label_Timer_Label.Location = new System.Drawing.Point(247, 27);
            this.Label_Timer_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Timer_Label.Name = "Label_Timer_Label";
            this.Label_Timer_Label.Size = new System.Drawing.Size(62, 10);
            this.Label_Timer_Label.TabIndex = 24;
            this.Label_Timer_Label.Text = "RECORDING";
            this.Label_Timer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Rev_Deg_Label
            // 
            this.Label_Rev_Deg_Label.AutoSize = true;
            this.Label_Rev_Deg_Label.BackColor = System.Drawing.Color.Transparent;
            this.Label_Rev_Deg_Label.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rev_Deg_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Rev_Deg_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Rev_Deg_Label.Location = new System.Drawing.Point(190, 67);
            this.Label_Rev_Deg_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Rev_Deg_Label.Name = "Label_Rev_Deg_Label";
            this.Label_Rev_Deg_Label.Size = new System.Drawing.Size(13, 12);
            this.Label_Rev_Deg_Label.TabIndex = 26;
            this.Label_Rev_Deg_Label.Text = "°";
            this.Label_Rev_Deg_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Mag_Deg_Label
            // 
            this.Label_Mag_Deg_Label.AutoSize = true;
            this.Label_Mag_Deg_Label.BackColor = System.Drawing.Color.Transparent;
            this.Label_Mag_Deg_Label.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mag_Deg_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Mag_Deg_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Mag_Deg_Label.Location = new System.Drawing.Point(190, 46);
            this.Label_Mag_Deg_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Mag_Deg_Label.Name = "Label_Mag_Deg_Label";
            this.Label_Mag_Deg_Label.Size = new System.Drawing.Size(13, 12);
            this.Label_Mag_Deg_Label.TabIndex = 27;
            this.Label_Mag_Deg_Label.Text = "°";
            this.Label_Mag_Deg_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Record
            // 
            this.Button_Record.BackColor = System.Drawing.Color.Black;
            this.Button_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Record.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Record.ForeColor = System.Drawing.Color.Red;
            this.Button_Record.Location = new System.Drawing.Point(311, 14);
            this.Button_Record.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Record.Name = "Button_Record";
            this.Button_Record.Size = new System.Drawing.Size(29, 29);
            this.Button_Record.TabIndex = 1;
            this.Button_Record.Text = "●";
            this.Button_Record.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Record.UseVisualStyleBackColor = false;
            // 
            // Button_Top
            // 
            this.Button_Top.BackColor = System.Drawing.Color.Black;
            this.Button_Top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Top.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Top.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Top.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Top.Font = new System.Drawing.Font("Lucida Console", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Top.ForeColor = System.Drawing.Color.White;
            this.Button_Top.Location = new System.Drawing.Point(112, 81);
            this.Button_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Top.Name = "Button_Top";
            this.Button_Top.Size = new System.Drawing.Size(29, 29);
            this.Button_Top.TabIndex = 3;
            this.Button_Top.Text = "TOP";
            this.Button_Top.UseVisualStyleBackColor = false;
            // 
            // Button_Hamburger
            // 
            this.Button_Hamburger.BackColor = System.Drawing.Color.Black;
            this.Button_Hamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Hamburger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Hamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Hamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Hamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Hamburger.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Hamburger.ForeColor = System.Drawing.Color.White;
            this.Button_Hamburger.Location = new System.Drawing.Point(22, 14);
            this.Button_Hamburger.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Hamburger.Name = "Button_Hamburger";
            this.Button_Hamburger.Size = new System.Drawing.Size(28, 28);
            this.Button_Hamburger.TabIndex = 0;
            this.Button_Hamburger.Text = "☰";
            this.Button_Hamburger.UseVisualStyleBackColor = false;
            // 
            // Button_Set
            // 
            this.Button_Set.BackColor = System.Drawing.Color.Black;
            this.Button_Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Set.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Set.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Set.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Set.Font = new System.Drawing.Font("Lucida Console", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Set.ForeColor = System.Drawing.Color.White;
            this.Button_Set.Location = new System.Drawing.Point(311, 47);
            this.Button_Set.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Set.Name = "Button_Set";
            this.Button_Set.Size = new System.Drawing.Size(29, 29);
            this.Button_Set.TabIndex = 2;
            this.Button_Set.Text = "SET";
            this.Button_Set.UseVisualStyleBackColor = false;
            // 
            // Label_Distance_Label
            // 
            this.Label_Distance_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Distance_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Distance_Label.Location = new System.Drawing.Point(250, 56);
            this.Label_Distance_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Distance_Label.Name = "Label_Distance_Label";
            this.Label_Distance_Label.Size = new System.Drawing.Size(59, 9);
            this.Label_Distance_Label.TabIndex = 28;
            this.Label_Distance_Label.Text = "DISTANCE";
            this.Label_Distance_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Total_Label
            // 
            this.Label_Total_Label.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Total_Label.ForeColor = System.Drawing.Color.White;
            this.Label_Total_Label.Location = new System.Drawing.Point(251, 76);
            this.Label_Total_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Total_Label.Name = "Label_Total_Label";
            this.Label_Total_Label.Size = new System.Drawing.Size(59, 9);
            this.Label_Total_Label.TabIndex = 29;
            this.Label_Total_Label.Text = "TOTAL";
            this.Label_Total_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Distance_Value
            // 
            this.Label_Distance_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Distance_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Distance_Value.Location = new System.Drawing.Point(232, 42);
            this.Label_Distance_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Distance_Value.Name = "Label_Distance_Value";
            this.Label_Distance_Value.Size = new System.Drawing.Size(77, 19);
            this.Label_Distance_Value.TabIndex = 33;
            this.Label_Distance_Value.Text = "1,512 NM";
            this.Label_Distance_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Total_Value
            // 
            this.Label_Total_Value.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Total_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Total_Value.Location = new System.Drawing.Point(230, 62);
            this.Label_Total_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Total_Value.Name = "Label_Total_Value";
            this.Label_Total_Value.Size = new System.Drawing.Size(79, 19);
            this.Label_Total_Value.TabIndex = 32;
            this.Label_Total_Value.Text = "1,732 NM";
            this.Label_Total_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Compass_Value
            // 
            this.Label_Compass_Value.BackColor = System.Drawing.Color.Black;
            this.Label_Compass_Value.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Compass_Value.ForeColor = System.Drawing.Color.Aqua;
            this.Label_Compass_Value.Location = new System.Drawing.Point(155, 14);
            this.Label_Compass_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Compass_Value.Name = "Label_Compass_Value";
            this.Label_Compass_Value.Size = new System.Drawing.Size(48, 26);
            this.Label_Compass_Value.TabIndex = 34;
            this.Label_Compass_Value.Text = "SSW";
            this.Label_Compass_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aifrus.SimGPS2.Properties.Resources.FormMain_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(360, 120);
            this.Controls.Add(this.Label_Compass_Value);
            this.Controls.Add(this.Label_Distance_Label);
            this.Controls.Add(this.Label_Total_Label);
            this.Controls.Add(this.Label_Distance_Value);
            this.Controls.Add(this.Label_Total_Value);
            this.Controls.Add(this.Button_Set);
            this.Controls.Add(this.Button_Hamburger);
            this.Controls.Add(this.Button_Top);
            this.Controls.Add(this.Button_Record);
            this.Controls.Add(this.Label_Speed_Label);
            this.Controls.Add(this.Label_Mag_Label);
            this.Controls.Add(this.Label_Rev_Label);
            this.Controls.Add(this.Label_Mag_Deg_Label);
            this.Controls.Add(this.Label_Rev_Deg_Label);
            this.Controls.Add(this.Label_Timer_Value);
            this.Controls.Add(this.Label_Timer_Label);
            this.Controls.Add(this.Label_Speed_Value);
            this.Controls.Add(this.Label_COM_Label);
            this.Controls.Add(this.Label_GPS_Label);
            this.Controls.Add(this.Label_Power_Label);
            this.Controls.Add(this.Label_COM_LED);
            this.Controls.Add(this.Label_GPS_LED);
            this.Controls.Add(this.Label_Power_LED);
            this.Controls.Add(this.Label_Mag_Value);
            this.Controls.Add(this.Label_Rev_Value);
            this.Controls.Add(this.Label_Latitude_Label);
            this.Controls.Add(this.Label_Altitude_Label);
            this.Controls.Add(this.Label_Longitude_Label);
            this.Controls.Add(this.Label_Latitude_Value);
            this.Controls.Add(this.Label_Longitude_Value);
            this.Controls.Add(this.Label_Altitude_Value);
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
        private System.Windows.Forms.NotifyIcon IconNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip MenuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Power;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.Label Label_Power_LED;
        private System.Windows.Forms.Label Label_GPS_LED;
        private System.Windows.Forms.Label Label_COM_LED;
        private System.Windows.Forms.Label Label_Power_Label;
        private System.Windows.Forms.Label Label_GPS_Label;
        private System.Windows.Forms.Label Label_COM_Label;
        private System.Windows.Forms.Label Label_Latitude_Label;
        private System.Windows.Forms.Label Label_Longitude_Label;
        private System.Windows.Forms.Label Label_Altitude_Label;
        private System.Windows.Forms.Label Label_Rev_Label;
        private System.Windows.Forms.Label Label_Mag_Label;
        private System.Windows.Forms.Label Label_Speed_Label;
        private System.Windows.Forms.Label Label_Speed_Value;
        private System.Windows.Forms.Label Label_Rev_Value;
        private System.Windows.Forms.Label Label_Mag_Value;
        private System.Windows.Forms.Label Label_Altitude_Value;
        private System.Windows.Forms.Label Label_Longitude_Value;
        private System.Windows.Forms.Label Label_Latitude_Value;
        private System.Windows.Forms.Label Label_Timer_Value;
        private System.Windows.Forms.Label Label_Timer_Label;
        private System.Windows.Forms.Label Label_Rev_Deg_Label;
        private System.Windows.Forms.Label Label_Mag_Deg_Label;
        private System.Windows.Forms.Button Button_Record;
        private System.Windows.Forms.Button Button_Top;
        private System.Windows.Forms.Button Button_Hamburger;
        private System.Windows.Forms.Button Button_Set;
        private System.Windows.Forms.Label Label_Distance_Label;
        private System.Windows.Forms.Label Label_Total_Label;
        private System.Windows.Forms.Label Label_Distance_Value;
        private System.Windows.Forms.Label Label_Total_Value;
        private System.Windows.Forms.Label Label_Compass_Value;
    }
}

