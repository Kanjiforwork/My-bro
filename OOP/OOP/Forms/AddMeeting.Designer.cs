namespace OOP.Forms
{
    partial class AddMeeting
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
            this.lblMeetingName = new System.Windows.Forms.Label();
            this.txtbMeetingName = new System.Windows.Forms.TextBox();
            this.lblMeetingTime = new System.Windows.Forms.Label();
            this.lblMeetingLocation = new System.Windows.Forms.Label();
            this.txtbMeetingLocation = new System.Windows.Forms.TextBox();
            this.btnMeetingConfirm = new System.Windows.Forms.Button();
            this.btnMeetingCancel = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.dtpMeetingTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.TextBox();
            this.cbbSelectProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errMeetingName = new System.Windows.Forms.ErrorProvider(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMeetingName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingName.Location = new System.Drawing.Point(84, 109);
            this.lblMeetingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(150, 35);
            this.lblMeetingName.TabIndex = 0;
            this.lblMeetingName.Text = "Nhập tên cuộc hẹn";
            // 
            // txtbMeetingName
            // 
            this.txtbMeetingName.Location = new System.Drawing.Point(286, 109);
            this.txtbMeetingName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbMeetingName.Name = "txtbMeetingName";
            this.txtbMeetingName.Size = new System.Drawing.Size(306, 26);
            this.txtbMeetingName.TabIndex = 1;
            this.txtbMeetingName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbMeetingName_Validating);
            // 
            // lblMeetingTime
            // 
            this.lblMeetingTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingTime.Location = new System.Drawing.Point(84, 196);
            this.lblMeetingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingTime.Name = "lblMeetingTime";
            this.lblMeetingTime.Size = new System.Drawing.Size(150, 35);
            this.lblMeetingTime.TabIndex = 2;
            this.lblMeetingTime.Text = "Nhập thời gian";
            // 
            // lblMeetingLocation
            // 
            this.lblMeetingLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingLocation.Location = new System.Drawing.Point(84, 328);
            this.lblMeetingLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingLocation.Name = "lblMeetingLocation";
            this.lblMeetingLocation.Size = new System.Drawing.Size(150, 35);
            this.lblMeetingLocation.TabIndex = 4;
            this.lblMeetingLocation.Text = "Nhập địa điểm";
            // 
            // txtbMeetingLocation
            // 
            this.txtbMeetingLocation.Location = new System.Drawing.Point(286, 328);
            this.txtbMeetingLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbMeetingLocation.Name = "txtbMeetingLocation";
            this.txtbMeetingLocation.Size = new System.Drawing.Size(306, 26);
            this.txtbMeetingLocation.TabIndex = 5;
            // 
            // btnMeetingConfirm
            // 
            this.btnMeetingConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMeetingConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeetingConfirm.Location = new System.Drawing.Point(112, 480);
            this.btnMeetingConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMeetingConfirm.Name = "btnMeetingConfirm";
            this.btnMeetingConfirm.Size = new System.Drawing.Size(168, 35);
            this.btnMeetingConfirm.TabIndex = 8;
            this.btnMeetingConfirm.Text = "OK";
            this.btnMeetingConfirm.UseVisualStyleBackColor = true;
            this.btnMeetingConfirm.Click += new System.EventHandler(this.btnMeetingConfirm_Click);
            // 
            // btnMeetingCancel
            // 
            this.btnMeetingCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMeetingCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeetingCancel.Location = new System.Drawing.Point(372, 480);
            this.btnMeetingCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMeetingCancel.Name = "btnMeetingCancel";
            this.btnMeetingCancel.Size = new System.Drawing.Size(168, 35);
            this.btnMeetingCancel.TabIndex = 9;
            this.btnMeetingCancel.Text = "Cancel";
            this.btnMeetingCancel.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.WelcomeName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(657, 73);
            this.TopPanel.TabIndex = 16;
            // 
            // WelcomeName
            // 
            this.WelcomeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeName.Location = new System.Drawing.Point(132, 8);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(385, 51);
            this.WelcomeName.TabIndex = 19;
            this.WelcomeName.Text = "Add meeting";
            this.WelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpMeetingTime
            // 
            this.dtpMeetingTime.Location = new System.Drawing.Point(286, 195);
            this.dtpMeetingTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpMeetingTime.Name = "dtpMeetingTime";
            this.dtpMeetingTime.Size = new System.Drawing.Size(306, 26);
            this.dtpMeetingTime.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn giờ";
            // 
            // lblHour
            // 
            this.lblHour.Location = new System.Drawing.Point(285, 262);
            this.lblHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(306, 26);
            this.lblHour.TabIndex = 19;
            // 
            // cbbSelectProject
            // 
            this.cbbSelectProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectProject.FormattingEnabled = true;
            this.cbbSelectProject.Location = new System.Drawing.Point(286, 401);
            this.cbbSelectProject.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbbSelectProject.Name = "cbbSelectProject";
            this.cbbSelectProject.Size = new System.Drawing.Size(306, 28);
            this.cbbSelectProject.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "Project";
            // 
            // errMeetingName
            // 
            this.errMeetingName.ContainerControl = this;
            // 
            // AddMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(657, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSelectProject);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMeetingTime);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.btnMeetingCancel);
            this.Controls.Add(this.btnMeetingConfirm);
            this.Controls.Add(this.txtbMeetingLocation);
            this.Controls.Add(this.lblMeetingLocation);
            this.Controls.Add(this.lblMeetingTime);
            this.Controls.Add(this.txtbMeetingName);
            this.Controls.Add(this.lblMeetingName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMeeting";
            this.Text = "AddMeeting";
            this.Load += new System.EventHandler(this.AddMeeting_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMeetingName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeetingName;
        private System.Windows.Forms.TextBox txtbMeetingName;
        private System.Windows.Forms.Label lblMeetingTime;
        private System.Windows.Forms.Label lblMeetingLocation;
        private System.Windows.Forms.TextBox txtbMeetingLocation;
        private System.Windows.Forms.Button btnMeetingConfirm;
        private System.Windows.Forms.Button btnMeetingCancel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WelcomeName;
        private System.Windows.Forms.DateTimePicker dtpMeetingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblHour;
        private System.Windows.Forms.ComboBox cbbSelectProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errMeetingName;
    }
}