using System.Drawing;

namespace OOP.Forms
{
    partial class AddMilestone
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
            this.lblMilestoneName = new System.Windows.Forms.Label();
            this.txtbMilestoneName = new System.Windows.Forms.TextBox();
            this.lalMilestoneDate = new System.Windows.Forms.Label();
            this.dtpMilestonedate = new System.Windows.Forms.DateTimePicker();
            this.btnMilestoneConfirm = new ReaLTaiizor.Controls.Button();
            this.btnMilestoneCancel = new ReaLTaiizor.Controls.Button();
            this.cbbSelectProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errMilestoneName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errMilestoneName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMilestoneName
            // 
            this.lblMilestoneName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMilestoneName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMilestoneName.Location = new System.Drawing.Point(50, 65);
            this.lblMilestoneName.Name = "lblMilestoneName";
            this.lblMilestoneName.Size = new System.Drawing.Size(135, 29);
            this.lblMilestoneName.TabIndex = 0;
            this.lblMilestoneName.Text = "Nhập Milestone";
            // 
            // txtbMilestoneName
            // 
            this.txtbMilestoneName.Location = new System.Drawing.Point(204, 65);
            this.txtbMilestoneName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbMilestoneName.Name = "txtbMilestoneName";
            this.txtbMilestoneName.Size = new System.Drawing.Size(338, 26);
            this.txtbMilestoneName.TabIndex = 1;
            this.txtbMilestoneName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbMilestoneName_Validating);
            // 
            // lalMilestoneDate
            // 
            this.lalMilestoneDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lalMilestoneDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lalMilestoneDate.Location = new System.Drawing.Point(50, 134);
            this.lalMilestoneDate.Name = "lalMilestoneDate";
            this.lalMilestoneDate.Size = new System.Drawing.Size(102, 29);
            this.lalMilestoneDate.TabIndex = 2;
            this.lalMilestoneDate.Text = "Nhập ngày";
            this.lalMilestoneDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpMilestonedate
            // 
            this.dtpMilestonedate.Location = new System.Drawing.Point(204, 135);
            this.dtpMilestonedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMilestonedate.Name = "dtpMilestonedate";
            this.dtpMilestonedate.Size = new System.Drawing.Size(338, 26);
            this.dtpMilestonedate.TabIndex = 3;
            // 
            // btnMilestoneConfirm
            // 
            this.btnMilestoneConfirm.BackColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.BorderColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMilestoneConfirm.EnteredBorderColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.EnteredColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMilestoneConfirm.Image = null;
            this.btnMilestoneConfirm.ForeColor = Color.Black;
            this.btnMilestoneConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMilestoneConfirm.InactiveColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.Location = new System.Drawing.Point(107, 272);
            this.btnMilestoneConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMilestoneConfirm.Name = "btnMilestoneConfirm";
            this.btnMilestoneConfirm.PressedBorderColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.PressedColor = System.Drawing.Color.White;
            this.btnMilestoneConfirm.Size = new System.Drawing.Size(147, 38);
            this.btnMilestoneConfirm.TabIndex = 6;
            this.btnMilestoneConfirm.Text = "OK";
            this.btnMilestoneConfirm.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMilestoneConfirm.Click += new System.EventHandler(this.btnMilestoneConfirm_Click);
            // 
            // btnMilestoneCancel
            // 
            this.btnMilestoneCancel.BackColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.BorderColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.ForeColor = Color.Black;
            this.btnMilestoneCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMilestoneCancel.EnteredBorderColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.EnteredColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMilestoneCancel.Image = null;
            this.btnMilestoneCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMilestoneCancel.InactiveColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.Location = new System.Drawing.Point(370, 272);
            this.btnMilestoneCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMilestoneCancel.Name = "btnMilestoneCancel";
            this.btnMilestoneCancel.PressedBorderColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.PressedColor = System.Drawing.Color.White;
            this.btnMilestoneCancel.Size = new System.Drawing.Size(147, 38);
            this.btnMilestoneCancel.TabIndex = 7;
            this.btnMilestoneCancel.Text = "Cancel";
            this.btnMilestoneCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMilestoneCancel.Click += new System.EventHandler(this.btnMilestoneCancel_Click);
            // 
            // cbbSelectProject
            // 
            this.cbbSelectProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectProject.FormattingEnabled = true;
            this.cbbSelectProject.Location = new System.Drawing.Point(204, 210);
            this.cbbSelectProject.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbbSelectProject.Name = "cbbSelectProject";
            this.cbbSelectProject.Size = new System.Drawing.Size(338, 28);
            this.cbbSelectProject.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Project";
            // 
            // errMilestoneName
            // 
            this.errMilestoneName.ContainerControl = this;
            // 
            // AddMilestone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSelectProject);
            this.Controls.Add(this.btnMilestoneCancel);
            this.Controls.Add(this.btnMilestoneConfirm);
            this.Controls.Add(this.dtpMilestonedate);
            this.Controls.Add(this.lalMilestoneDate);
            this.Controls.Add(this.txtbMilestoneName);
            this.Controls.Add(this.lblMilestoneName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMilestone";
            this.Text = "AddMilestone";
            this.Load += new System.EventHandler(this.AddMilestone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMilestoneName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilestoneName;
        private System.Windows.Forms.TextBox txtbMilestoneName;
        private System.Windows.Forms.Label lalMilestoneDate;
        private System.Windows.Forms.DateTimePicker dtpMilestonedate;
        private ReaLTaiizor.Controls.Button btnMilestoneConfirm;
        private ReaLTaiizor.Controls.Button btnMilestoneCancel;
        private System.Windows.Forms.ComboBox cbbSelectProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errMilestoneName;
    }
}