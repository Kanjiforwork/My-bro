using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using OOP.Models;
using OOP.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using User = OOP.Models.User;

namespace OOP.Forms
{
    public partial class AddMeeting : Form
    {
        public Meeting newMeeting { get; set; }
        public List<User> users { get; set; }

        public List<Meeting> meetings { get; set; }
        public AddMeeting(List<User> users)
        {
            InitializeComponent();
            this.users = users;
            UpdateComboBox();
        }



        private void AddMeeting_Load(object sender, EventArgs e)
        {


        }


        private void btnMeetingConfirm_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string tasknewID = (rnd.Next(1000, 9999)).ToString();
            List<string> ManageId = new List<string>();
            string location = txtbMeetingLocation.Text;
            DateTime meetingTime = dtpMeetingTime.Value;
            string hour = lblHour.Text;
            List<User> members = new List<User>();

            while (ManageId.Contains(tasknewID))
            {
                tasknewID = (rnd.Next(1000, 9999)).ToString();
            }

            string taskName = txtbMeetingName.Text;
            string status = "Incompleted";
            string projectName = cbbSelectProject.Text;
            newMeeting = new Meeting(tasknewID, taskName, status, meetingTime, hour, location, members, projectName, 0);
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

        private void txtbMeetingName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbMeetingName.Text))
            {
                e.Cancel = true; // Chặn chuyển focus nếu input trống
                errMeetingName.SetError(txtbMeetingName, "Please enter task name!");
            }
            else
            {
                e.Cancel = false; // Cho phép focus rời khỏi control
                errMeetingName.SetError(txtbMeetingName, null);
            }
        }
    }
}