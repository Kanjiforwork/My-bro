using OOP.Models;
using OOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Usercontrols
{
    public partial class ProjectTaskUserControl : UserControl
    {
        private AbaseTask task;  

        public Panel TaskPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel9; } // panelContainer là tên Panel bên trong TaskControl
        }
        public ProjectTaskUserControl(AbaseTask task)
        {
            InitializeComponent();
            this.task = task;
            UpdateUI();

        }
        List<User> users = UserService.LoadUsers();
        
        private void UpdateUI()
        {
            taskContent.Text = task.TaskName;
            taskDeadline.Text = $"{task.Deadline:dd/MM/yyyy}";
            type.Text = task.GetType().Name;
            foreach(User user in users)
            {
            if (task.AssignedTo == user.ID)
                {
                    who.Text = user.Username;
                    break;
                }

            }
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
    }
}
