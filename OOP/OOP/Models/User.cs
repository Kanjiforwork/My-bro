using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    [Serializable] // Thêm attribute Serializable để có thể serialize object
    public class User
    {
        private int iD;
        private string username;
        private RoleType role;
        private string password;
        private string email;
        private byte[] avatar;
        private static User loggedInUser;
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<User> Friends { get; set; } = new List<User>();
        public List<User> allUsers = new List<User>();

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public RoleType Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public byte[] Avatar
        {
            get { return this.avatar; }
            set { this.avatar = value; }
        }

        public static User LoggedInUser
        {
            get { return loggedInUser; }
            set { loggedInUser = value; }
        }

        public User(int id, string username, RoleType role, string password, string email)
        {
            this.iD = id;
            this.username = username;
            this.role = role;
            this.password = password;
            this.email = email;
        }
        public static void Login(string username, RoleType role)
        {
            // Tạo một đối tượng User và gán cho LoggedInUser
            loggedInUser = new User(1, username, RoleType.Member, "123", "OOP@.com"); // Ví dụ, ID = 1, bạn có thể thay bằng cách tạo ID tự động
        }

        // Phương thức để lấy thông tin người dùng đăng nhập
        public static string GetLoggedInUserName()
        {
            return loggedInUser?.username ?? "No user logged in"; // Trả về tên người dùng nếu đã đăng nhập
        }

        // Phương thức để kiểm tra xem người dùng có đăng nhập không
        public static bool IsLoggedIn()
        {
            return loggedInUser != null;
        }
        public User() { } // Constructor mặc định cho việc deserialize
    }
}