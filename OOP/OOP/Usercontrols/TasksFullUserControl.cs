using System;

using System.Windows.Forms;
using OOP.Models;
using OOP.Services;
using OOP.Usercontrols;
using Task = OOP.Models.Task;
namespace OOP.Usercontrols
{
    public partial class TasksFullUserControl : UserControl
    {
        private Task task;  // Tham chiếu đến Task gốc
        public event EventHandler<Task> OnTaskFinished;

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong TaskControl
        }
        public TasksFullUserControl(Task task)
        {
            InitializeComponent();
            this.task = task;
            UpdateUI();
        }

        private void UpdateUI()
        {
            taskContent.Text = task.TaskName;
            taskDeadline.Text = $"{task.Deadline:dd/MM/yyyy}";
            taskProject.Text = task.ProjectName;
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (task.Status == "Finished")
            {
                checkBox.Image = Properties.Resources.check;
            }
            else
            {
                checkBox.Image = Properties.Resources.checkUnfinished;
            } 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            Console.WriteLine(task.Status);
            if (task.Status == "Finished")
            {
                task.SetUpdateStatus(new NotDone());
                task.UpdateStatus();// Cập nhật trạng thái Task gốc
                UpdateButtonState();
                OnTaskFinished?.Invoke(this, task);
                TaskManager.GetInstance().UpdateTask(task);
            }
            else
            {
                task.SetUpdateStatus(new Done()); // Cập nhật trạng thái Task gốc
                task.UpdateStatus();// Cập nhật trạng thái Task gốc

                UpdateButtonState();
                OnTaskFinished?.Invoke(this, task);
                TaskManager.GetInstance().UpdateTask(task);
            }
            // Chỉ gửi thông báo nếu trạng thái thực sự thay đổi thành "Finished"
            if (task.Status == "Finished")
            {
                NotificationManager.Instance.SendTaskUpdateNotification(User.GetLoggedInUserName(), task.TaskName, task.Status);
            }
        }
    }
}
