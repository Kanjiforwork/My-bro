using OOP.Services;
using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using OOP.Usercontrols;

namespace OOP.Models
{
    public enum RoleType
    {
        Admin,
        Member
    }

    public class Project
    {
        private int projectID;
        private string projectName;
        private string projectDescription;
        private int adminID;
        private string adminName;
        private string createdBy;
        private RoleType userRole;
    
        public Project() { }
        public List<string> members { get; set; } = new List<string>();
        public List<Task> tasks = new List<Task>();

        public int ProjectID
        {
            get { return this.projectID; }
            set { this.projectID = value; }
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }

        public string ProjectDescription
        {
            get { return this.projectDescription; }
            set { this.projectDescription = value; }
        }

        public int AdminID
        {
            get { return this.adminID; }
            set { this.adminID = value; }
        }

        public string AdminName
        {
            get { return this.adminName; }
            set { this.adminName = value; }
        }

        public string CreatedBy
        {
            get { return this.createdBy; }
            set { this.createdBy = value; }
        }

        public RoleType UserRole
        {
            get { return this.userRole; }
            set { this.userRole = value; }
        }

        public Project(int projectID, string projectName, string projectDescription, RoleType role)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.userRole = role;

        }
        public Project(int projectID, string projectName, string projectDescription, RoleType role, int adminID, string adminName, string createdBy)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.userRole = role;
            this.adminID = adminID;
            this.adminName = adminName;
            this.members = new List<string> { $"{createdBy} (Admin)" };
        }
        public Project(int id, string name, string description)
        {
            this.projectID = id;
            projectName = name;
            projectDescription = description;
            members = new List<string>();
        }
        public void AddTask(Task task)
        {
            if (userRole == RoleType.Admin || userRole == RoleType.Member)
            {
                tasks.Add(task);
            }
            else
            {
                throw new UnauthorizedAccessException("Only Admins and Members can add tasks.");
            }

        }
        public void AssignTask(Task task, User assignee)
        {
            if (assignee.Role != RoleType.Member)
            {
                throw new InvalidOperationException("Chỉ thành viên (Member) mới có thể được gán task!");
            }

            tasks.Add(task);

            // Gửi thông báo cho Member khi nhận task
          
        }


        public void RemoveTask(Task task)
        {
            if (userRole == RoleType.Admin)
            {
                tasks.Remove(task);
            }
            else
            {
                throw new UnauthorizedAccessException("Only Admins can remove tasks.");
            }
        }
        //operator +
        public static Project operator +(Project project, string memberInfo)
        {
            if (project != null && !string.IsNullOrWhiteSpace(memberInfo) && !project.members.Contains(memberInfo))
            {
                project.members.Add(memberInfo);
            }
            return project; // Trả về chính đối tượng Project
        }


    }
}