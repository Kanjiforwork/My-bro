using OOP.Models;
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
    public partial class HomeProjectUserControl : UserControl
    {
        private Project project;
        public HomeProjectUserControl(Project project)
        {
            InitializeComponent(); 
            this.project = project;
            UpdateUI();
        }

        public Panel ProjectPanel // Thuộc tính công khai để truy cập Panel
        {
            get { return panel12; } // panelContainer là tên Panel bên trong TaskControl
        }
        private void UpdateUI()
        {
            projectName.Text = project.ProjectName;
            projectPic.Image = Properties.Resources.defaultProjectPic;
        }




        
    }
}

