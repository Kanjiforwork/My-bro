namespace OOP.Usercontrols
{
    partial class MeetingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel9 = new System.Windows.Forms.Panel();
            this.hour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskProject = new System.Windows.Forms.Label();
            this.taskContent = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.PictureBox();
            this.taskDeadline = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.location);
            this.panel9.Controls.Add(this.hour);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.taskProject);
            this.panel9.Controls.Add(this.taskContent);
            this.panel9.Controls.Add(this.checkBox);
            this.panel9.Controls.Add(this.taskDeadline);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(908, 52);
            this.panel9.TabIndex = 3;
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hour.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.hour.Location = new System.Drawing.Point(555, 4);
            this.hour.Name = "hour";
            this.hour.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.hour.Size = new System.Drawing.Size(112, 44);
            this.hour.TabIndex = 6;
            this.hour.Text = "giờ: 7:30";
            this.hour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hour.Click += new System.EventHandler(this.hour_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meeting:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taskProject
            // 
            this.taskProject.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskProject.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.taskProject.Location = new System.Drawing.Point(808, 6);
            this.taskProject.Name = "taskProject";
            this.taskProject.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.taskProject.Size = new System.Drawing.Size(95, 44);
            this.taskProject.TabIndex = 4;
            this.taskProject.Text = "OOP";
            this.taskProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taskContent
            // 
            this.taskContent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskContent.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.taskContent.Location = new System.Drawing.Point(140, 8);
            this.taskContent.Name = "taskContent";
            this.taskContent.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.taskContent.Size = new System.Drawing.Size(286, 40);
            this.taskContent.TabIndex = 3;
            this.taskContent.Text = "Check bài nhóm";
            this.taskContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskContent.Click += new System.EventHandler(this.taskContent_Click);
            // 
            // checkBox
            // 
            this.checkBox.ErrorImage = global::OOP.Properties.Resources.check;
            this.checkBox.InitialImage = null;
            this.checkBox.Location = new System.Drawing.Point(7, 6);
            this.checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(32, 31);
            this.checkBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkBox.TabIndex = 1;
            this.checkBox.TabStop = false;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // taskDeadline
            // 
            this.taskDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskDeadline.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.taskDeadline.Location = new System.Drawing.Point(673, 7);
            this.taskDeadline.Name = "taskDeadline";
            this.taskDeadline.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.taskDeadline.Size = new System.Drawing.Size(120, 44);
            this.taskDeadline.TabIndex = 2;
            this.taskDeadline.Text = "29/03/2025";
            this.taskDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // location
            // 
            this.location.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.location.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.location.Location = new System.Drawing.Point(437, 4);
            this.location.Name = "location";
            this.location.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.location.Size = new System.Drawing.Size(112, 44);
            this.location.TabIndex = 7;
            this.location.Text = "tại UEH";
            this.location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MeetingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MeetingUserControl";
            this.Size = new System.Drawing.Size(908, 52);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label taskContent;
        private System.Windows.Forms.Label taskDeadline;
        private System.Windows.Forms.PictureBox checkBox;
        private System.Windows.Forms.Label taskProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label location;
    }
}
