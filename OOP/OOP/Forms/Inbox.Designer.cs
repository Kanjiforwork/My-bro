using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP
{
    partial class Inbox
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new ReaLTaiizor.Controls.Panel();
            this.btnHome = new ReaLTaiizor.Controls.Button();
            this.panel5 = new ReaLTaiizor.Controls.Panel();
            this.btnTask = new ReaLTaiizor.Controls.Button();
            this.panel6 = new ReaLTaiizor.Controls.Panel();
            this.btnNoti = new ReaLTaiizor.Controls.Button();
            this.menu = new ReaLTaiizor.Controls.Panel();
            this.btnProject = new ReaLTaiizor.Controls.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new ReaLTaiizor.Controls.Panel();
            this.btnExit = new ReaLTaiizor.Controls.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.nightControlBox1);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.btnHam);
            this.TopPanel.Controls.Add(this.WelcomeName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 61);
            this.TopPanel.TabIndex = 12;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(861, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(63, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "FlowHub";
            // 
            // btnHam
            // 
            this.btnHam.Image = global::OOP.Properties.Resources.image__8_;
            this.btnHam.Location = new System.Drawing.Point(21, 16);
            this.btnHam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(38, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            // 
            // WelcomeName
            // 
            this.WelcomeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeName.Location = new System.Drawing.Point(177, 8);
            this.WelcomeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(819, 42);
            this.WelcomeName.TabIndex = 1;
            this.WelcomeName.Text = "Welcome back";
            this.WelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.menu);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(179, 576);
            this.sidebar.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.EdgeColor = System.Drawing.Color.Transparent;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(2, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(14, 5, 5, 5);
            this.panel4.Size = new System.Drawing.Size(273, 57);
            this.panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel4.TabIndex = 4;
            this.panel4.Text = "Dashboard";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnHome.EnteredColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Image = global::OOP.Properties.Resources.Home__2_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.InactiveColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(14, 5);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(93, 0, 0, 0);
            this.btnHome.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnHome.PressedColor = System.Drawing.Color.Transparent;
            this.btnHome.Size = new System.Drawing.Size(254, 47);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "              Home";
            this.btnHome.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel5.Controls.Add(this.btnTask);
            this.panel5.EdgeColor = System.Drawing.Color.Transparent;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(2, 66);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(14, 5, 5, 5);
            this.panel5.Size = new System.Drawing.Size(273, 57);
            this.panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel5.TabIndex = 4;
            this.panel5.Text = "Dashboard";
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.Transparent;
            this.btnTask.BorderColor = System.Drawing.Color.Transparent;
            this.btnTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTask.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnTask.EnteredColor = System.Drawing.Color.Transparent;
            this.btnTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTask.Image = global::OOP.Properties.Resources.image__1___1_1;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.InactiveColor = System.Drawing.Color.Transparent;
            this.btnTask.Location = new System.Drawing.Point(14, 5);
            this.btnTask.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTask.Name = "btnTask";
            this.btnTask.Padding = new System.Windows.Forms.Padding(93, 0, 0, 0);
            this.btnTask.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnTask.PressedColor = System.Drawing.Color.Transparent;
            this.btnTask.Size = new System.Drawing.Size(254, 47);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "              Task";
            this.btnTask.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel6.Controls.Add(this.btnNoti);
            this.panel6.EdgeColor = System.Drawing.Color.Transparent;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(2, 129);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(14, 5, 5, 5);
            this.panel6.Size = new System.Drawing.Size(273, 57);
            this.panel6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel6.TabIndex = 5;
            this.panel6.Text = "Dashboard";
            // 
            // btnNoti
            // 
            this.btnNoti.BackColor = System.Drawing.Color.Transparent;
            this.btnNoti.BorderColor = System.Drawing.Color.Transparent;
            this.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoti.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnNoti.EnteredColor = System.Drawing.Color.Transparent;
            this.btnNoti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNoti.Image = global::OOP.Properties.Resources.noti;
            this.btnNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.InactiveColor = System.Drawing.Color.Transparent;
            this.btnNoti.Location = new System.Drawing.Point(14, 5);
            this.btnNoti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Padding = new System.Windows.Forms.Padding(93, 0, 0, 0);
            this.btnNoti.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnNoti.PressedColor = System.Drawing.Color.Transparent;
            this.btnNoti.Size = new System.Drawing.Size(254, 47);
            this.btnNoti.TabIndex = 2;
            this.btnNoti.Text = "              Notification";
            this.btnNoti.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnNoti.Click += new System.EventHandler(this.btnNoti_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.menu.Controls.Add(this.btnProject);
            this.menu.EdgeColor = System.Drawing.Color.Transparent;
            this.menu.ForeColor = System.Drawing.Color.Transparent;
            this.menu.Location = new System.Drawing.Point(0, 189);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(14, 5, 5, 5);
            this.menu.Size = new System.Drawing.Size(273, 57);
            this.menu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.menu.TabIndex = 3;
            this.menu.Text = "Dashboard";
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.Transparent;
            this.btnProject.BorderColor = System.Drawing.Color.Transparent;
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProject.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnProject.EnteredColor = System.Drawing.Color.Transparent;
            this.btnProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProject.Image = global::OOP.Properties.Resources.image;
            this.btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.InactiveColor = System.Drawing.Color.Transparent;
            this.btnProject.Location = new System.Drawing.Point(14, 5);
            this.btnProject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnProject.Name = "btnProject";
            this.btnProject.Padding = new System.Windows.Forms.Padding(93, 0, 0, 0);
            this.btnProject.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnProject.PressedColor = System.Drawing.Color.Transparent;
            this.btnProject.Size = new System.Drawing.Size(254, 47);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "               Project";
            this.btnProject.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 72);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(40, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 568);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.EdgeColor = System.Drawing.Color.Transparent;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(292, 54);
            this.panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel2.TabIndex = 7;
            this.panel2.Text = "Dashboard";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.EnteredColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = global::OOP.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.InactiveColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(15, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnExit.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.PressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(272, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "              Exit";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 637);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inbox";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label3;
        private PictureBox btnHam;
        private Label WelcomeName;
        private FlowLayoutPanel sidebar;
        private ReaLTaiizor.Controls.Panel panel4;
        private ReaLTaiizor.Controls.Button btnHome;
        private ReaLTaiizor.Controls.Panel panel5;
        private ReaLTaiizor.Controls.Button btnTask;
        private ReaLTaiizor.Controls.Panel panel6;
        private ReaLTaiizor.Controls.Button btnNoti;
        private ReaLTaiizor.Controls.Panel menu;
        private ReaLTaiizor.Controls.Button btnProject;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.Panel panel2;
        private ReaLTaiizor.Controls.Button btnExit;
    }
}