using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Models;

namespace OOP
{
    public partial class NotiUserControl : UserControl
    {
        public NotiUserControl()
        {
            InitializeComponent();
        }
        public void SetNotificationData(Notification notification)
        {
            if (notification == null) return;
            Avatar.Image = Properties.Resources.defaultProjectPic; // Dùng avatar mặc định
            Title.Text = string.IsNullOrEmpty(notification.TieuDe) ? "Không xác định" : notification.TieuDe;
            SenderName.Text = string.IsNullOrEmpty(notification.NguoiDung) ? "Không xác định" : notification.NguoiDung;
            SendDate.Text = notification.ThoiGian.ToString("dd/MM/yyyy HH:mm");
            Content.Text = string.IsNullOrEmpty(notification.NoiDung) ? "Không có nội dung" : notification.NoiDung;
        }
        private void Avatar_Click(object sender, EventArgs e)
        {

        }

        private void Content_Click(object sender, EventArgs e)
        {

        }
    }
}