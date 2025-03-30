namespace OOP.Usercontrols
{
    partial class HomeTaskUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTaskUserControl));
            this.checkBox = new System.Windows.Forms.PictureBox();
            this.taskDeadline = new System.Windows.Forms.Label();
            this.taskContent = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.ErrorImage = global::OOP.Properties.Resources.check;
            this.checkBox.Image = ((System.Drawing.Image)(resources.GetObject("checkBox.Image")));
            this.checkBox.InitialImage = null;
            this.checkBox.Location = new System.Drawing.Point(7, 5);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(25, 25);
            this.checkBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkBox.TabIndex = 1;
            this.checkBox.TabStop = false;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click_1);
            // 
            // taskDeadline
            // 
            this.taskDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskDeadline.ForeColor = System.Drawing.Color.DarkGray;
            this.taskDeadline.Location = new System.Drawing.Point(276, 0);
            this.taskDeadline.Name = "taskDeadline";
            this.taskDeadline.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.taskDeadline.Size = new System.Drawing.Size(67, 35);
            this.taskDeadline.TabIndex = 2;
            this.taskDeadline.Text = "29/3";
            this.taskDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taskContent
            // 
            this.taskContent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.taskContent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taskContent.Location = new System.Drawing.Point(38, 2);
            this.taskContent.Name = "taskContent";
            this.taskContent.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.taskContent.Size = new System.Drawing.Size(243, 32);
            this.taskContent.TabIndex = 3;
            this.taskContent.Text = "Check bài nhóm";
            this.taskContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.taskContent);
            this.panel9.Controls.Add(this.taskDeadline);
            this.panel9.Controls.Add(this.checkBox);
            this.panel9.Location = new System.Drawing.Point(3, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(343, 35);
            this.panel9.TabIndex = 2;
            // 
            // HomeTaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel9);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HomeTaskUserControl";
            this.Size = new System.Drawing.Size(348, 45);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox checkBox;
        private System.Windows.Forms.Label taskDeadline;
        private System.Windows.Forms.Label taskContent;
        private System.Windows.Forms.Panel panel9;
    }
}
