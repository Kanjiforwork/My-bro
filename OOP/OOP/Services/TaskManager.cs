using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OOP.Models;

namespace OOP.Services
{
    public class TaskManager
    {
        private static TaskManager _instance;
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.json");

        public List<AbaseTask> Tasks { get; private set; }

        public static TaskManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TaskManager();
            }
            return _instance;
        }

        private TaskManager()
        {
            Tasks = new List<AbaseTask>();
            LoadTasksFromFile();
        }

        // ✅ Thêm task mới
        public void AddTask(AbaseTask task)
        {
            if (task == null) return;
            Tasks.Add(task);
            SaveTasksToFile();
        }

        // ✅ Xóa task theo ID
        public void RemoveTask(string taskID)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].TaskID == taskID)
                {
                    Tasks.RemoveAt(i);
                    SaveTasksToFile();
                    return;
                }
            }
        }

        // ✅ Tìm task theo User
        public List<AbaseTask> GetTasksByUser(User user)
        {
            List<AbaseTask> userTasks = new List<AbaseTask>();

            foreach (AbaseTask task in Tasks)
            {
                if (task.AssignedTo == user.ID)
                {
                    userTasks.Add(task);
                }
            }
            return userTasks;
        }

        // ✅ Tìm task theo Project
        public List<AbaseTask> GetTasksByProject(string projectName)
        {
            List<AbaseTask> projectTasks = new List<AbaseTask>();

            foreach (AbaseTask task in Tasks)
            {
                if (task.ProjectName == projectName)
                {
                    projectTasks.Add(task);
                }
            }
            return projectTasks;
        }

        // ✅ Lưu danh sách task vào file
        public void SaveTasksToFile()
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented
                };

                string json = JsonConvert.SerializeObject(Tasks, settings);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks: {ex.Message}");
            }
        }

        // ✅ Load task từ file nếu có
        public void LoadTasksFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    };

                    List<AbaseTask> loadedTasks = JsonConvert.DeserializeObject<List<AbaseTask>>(json, settings);
                    Tasks = loadedTasks ?? new List<AbaseTask>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks: {ex.Message}");
                Tasks = new List<AbaseTask>();
            }
        }

        public void UpdateTask(AbaseTask updatedTask)
        {
            if (updatedTask == null) return;

            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].TaskID == updatedTask.TaskID)
                {
                    Tasks[i] = updatedTask; // Cập nhật task
                    SaveTasksToFile(); // Lưu lại file
                    return;
                }
            }
        }

        // ✅ Xóa file JSON
        public void DeleteTaskFile()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Deleted tasks.json successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
