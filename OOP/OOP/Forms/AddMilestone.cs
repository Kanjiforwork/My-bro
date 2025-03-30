using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using OOP.Models;
using OOP.Services;
namespace OOP.Forms
{
    public partial class AddMilestone : Form
    {
        public Milestone milestone {  get; set; }
        public List<Milestone> milestones = new List<Milestone>();
        public AddMilestone()
        {
            InitializeComponent();
            UpdateComboBox();
            this.btnMilestoneCancel.ForeColor = Color.Black;
            this.btnMilestoneConfirm.ForeColor = Color.Black;

        }

        public AddMilestone(List<Milestone> list)
        {
            this.milestones = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMilestone_Load(object sender, EventArgs e)
        {

        }

        private void btnMilestoneConfirm_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            string tasknewID = (rnd.Next(1000, 9999)).ToString();
            List<string> ManageId = new List<string>();
            foreach (Milestone task in milestones)
            {
                ManageId.Add(task.TaskID);
            }

            while (ManageId.Contains(tasknewID))
            {
                tasknewID = (rnd.Next(1000, 9999)).ToString();
            }

            string taskName = txtbMilestoneName.Text;
            DateTime deadline = dtpMilestonedate.Value;
            string projectName = cbbSelectProject.Text;
            milestone = new Milestone(tasknewID, taskName, "UnFinished", deadline, null, projectName, 0);
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
        private void btnMilestoneCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtbMilestoneName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbMilestoneName.Text))
            {
                e.Cancel = true; // Chặn chuyển focus nếu input trống
                errMilestoneName.SetError(txtbMilestoneName, "Please enter task name!");
            }
            else
            {
                e.Cancel = false; // Cho phép focus rời khỏi control
                errMilestoneName.SetError(txtbMilestoneName, null);
            }
        }
    }
}