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
            this.Label_Hamburger = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Power = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Hamburger
            // 
            this.Label_Hamburger.AutoSize = true;
            this.Label_Hamburger.BackColor = System.Drawing.Color.Transparent;
            this.Label_Hamburger.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Hamburger.ForeColor = System.Drawing.Color.White;
            this.Label_Hamburger.Location = new System.Drawing.Point(19, 18);
            this.Label_Hamburger.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Hamburger.Name = "Label_Hamburger";
            this.Label_Hamburger.Size = new System.Drawing.Size(19, 16);
            this.Label_Hamburger.TabIndex = 0;
            this.Label_Hamburger.Text = "☰";
            this.Label_Hamburger.Click += new System.EventHandler(this.Label_Hamburger_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenu;
            this.NotifyIcon.Text = "SimGPS if off.";
            this.NotifyIcon.Visible = true;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Power,
            this.MenuItem_Exit});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // MenuItem_Power
            // 
            this.MenuItem_Power.Name = "MenuItem_Power";
            this.MenuItem_Power.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Power.Text = "Power On";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aifrus.SimGPS2.Properties.Resources.FormMain_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(360, 120);
            this.Controls.Add(this.Label_Hamburger);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "SimGPS²";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Hamburger;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Power;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
    }
}

