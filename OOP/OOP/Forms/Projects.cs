using OOP.Models;
using OOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

using System.IO;
using System.Xml;
using OOP.Usercontrols;
using System.Reflection;
using System.Web.UI.Design;
using System.Linq;

namespace OOP
{
    public partial class Projects : BaseForm
    {
        private int selectedProjectID = -1;
        List<Models.Project> projects = new List<Models.Project>();

        public Projects()
        {
            InitializeComponent();

            LoadProjectsFromFile();
            UpdateComboBox();

        }


        private void SaveProjectsToFile()
        {
            string filePath = "projects.json";
            string json = JsonConvert.SerializeObject(projects, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void LoadProjectsFromFile()
        {
            if (File.Exists("projects.json"))
            {
                string json = File.ReadAllText("projects.json");
                projects = JsonConvert.DeserializeObject<List<Project>>(json) ?? new List<Project>();
            }
            else
            {
                projects = new List<Project>();
            }

            //LoadProjectButtons(); // Gọi hàm này để load lại UI từ JSON
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
                Button confirmation = new Button() { Text = "OK", Left = 100, Width = 100, Top = 80 };

                // Gán sự kiện Click mà không dùng lambda
                confirmation.Click += new EventHandler(Confirmation_Click);

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                // Lưu textBox vào Tag để truy xuất khi cần
                prompt.Tag = textBox;

                prompt.ShowDialog();

                return textBox.Text;
            }

            // Xử lý sự kiện Click của button
            private static void Confirmation_Click(object sender, EventArgs e)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    Form prompt = btn.FindForm();
                    if (prompt != null)
                    {
                        prompt.Close();
                    }
                }
            }

        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }
        public void AddMember(string username, RoleType role)
        {
            //listBox1.Items.Add($"{username} - {role}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            // Hiện hộp thoại yêu cầu nhập tên dự án
            string inputName = Prompt.ShowDialog("Nhập tên dự án:", "Tạo Project");

            if (string.IsNullOrWhiteSpace(inputName))
            {
                MessageBox.Show("Tên dự án không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID dự án (giả sử dựa trên số lượng dự án hiện tại)
            int projectID = projects.Count + 1;

            // Mô tả mặc định cho dự án
            string projectDescription = "What's this project about ";

            // Quyền mặc định cho người tạo là 'Admin'
            RoleType defaultRole = RoleType.Admin;

            // Sử dụng tên người dùng đăng nhập làm người tạo dự án
            string createdBy = User.GetLoggedInUserName();

            // Tạo dự án mới
            Project newProject = new Project(projectID, inputName, projectDescription, defaultRole);
            newProject.CreatedBy = createdBy; // Gán người tạo dự án

            newProject.AdminID = User.LoggedInUser.ID;
            newProject.AdminName = User.LoggedInUser.Username;

            // Thêm vào danh sách dự án
            projects.Add(newProject);

            // Lưu dự án vào file
            SaveProjectsToFile();
            // thêm vào comboBox1
            comboBox1.Items.Add($"{newProject.ProjectID} - {newProject.ProjectName}");

            // Thêm nút dự án mới vào giao diện

            //AddProjectButton(newProject); // Chỉ thêm nút mới, không load lại toàn bộ danh sách
        }








        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Projects_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một project!");
                return;
            }

            // Lấy ID của project từ ComboBox
            string selectedText = comboBox1.SelectedItem.ToString();
            string[] parts = selectedText.Split('-');
            if (parts.Length < 2 || !int.TryParse(parts[0].Trim(), out int selectedProjectID))
            {
                MessageBox.Show("Dữ liệu project không hợp lệ!");
                return;
            }

            // Tìm project dựa trên ID
            Project selectedProject = null;
            foreach (Project p in projects)
            {
                if (p.ProjectID == selectedProjectID)
                {
                    selectedProject = p;
                    break;
                }
            }

            if (selectedProject == null)
            {
                MessageBox.Show("Không tìm thấy project!");
                return;
            }

            // Mở form AddMember
            Addmember userForm = new Addmember(this);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                string newMember = userForm.MemberName;
                string role = userForm.SelectedRole.ToString();

                if (string.IsNullOrWhiteSpace(newMember) || string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("Thông tin thành viên không hợp lệ!");
                    return;
                }

                // Kiểm tra xem user có tồn tại không
                List<User> users = UserService.LoadUsers();
                bool userExists = false;
                foreach (User u in users)
                {
                    if (u.Username.Equals(newMember, StringComparison.OrdinalIgnoreCase))
                    {
                        userExists = true;
                        break;
                    }
                }

                if (!userExists)
                {
                    MessageBox.Show("Người dùng không tồn tại! Vui lòng nhập tên thành viên hợp lệ.");
                    return;
                }

                // Kiểm tra và khởi tạo danh sách nếu cần 
                if (selectedProject.members == null)
                {
                    selectedProject.members = new List<string>();
                }

                // Kiểm tra xem thành viên đã có trong danh sách chưa
                bool memberExists = false;
                foreach (string member in selectedProject.members)
                {
                    if (member.StartsWith(newMember + " ", StringComparison.OrdinalIgnoreCase))
                    {
                        memberExists = true;
                        break;
                    }
                }

                if (memberExists)
                {
                    MessageBox.Show($"Thành viên {newMember} đã có trong dự án!");
                    return;
                }

                // Nếu chưa tồn tại, thêm vào danh sách
                selectedProject += $"{newMember} ({role})";


                // Hiển thị danh sách thành viên mới
                DisplayMembers(selectedProject);
                SaveProjectsToFile();

                MessageBox.Show($"Đã thêm {newMember} vào dự án!");
            }
        }

        private ProjectManager projectManager = new ProjectManager();
      private void UpdateComboBox()
        {
            comboBox1.Items.Clear();

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
                    comboBox1.Items.Add($"{project.ProjectID} - {project.ProjectName}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedProjectID == -1)
            {
                MessageBox.Show("Vui lòng chọn một project để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa project ID {selectedProjectID}?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (projectManager == null)
                    {
                        MessageBox.Show("Hệ thống chưa khởi tạo project manager!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xóa project theo ID
                    projectManager.DeleteProject(selectedProjectID);
                    projectManager.SaveProjectsToFile();
                    LoadProjectsFromFile();
                    UpdateComboBox();
                    // Xóa khỏi comboBox1
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString().StartsWith($"{selectedProjectID} -"))
                        {
                            comboBox1.Items.RemoveAt(i);
                            break;
                        }
                    }

                    selectedProjectID = -1; // Reset ID sau khi xóa
                    MessageBox.Show("Project đã được xóa!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void projectContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (projects.Count == 0)
            {
                MessageBox.Show("Danh sách dự án trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            comboBox1.Items.Clear();

            foreach (Project project in projects)
            {
                comboBox1.Items.Add($"{project.ProjectID} - {project.ProjectName}");
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) // Kiểm tra nếu có project được chọn
            {
                string selectedProjectText = comboBox1.SelectedItem.ToString();

                if (int.TryParse(selectedProjectText.Split('-')[0].Trim(), out selectedProjectID)) // Gán ID vào biến toàn cục
                {
                    // Tìm project theo ID
                    Project selectedProject = null;
                    foreach (Project project in projects)
                    {
                        if (project.ProjectID == selectedProjectID)
                        {
                            selectedProject = project;
                            break; // Thoát vòng lặp khi tìm thấy project
                        }
                    }

                    if (selectedProject != null)
                    {
                        description.Text = selectedProject.ProjectDescription;
                        // Hiển thị mô tả của project
                        DisplayMembers(selectedProject);
                        LoadTasks(selectedProject);
                    }
                }
                else
                {
                    selectedProjectID = -1; // Nếu parse thất bại, reset ID
                }
            }
        }


        private void description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu nhấn Enter
            {
                if (comboBox1.SelectedIndex != -1) // Đảm bảo có project được chọn
                {
                    string selectedProjectText = comboBox1.SelectedItem.ToString();
                    int selectedProjectID = int.Parse(selectedProjectText.Split('-')[0].Trim());

                    // Tìm project theo ID bằng vòng lặp
                    Project selectedProject = null;
                    foreach (Project project in projects)
                    {
                        if (project.ProjectID == selectedProjectID)
                        {
                            selectedProject = project;
                            break; // Thoát vòng lặp ngay khi tìm thấy
                        }
                    }

                    if (selectedProject != null)
                    {
                        selectedProject.ProjectDescription = description.Text; // Cập nhật mô tả

                        SaveProjectsToFile(); // Lưu vào file JSON
                        MessageBox.Show("Mô tả đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void DisplayMembers(Project project)
        {
            memberPanel.Controls.Clear(); // Xóa danh sách cũ để tránh trùng lặp
            List<string> members = project.members;
            MemberItem OwnerItem = new MemberItem(project.AdminName, true);
            OwnerItem.Dock = DockStyle.Left; // Stack Project from top to bottom
            memberPanel.Controls.Add(OwnerItem);

            foreach (string member in members)
            {
                MemberItem memberItem = new MemberItem(member, false);
                memberItem.Dock = DockStyle.Left; // Stack Project from top to bottom
                memberPanel.Controls.Add(memberItem);
            }

        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void memberItem1_Load(object sender, EventArgs e)
        {

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

        private void description_Enter(object sender, EventArgs e)
        {
            description.ForeColor = Color.Gray; // Giữ màu đúng khi nhập vào
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            description.ForeColor = Color.Gray; // Cập nhật màu khi nhập
        }

        TaskManager taskManager = TaskManager.GetInstance();
        private void LoadTasks(Project project)
        {
            // Xóa các control cũ trong panel trước khi thêm mới
            taskContainer.Controls.Clear();

            foreach (AbaseTask task in taskManager.GetTasksByProject(project.ProjectName))
            {
                ProjectTaskUserControl taskItem = new ProjectTaskUserControl(task);
                taskItem.Dock = DockStyle.Top; // Stack tasks from top to bottom
                taskContainer.Controls.Add(taskItem);
                ApplyMouseEvents(taskItem.TaskPanel);
            }
        }
    }

}