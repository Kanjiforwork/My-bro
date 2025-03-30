using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using OOP.Services;

namespace OOP.Usercontrols
{
    public partial class MeetingUserControl : UserControl
    {
        private Meeting meeting;  // Tham chiếu đến Meeting gốc
        public event EventHandler<Meeting> OnMeetingFinished;

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong MeetingUserControl
        }

        public MeetingUserControl(Meeting meeting)
        {
            InitializeComponent();
            this.meeting = meeting;
            UpdateUI();
        }

        private void UpdateUI()
        {
            taskContent.Text = meeting.TaskName;
            taskProject.Text = meeting.ProjectName; // Dùng location thay vì project
            location.Text = "Tại " + meeting.Location;
            hour.Text = "Giờ: " + meeting.Hour;
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            if (meeting.Status == "Finished")
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
            if (meeting.Status == "Finished")
            {
                meeting.Status = "UnFinished"; // Cập nhật trạng thái Meeting gốc
            }
            else
            {
                meeting.Status = "Finished"; // Cập nhật trạng thái Meeting gốc
            }

            UpdateButtonState();
            OnMeetingFinished?.Invoke(this, meeting);
            TaskManager.GetInstance().UpdateTask(meeting);

            // Chỉ gửi thông báo nếu trạng thái thực sự thay đổi thành "Finished"
            if (meeting.Status == "Finished")
            {
                NotificationManager.Instance.SendTaskUpdateNotification(User.GetLoggedInUserName(), meeting.TaskName, meeting.Status);
            }
        }


        private void taskContent_Click(object sender, EventArgs e)
        {

        }

        private void hour_Click(object sender, EventArgs e)
        {

        }
    }
}