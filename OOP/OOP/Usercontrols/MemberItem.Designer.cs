namespace OOP.Usercontrols
{
    partial class MemberItem
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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.memberTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblMemberName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMemberName.Location = new System.Drawing.Point(-5, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(109, 37);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Bảo";
            this.lblMemberName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMemberName.Click += new System.EventHandler(this.label1_Click);
            // 
            // memberTitle
            // 
            this.memberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberTitle.Location = new System.Drawing.Point(3, 37);
            this.memberTitle.Name = "memberTitle";
            this.memberTitle.Size = new System.Drawing.Size(125, 34);
            this.memberTitle.TabIndex = 1;
            this.memberTitle.Text = "Project owner";
            this.memberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemberItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.memberTitle);
            this.Controls.Add(this.lblMemberName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberItem";
            this.Size = new System.Drawing.Size(135, 71);
            this.Load += new System.EventHandler(this.MemberItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label memberTitle;
    }
}
