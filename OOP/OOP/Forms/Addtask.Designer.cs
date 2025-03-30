namespace OOP
{
    partial class Addtask
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
            this.lbInputName = new System.Windows.Forms.Label();
            this.txtbInputNameTask = new System.Windows.Forms.TextBox();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.dtpNewTask = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddinProject = new System.Windows.Forms.Label();
            this.cbbSelectProject = new System.Windows.Forms.ComboBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.cbbAssignedUser = new System.Windows.Forms.ComboBox();
            this.lblAssignUser = new System.Windows.Forms.Label();
            this.errLoginTask = new System.Windows.Forms.ErrorProvider(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLoginTask)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInputName
            // 
            this.lbInputName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInputName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInputName.Location = new System.Drawing.Point(63, 79);
            this.lbInputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInputName.Name = "lbInputName";
            this.lbInputName.Size = new System.Drawing.Size(192, 31);
            this.lbInputName.TabIndex = 0;
            this.lbInputName.Text = "Nhập tên nhiệm vụ";
            this.lbInputName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbInputNameTask
            // 
            this.txtbInputNameTask.Location = new System.Drawing.Point(298, 79);
            this.txtbInputNameTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbInputNameTask.Name = "txtbInputNameTask";
            this.txtbInputNameTask.Size = new System.Drawing.Size(433, 26);
            this.txtbInputNameTask.TabIndex = 1;
            this.txtbInputNameTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbInputNameTask.Validating += new System.ComponentModel.CancelEventHandler(this.txtbInputNameTask_Validating);
            // 
            // lbDeadline
            // 
            this.lbDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDeadline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeadline.Location = new System.Drawing.Point(63, 152);
            this.lbDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(192, 31);
            this.lbDeadline.TabIndex = 6;
            this.lbDeadline.Text = "Deadline";
            this.lbDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpNewTask
            // 
            this.dtpNewTask.Location = new System.Drawing.Point(298, 152);
            this.dtpNewTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNewTask.Name = "dtpNewTask";
            this.dtpNewTask.Size = new System.Drawing.Size(433, 26);
            this.dtpNewTask.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfirm.Location = new System.Drawing.Point(160, 367);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 59);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.btnConfirm_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(527, 367);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 59);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddinProject
            // 
            this.btnAddinProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddinProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddinProject.Location = new System.Drawing.Point(63, 220);
            this.btnAddinProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAddinProject.Name = "btnAddinProject";
            this.btnAddinProject.Size = new System.Drawing.Size(192, 31);
            this.btnAddinProject.TabIndex = 10;
            this.btnAddinProject.Text = "Project";
            this.btnAddinProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbSelectProject
            // 
            this.cbbSelectProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectProject.FormattingEnabled = true;
            this.cbbSelectProject.Location = new System.Drawing.Point(298, 220);
            this.cbbSelectProject.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbbSelectProject.Name = "cbbSelectProject";
            this.cbbSelectProject.Size = new System.Drawing.Size(433, 28);
            this.cbbSelectProject.TabIndex = 11;
            this.cbbSelectProject.SelectionChangeCommitted += new System.EventHandler(this.cbbSelectProject_SelectionChangeCommitted);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.WelcomeName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(791, 54);
            this.TopPanel.TabIndex = 12;
            // 
            // WelcomeName
            // 
            this.WelcomeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeName.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.WelcomeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.WelcomeName.Location = new System.Drawing.Point(312, -1);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(166, 51);
            this.WelcomeName.TabIndex = 1;
            this.WelcomeName.Text = "Add task";
            this.WelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbAssignedUser
            // 
            this.cbbAssignedUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAssignedUser.FormattingEnabled = true;
            this.cbbAssignedUser.Location = new System.Drawing.Point(298, 285);
            this.cbbAssignedUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbbAssignedUser.Name = "cbbAssignedUser";
            this.cbbAssignedUser.Size = new System.Drawing.Size(433, 28);
            this.cbbAssignedUser.TabIndex = 14;
            this.cbbAssignedUser.SelectedIndexChanged += new System.EventHandler(this.cbbAssignedUser_Click);
            this.cbbAssignedUser.Click += new System.EventHandler(this.cbbAssignedUser_Click);
            // 
            // lblAssignUser
            // 
            this.lblAssignUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAssignUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAssignUser.Location = new System.Drawing.Point(63, 285);
            this.lblAssignUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignUser.Name = "lblAssignUser";
            this.lblAssignUser.Size = new System.Drawing.Size(192, 31);
            this.lblAssignUser.TabIndex = 13;
            this.lblAssignUser.Text = "Assign User";
            this.lblAssignUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errLoginTask
            // 
            this.errLoginTask.ContainerControl = this;
            // 
            // Addtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(791, 477);
            this.Controls.Add(this.cbbAssignedUser);
            this.Controls.Add(this.lblAssignUser);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.cbbSelectProject);
            this.Controls.Add(this.btnAddinProject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpNewTask);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.txtbInputNameTask);
            this.Controls.Add(this.lbInputName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Addtask";
            this.Text = "Addtask";
            this.Load += new System.EventHandler(this.Addtask_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errLoginTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputName;
        private System.Windows.Forms.TextBox txtbInputNameTask;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.DateTimePicker dtpNewTask;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label btnAddinProject;
        private System.Windows.Forms.ComboBox cbbSelectProject;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label WelcomeName;
        private System.Windows.Forms.ComboBox cbbAssignedUser;
        private System.Windows.Forms.Label lblAssignUser;
        private System.Windows.Forms.ErrorProvider errLoginTask;
    }
}