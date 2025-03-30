using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using OOP.Models;
using OOP.Services;

namespace OOP
{
    public partial class Inbox : BaseForm, IObserver
    {
        private List<Notification> notifications = new List<Notification>();
        // Delegate để thông báo khi có thông báo mới
        public delegate void NotificationAddedHandler(Notification notification);
        public Inbox()
        {
            InitializeComponent();
            DisplayNotifications();
            Debug.WriteLine($"Inbox Size: {this.Size}");
            Debug.WriteLine($"Inbox ClientSize: {this.ClientSize}");
            NotificationManager.Instance.Subscribe(this); // Đăng ký nhận thông báo
            NotificationManager.Instance.LoadNotifications(); // Load thông báo từ file JSON
            notifications = NotificationManager.Instance.GetNotifications(User.GetLoggedInUserName()); // Lấy thông báo của người dùng hiện tại
        }
        private void DisplayNotifications()
        {
            Console.WriteLine($"[DEBUG] Số lượng thông báo trước khi hiển thị: {notifications.Count}");

            flowLayoutPanel1.Controls.Clear(); // Xóa thông báo cũ trên giao diện

            notifications = NotificationManager.Instance.GetNotifications(User.GetLoggedInUserName()); // Lấy thông báo mới
            Debug.WriteLine($"📢 Tổng số thông báo: {notifications.Count}");

            foreach (Notification notification in notifications)
            {
                Console.WriteLine($"[DEBUG] Hiển thị thông báo: {notification.NoiDung}");

                NotiUserControl item = new NotiUserControl();
                item.SetNotificationData(notification); // Chỉ đặt dữ liệu, không gọi LoadNotifications()

                flowLayoutPanel1.Controls.Add(item); // Thêm vào danh sách hiển thị
            }
        }
        public void Update(Notification notification)
        {
            if (notification == null) return;
            DisplayNotifications(); // Load danh sách từ JSON thay vì tự thêm
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
    }
}