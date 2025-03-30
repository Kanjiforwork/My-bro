using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using OOP.Forms;
using OOP.Models;
using OOP.Services;
using OOP.Usercontrols;

namespace OOP
{
    public partial class Tasks : BaseForm
    {
        TaskManager taskManager = TaskManager.GetInstance();
        private ProjectManager projectManager = new ProjectManager();
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
        public Tasks()
        {
            InitializeComponent();
            LoadTasks(GetUserTasks());
            // Apply mouse events
            ApplyMouseEvents(taskContainer);
            ApplyMouseEvents(sidebar);
            ApplyMouseEvents(TopPanel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            foreach (ToolStripItem tsi in menuStrip1.Items)
            {
                if (tsi == e.ClickedItem)
                {
                    tsi.BackColor = SystemColors.ControlDark;

                }
                else
                {
                    tsi.BackColor = SystemColors.Control;
                }
            }
        }

        private void mnuList_Click(object sender, EventArgs e)
        {
            //if (!mnuList.Checked)
            //  {
            //      mnuList.Checked = true;
            //  }
            //else
            //  {
            //      mnuList.Checked = false;
            //  }
            //Console.WriteLine(mnuList.Checked);
        }
        private List<Project> projects = new List<Project>();
        private List<User> users = new List<User>();

        private void LoadTasks(List<AbaseTask> tasks)
        {
            // Xóa các control cũ trước khi thêm mới
            taskContainer.Controls.Clear();

            foreach (AbaseTask task in tasks)
            {
                if (task is Task t)
                {
                    TasksFullUserControl taskItem = new TasksFullUserControl(t);
                    taskItem.Dock = DockStyle.Top;
                    taskContainer.Controls.Add(taskItem);
                    ApplyMouseEvents(taskItem.TaskPanel);
                }
                else if (task is Meeting m)
                {
                    MeetingUserControl meetingItem = new MeetingUserControl(m);
                    meetingItem.Dock = DockStyle.Top;
                    taskContainer.Controls.Add(meetingItem);
                    ApplyMouseEvents(meetingItem.TaskPanel);
                }
                else if (task is Milestone ms)
                {
                    MilestoneUserControl milestoneItem = new MilestoneUserControl(ms);
                    milestoneItem.Dock = DockStyle.Top;
                    taskContainer.Controls.Add(milestoneItem);
                    ApplyMouseEvents(milestoneItem.TaskPanel);
                }
            }
        }



        private void btnMore_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMore, new Point(20, btnMore.Height));
        }

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            Addtask addTaskForm = new Addtask(projects, taskManager.Tasks, users);
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                taskManager.AddTask(addTaskForm.NewTask);
                LoadTasks(GetUserTasks());
            }
        }

        private void ctmCloset_Click(object sender, EventArgs e)
        {
            List<AbaseTask> taskslistother = new List<AbaseTask>();
            foreach (AbaseTask task in (GetUserTasks()))
            {
                    taskslistother.Add(task);
            }
            taskslistother.Sort();
            taskslistother.Reverse();
            LoadTasks(taskslistother);
            // RenderTasks(tasks);
        }

        private void ctmFarest_Click(object sender, EventArgs e)
        {
            List<AbaseTask> taskslistother = new List<AbaseTask>();
            foreach (AbaseTask task in (GetUserTasks()))
            {
                taskslistother.Add(task);
            }
            taskslistother.Sort();
            //RenderTasks(tasks);
            LoadTasks(taskslistother);
        }

        private void ctmFinished_Click(object sender, EventArgs e)
        {
            List<AbaseTask> taskslistother = new List<AbaseTask>();
            foreach (AbaseTask task in (GetUserTasks()))
            {
                if (task.Status == "Finished")
                {
                    taskslistother.Add(task);
                }
            }
            LoadTasks(taskslistother);
        }

        private void ctnSection_Click(object sender, EventArgs e)
        {
            List<AbaseTask> taskslistother = new List<AbaseTask>();
            foreach (AbaseTask task in (GetUserTasks()))
            {
                if (task.Status != "Finished")
                {
                    Console.WriteLine(task.TaskName);
                    taskslistother.Add(task);
                }
            }
            LoadTasks(taskslistother);

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

        private void lblAddoption_Click(object sender, EventArgs e)
        {
            Console.WriteLine(User.LoggedInUser.Username);
            ctmsAddoption.Show(btnAddTask, new Point(20, btnMore.Height));

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addtask addTaskForm = new Addtask(projects, taskManager.Tasks, users);
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                taskManager.AddTask(addTaskForm.NewTask);
                LoadTasks(GetUserTasks());
                addTaskForm.NewTask.Message();
            }

        }

        private void milestoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMilestone addMilestone = new AddMilestone();
            if (addMilestone.ShowDialog() == DialogResult.OK)
            {
                taskManager.AddTask(addMilestone.milestone); // Thêm task mới vào danh sách
                LoadTasks(GetUserTasks());
                addMilestone.milestone.Message();
            }

        }

        private void meetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMeeting addMeeting = new AddMeeting(users);
            if (addMeeting.ShowDialog() == DialogResult.OK)
            {
                taskManager.AddTask(addMeeting.newMeeting); // Thêm task mới vào danh sách
                LoadTasks(GetUserTasks());
                addMeeting.newMeeting.Message();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication(); // Gọi hàm chung để thoát
        }
    }
}