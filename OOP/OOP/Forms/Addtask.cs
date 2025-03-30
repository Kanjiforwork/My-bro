using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using OOP.Services;
using Task = OOP.Models.Task;

namespace OOP
{
    public partial class Addtask : Form
    {
        public Task NewTask { get; set; }
        List<Project> projects;
        List<AbaseTask> tasks;
        List<User> users;


        public Addtask(List<Project> projects, List<AbaseTask> tasks, List<User> users)
        {
            InitializeComponent();
            this.projects = projects;
            this.tasks = tasks;
            this.users = users;
            UpdateComboBox();
         
        }

        private void Addtask_Load(object sender, EventArgs e)
        {

            foreach (Project p in this.projects)
            {
                cbbSelectProject.Items.Add(p.ProjectName);
            }
            foreach (User u in users)
            {
                cbbAssignedUser.Items.Add(u.Username);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            string tasknewID = (rnd.Next(1000, 9999)).ToString();
            List<string> ManageId = new List<string>();
            foreach (AbaseTask task in tasks)
            {
                ManageId.Add(task.TaskID);
            }

            while (ManageId.Contains(tasknewID))
            {
                tasknewID = (rnd.Next(1000, 9999)).ToString();
            }

            string taskName = txtbInputNameTask.Text;
            DateTime deadline = dtpNewTask.Value;
            string projectName = cbbSelectProject.Text;
            string receiver = cbbAssignedUser.Text;
            List<User> users = UserService.LoadUsers();
            int receiverID = 0;
            Project selectedProject = projectManager.FindProject(projectName);

            if (selectedProject == null)
            {
                MessageBox.Show("Project not found.");
                return;
            }

            // ✅ If "Myself" is selected, use the logged-in user's ID directly
            if (receiver.Trim() == "Myself")
            {
                receiverID = User.LoggedInUser.ID;
            }
            else
            {
                if (selectedProject == null)
                {
                    MessageBox.Show("No project selected.");
                    return;
                }

                User matchedUser = null;

                // Xử lý receiver: Loại bỏ phần "(member)" nếu có
                string cleanReceiver = receiver.Split('(')[0].Trim();

                foreach (User user in users)
                {
                    string cleanUsername = user.Username.Trim(); // Đảm bảo không dư khoảng trắng

                    if (cleanUsername == cleanReceiver) // So sánh username đã làm sạch
                    {
                        foreach (string member in selectedProject.members)
                        {
                            string cleanMember = member.Split('(')[0].Trim(); // Xóa "(member)"

                            if (cleanMember == cleanUsername)
                            {
                                matchedUser = user;
                                receiverID = user.ID;
                                break;
                            }
                        }
                    }

                    if (matchedUser != null) break;
                }

                if (matchedUser == null)
                {
                    MessageBox.Show($"_{receiver}_ is NOT a member of this project.");
                }
            }



            NewTask = new Task(tasknewID, taskName, "Unfinish", deadline, projectName, receiverID);
            DialogResult = DialogResult.OK;
            Close();
        }



        private ProjectManager projectManager = new ProjectManager();
        private void UpdateComboBox()
        {
            cbbSelectProject.Items.Clear();

            if (User.LoggedInUser == null) return; // Kiểm tra user đăng nhập

            foreach (Project project in projectManager.Projects)
            {
                if (project == null || project.members == null) continue; // Kiểm tra null tránh lỗi

                Console.WriteLine($"Project: {project.ProjectID} - {project.ProjectName}, AdminID: {project.AdminID}, Members: {string.Join(", ", project.members)}");

                bool isMember = false;
                foreach (string member in project.members)
                {
                    string memberUsername = member.Split('(')[0].Trim(); // Lấy username trước dấu "(" và Trim()
                    if (memberUsername == User.LoggedInUser.Username)
                    {
                        isMember = true;
                        break;
                    }
                }

                if (project.AdminID == User.LoggedInUser.ID || isMember)
                {
                    cbbSelectProject.Items.Add($"{project.ProjectName}");
                }
            }
        }

        private void cbbSelectProject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            savedProjectName = cbbSelectProject.Text;
            UpdateMember();
        }
        string savedProjectName;
        private void UpdateMember()
        {
            cbbAssignedUser.Items.Clear();
            cbbAssignedUser.Items.Add("Myself");
            Project projectChosen = projectManager.FindProject(savedProjectName);
            foreach (string name in projectChosen.members)
            {
                cbbAssignedUser.Items.Add(name);
            }
        }

        private void cbbAssignedUser_Click(object sender, EventArgs e)
        {
          //  UpdateMember();
        }

        private void txtbInputNameTask_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbInputNameTask.Text))
            {
                e.Cancel = true; // Chặn chuyển focus nếu input trống
                errLoginTask.SetError(txtbInputNameTask, "Please enter task name!");
            }
            else
            {
                e.Cancel = false; // Cho phép focus rời khỏi control
                errLoginTask.SetError(txtbInputNameTask, null);
            }
        }

        private void btnConfirm_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}