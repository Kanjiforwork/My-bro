using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models;
using OOP;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
namespace OOP.Services
{
    internal class ProjectManager
    {
        public List<Project> Projects { get; set; }


        public ProjectManager()
        {
            Projects = new List<Project>();
            LoadProjectsFromFile();

        }
        public void SaveProjectsToFile()
        {
            string json = JsonConvert.SerializeObject(Projects, Formatting.Indented);
            File.WriteAllText("projects.json", json);
            Console.WriteLine("Danh sách project đã được lưu vào file.");
        }

        public void LoadProjectsFromFile()
        {
            if (File.Exists("projects.json"))
            {
                string json = File.ReadAllText("projects.json");
                Projects = JsonConvert.DeserializeObject<List<Project>>(json) ?? new List<Project>();
                Console.WriteLine($"Đã load {Projects.Count} project từ file.");
            }
        }
        public void AddProject(Project newProject)
        {
            foreach (Project project in Projects)
            {
                if (project.ProjectName == newProject.ProjectName)
                {
                    MessageBox.Show("Project với tên này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng lại, không thêm nữa
                }
            }

            Projects.Add(newProject);
            SaveProjectsToFile();
            MessageBox.Show($"Project '{newProject.ProjectName}' đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteProject(int projectID)
        {
            if (Projects == null || Projects.Count == 0)
            {
                throw new Exception("Danh sách project rỗng. Không thể xóa!");
            }

            Console.WriteLine($"Đang tìm project với ID: {projectID}");

            Project projectToRemove = null;
            foreach (Project project in Projects)
            {
                if (project.ProjectID == projectID)
                {
                    projectToRemove = project;
                    break;
                }
            }

            if (projectToRemove != null)
            {
                Projects.Remove(projectToRemove);
                Console.WriteLine($"Project {projectID} đã bị xóa.");
                SaveProjectsToFile();
                LoadProjectsFromFile();
            }
            else
            {
                Console.WriteLine($"Lỗi: Không tìm thấy project {projectID}.");
                throw new Exception($"Project với ID {projectID} không tồn tại.");
            }
        }
        public Project FindProject(string ProjectName)
        {
            foreach (Project project in Projects)
            {
                if (project.ProjectName == ProjectName)
                {
                    return project;
                }
            }
            return null; // Nếu không tìm thấy project, trả về null
        }
        public List<Project> FindProjectsByMember(User user)
        {
            List<Project> userProjects = new List<Project>();

            foreach (Project project in Projects)
            {
                bool isMember = false;

                // Kiểm tra nếu user là Admin
                if (project.AdminID == user.ID)
                {
                    isMember = true;
                }
                else
                {
                    // Kiểm tra nếu user có trong danh sách members
                    foreach (string member in project.members)
                    {
                        string memberName = member.Split('(')[0].Trim();
                        if (memberName == user.Username)
                        {
                            isMember = true;
                            break; // Thoát vòng lặp khi tìm thấy
                        }
                    }
                }

                // Nếu user thuộc project, thêm vào danh sách
                if (isMember)
                {
                    userProjects.Add(project);
                }
            }

            return userProjects;
        }

    }

}