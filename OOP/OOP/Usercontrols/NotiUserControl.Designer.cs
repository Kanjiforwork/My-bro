using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP
{
    partial class NotiUserControl
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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.SenderName = new System.Windows.Forms.Label();
            this.SendDate = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.Transparent;
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Avatar.ErrorImage = null;
            this.Avatar.InitialImage = null;
            this.Avatar.Location = new System.Drawing.Point(26, 18);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(56, 57);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // SenderName
            // 
            this.SenderName.AutoSize = true;
            this.SenderName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.SenderName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SenderName.Location = new System.Drawing.Point(104, 18);
            this.SenderName.Name = "SenderName";
            this.SenderName.Size = new System.Drawing.Size(48, 20);
            this.SenderName.TabIndex = 2;
            this.SenderName.Text = "label1";
            // 
            // SendDate
            // 
            this.SendDate.AutoSize = true;
            this.SendDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.SendDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendDate.Location = new System.Drawing.Point(104, 43);
            this.SendDate.Name = "SendDate";
            this.SendDate.Size = new System.Drawing.Size(50, 20);
            this.SendDate.TabIndex = 3;
            this.SendDate.Text = "label2";
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Content.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Content.Location = new System.Drawing.Point(31, 14);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(48, 20);
            this.Content.TabIndex = 4;
            this.Content.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Content);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(43, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 61);
            this.panel1.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(201, 90);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(48, 20);
            this.Title.TabIndex = 6;
            this.Title.Text = "label1";
            // 
            // NotiUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendDate);
            this.Controls.Add(this.SenderName);
            this.Controls.Add(this.Avatar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NotiUserControl";
            this.Size = new System.Drawing.Size(567, 183);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Avatar;
        private Label SenderName;
        private Label SendDate;
        private Label Content;
        private Panel panel1;
        private Label Title;
    }
}