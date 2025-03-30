using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using OOP.Models;
using System.IO;


namespace OOP
{

    public class UserService
    {
        private static readonly string filePath = "users.json";
        public static List<User> LoadUsers()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<User>>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading users: {ex.Message}");
                }
            }
            return new List<User>();
        }

        public static User AuthenticateUser(string username, string password)
        {
            List<User> users = LoadUsers();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return users[i];
                }
            }
            return null;
        }
        public static void SaveUsers(List<User> users)
        {
            try
            {
                string json = JsonSerializer.Serialize(users);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving users: {ex.Message}");
            }
        }
        public static void SaveCurrentUser()
        {
            try
            {
                if (User.LoggedInUser?.ID == null)
                {
                    Console.WriteLine("No user is logged in.");
                    return;
                }

                List<User> users = LoadUsers(); // Load danh sách Users cũ

                // Tìm user theo ID hoặc Username
                User existingUser = null;
                foreach (User u in users)
                {
                    if (u.ID == User.LoggedInUser.ID || u.Username == User.LoggedInUser.Username)
                    {
                        existingUser = u;
                        break; // Dừng khi tìm thấy user
                    }
                }

                if (existingUser != null)
                {
                    // Cập nhật thông tin user hiện tại
                    existingUser.Username = User.LoggedInUser.Username;
                    existingUser.Password = User.LoggedInUser.Password;
                    existingUser.Email = User.LoggedInUser.Email;
                    existingUser.Role = User.LoggedInUser.Role;
                    existingUser.Avatar = User.LoggedInUser.Avatar;
                }
                else
                {
                    // Nếu chưa có, thêm mới
                    users.Add(User.LoggedInUser);
                }

                SaveUsers(users); // Lưu danh sách sau khi cập nhật
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving current user: {ex.Message}");
            }
        }



    }
}