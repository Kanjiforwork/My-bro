using Microsoft.Win32;
using System;
using System.Windows.Forms;
using OOP.Models;

namespace OOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Username.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Password.");
                txtPassword.Focus();
                return;
            }

            User authenticatedUser = UserService.AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                User.LoggedInUser = authenticatedUser; // Gán user vào LoggedInUser

                Home mainForm = new Home(); // Không cần truyền user nữa
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Vui lòng nhập Username.");
                    txtUsername.Focus();
                    e.Handled = true;
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Vui lòng nhập Password.");
                    txtPassword.Focus();
                    e.Handled = true;
                    return;
                }

                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Vui lòng nhập Username.");
                    txtUsername.Focus();
                    e.Handled = true;
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Vui lòng nhập Password.");
                    txtPassword.Focus();
                    e.Handled = true;
                    return;
                }

                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}