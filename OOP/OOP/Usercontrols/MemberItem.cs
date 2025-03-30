using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;
using OOP;

namespace OOP.Usercontrols
{
    public partial class MemberItem : UserControl
    {
        public string member;

        public MemberItem(string member, bool isAdmin)
        {
            InitializeComponent();
            this.member = member;
            if (isAdmin)
            UpdateUIForOwner();
            else
                UpdateUIForMember();
        }

        private void UpdateUIForMember()
        {
            lblMemberName.Text = member;
            memberTitle.Text = "Member";
        }

        private void UpdateUIForOwner()
        {
            lblMemberName.Text = member;
            memberTitle.Text = "Project Owner";
        }




        private void MemberItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

