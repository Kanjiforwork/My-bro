using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OOP.Models;

namespace OOP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            bool allFieldsFilled = false;

            while (!allFieldsFilled)
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                email = txtEmail.Text;
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }
                else
                {
                    allFieldsFilled = true;
                }

                if (!IsValidEmail(email)) // Kiểm tra email hợp lệ
                {
                    MessageBox.Show("Email không hợp lệ.");
                    return;
                }


                List<User> users = UserService.LoadUsers();
                bool usernameExists = false;
                bool emailExists = false; // Thêm biến kiểm tra email
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Username == username)
                    {
                        usernameExists = true;
                        break;
                    }
                    if (users[i].Email == email) // Kiểm tra email trùng lặp
                    {
                        emailExists = true;
                        break;
                    }
                }

                if (usernameExists)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                if (emailExists) // Thêm kiểm tra email
                {
                    MessageBox.Show("Email already exists.");
                    return;
                }

                int newId = users.Count > 0 ? users[users.Count - 1].ID + 1 : 1;
                User newUser = new User(newId, username, RoleType.Member, password, email);
                users.Add(newUser);
                UserService.SaveUsers(users);
                NotificationManager.Instance.SendAccountNotification(username);
                MessageBox.Show("Registration successful!");
                this.Close();

                AvatarForm avatarForm = new AvatarForm();
                if (avatarForm.ShowDialog() == DialogResult.OK)
                {
                    newUser.Avatar = avatarForm.GetAvatarBytes();

                    // Cập nhật newUser trong danh sách users
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].ID == newUser.ID)
                        {
                            users[i] = newUser;
                            break;
                        }
                    }
                }
                UserService.SaveUsers(users);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                System.Net.Mail.MailAddress addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}