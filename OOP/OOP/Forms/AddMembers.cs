using OOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP
{
    public partial class Addmember : Form
    {
        public TextBox txtUsername;
        private Projects parentForm;

        public Addmember(Projects parent)
        {
            if (parent == null)
            {
                MessageBox.Show("Error: Parent form is null!");
                return;
            }
            this.parentForm = parent;
            InitializeComponent();
            this.Load += Addmember_Load;
        }
        public void Addmembercs(Projects parent)
        {
            if (parent == null)
            {
                MessageBox.Show("Error: Parent form is null!");
                return;
            }
            this.parentForm = parent;
            InitializeComponent();
        }
        public string MemberName
        {
            get { return txtUsername?.Text.Trim() ?? string.Empty; }
        }

        public RoleType SelectedRole
        {
            get { return RoleType.Member; } // sửa thành cái này là ngon
        }

        private void Addmember_Load(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ nếu có
            comboBox1.Items.Clear();

            // Chỉ thêm RoleType.Member
            comboBox1.Items.Add(RoleType.Member.ToString());

            // Chọn mặc định là "Member"
            comboBox1.SelectedItem = RoleType.Member.ToString();
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void panel1_Click(object sender, EventArgs e)
        {

        }




        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //add user nè
        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (parentForm == null)
            {
                MessageBox.Show("Error: Parent form is not set.");
                return;
            }

            string username = txtUsername.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            // Chỉ cho phép RoleType.Member
            RoleType selectedRole = RoleType.Member;

            // Gửi thông tin đến Projects
            parentForm.AddMember(username, selectedRole);

            // Gán kết quả để lấy dữ liệu từ Projects
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeName_Click(object sender, EventArgs e)
        {

        }
    }
}