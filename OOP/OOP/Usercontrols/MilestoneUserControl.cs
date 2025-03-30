using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using OOP.Services;

namespace OOP.Usercontrols
{
    public partial class MilestoneUserControl : UserControl
    {
        private Milestone milestone;  // Tham chiếu đến Milestone gốc
        public event EventHandler<Milestone> OnTaskFinished;

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong TaskControl
        }

        public MilestoneUserControl(Milestone milestone)
        {
            InitializeComponent();
            this.milestone = milestone;
            UpdateUI();
        }

        private void UpdateUI()
        {
            taskContent.Text = milestone.TaskName;
            taskProject.Text = milestone.ProjectName;
            taskDeadline.Text = $"{milestone.Deadline:dd/MM/yyyy}";
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (milestone.Status == "Finished")
            {
                checkBox.Image = Properties.Resources.check;
            }
            else
            {
                checkBox.Image = Properties.Resources.checkUnfinished;
            }
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (milestone.Status == "Finished")
            {
                milestone.Status = "UnFinished"; // Cập nhật trạng thái Meeting gốc
            }
            else
            {
                milestone.Status = "Finished"; // Cập nhật trạng thái Meeting gốc
            }

            UpdateButtonState();
            OnTaskFinished?.Invoke(this, milestone);
            TaskManager.GetInstance().UpdateTask(milestone);

            // Chỉ gửi thông báo nếu trạng thái thực sự thay đổi thành "Finished"
            if (milestone.Status == "Finished")
            {
                NotificationManager.Instance.SendTaskUpdateNotification(User.GetLoggedInUserName(), milestone.TaskName, milestone.Status);
            }
        }
    }
}