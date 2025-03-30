using Microsoft.VisualBasic.ApplicationServices;
using OOP;
using OOP.Models;
using OOP.Services;
using OOP.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using User = OOP.Models.User;

namespace OOP
{
    public partial class Home : BaseForm
    {

        TaskManager taskManager = TaskManager.GetInstance();
        public List<AbaseTask> GetUserTasks()
        {
            List<Project> userProjects = projectManager.FindProjectsByMember(User.LoggedInUser);
            List<AbaseTask> userTasks = new List<AbaseTask>();

            if (userProjects.Count == 0)
            {
                Console.WriteLine("User không thuộc bất kỳ project nào.");
                return userTasks; // Trả về danh sách rỗng nếu user không có project
            }

            foreach (Project project in userProjects)
            {
                List<AbaseTask> projectTasks = taskManager.GetTasksByProject(project.ProjectName);

                foreach (AbaseTask task in projectTasks)
                {
                    if (task.AssignedTo > 0 && task.AssignedTo == User.LoggedInUser.ID)
                    {
                        userTasks.Add(task);
                    }
                    else if (task.AssignedTo == 0) // Meeting, Milestone (không có assigned)
                    {
                        userTasks.Add(task);
                    }
                }
            }

            return userTasks;
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(Object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 72)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private Timer timer;
        private void Home_Load(object sender, EventArgs e)
        {
            // Cập nhật thời gian ban đầu và người dùng
            UpdateDateTime();

            // Tạo và cấu hình Timer
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Phương thức xử lý sự kiện Timer.Tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
        private void UpdateDateTime()
        {
            timeDetail.Text = DateTime.Now.ToString("dddd, 'ngày' dd 'tháng' M");
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void LoadTasks()
        {

            // Xóa các control cũ trong panel trước khi thêm mới
            taskContainer.Controls.Clear();
            

            foreach (AbaseTask task in GetUserTasks())
            {
                HomeTaskUserControl taskItem = new HomeTaskUserControl(task);
                taskItem.Dock = DockStyle.Top; // Stack tasks from top to bottom
                taskContainer.Controls.Add(taskItem);
                ApplyMouseEvents(taskItem.TaskPanel);
            }
        }
        private ProjectManager projectManager = new ProjectManager();
        private void Loadprojects()
        {
          
            projectContainer.Controls.Clear();
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
                    HomeProjectUserControl projectItem = new HomeProjectUserControl(project);
                    projectItem.Dock = DockStyle.Top; // Stack Project from top to bottom
                    projectContainer.Controls.Add(projectItem);
                    ApplyMouseEvents(projectItem.ProjectPanel);
                }
            }
        }
      


        public Home()
{
            InitializeComponent();
            //Mouse Hover
            ApplyMouseEvents(TopPanel);
            ApplyMouseEvents(projectPanel);
            ApplyMouseEvents(taskPanel);
            //Task
            LoadTasks();
            //Project
            Loadprojects();

            if (User.LoggedInUser != null)
            { 
                WelcomeName.Text = $"Hey {User.LoggedInUser.Username}, sẵn sàng làm việc chưa? 🚀";
                if (User.LoggedInUser.Avatar != null && User.LoggedInUser.Avatar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(User.LoggedInUser.Avatar))
                    {
                        try
                        {
                            avatar.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi hiển thị ảnh đại diện: {ex.Message}");
                           avatar.Image = Properties.Resources.DefaultAvatar; // Ảnh mặc định nếu lỗi
                        }
                    }
                }
                else
                {
                    avatar.Image = Properties.Resources.DefaultAvatar; // Ảnh mặc định nếu không có ảnh
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox();
            inbox.Show();
            this.Hide();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            projects.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication(); // Gọi hàm chung để thoát
        }
    }
}
