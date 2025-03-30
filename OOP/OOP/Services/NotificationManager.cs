using OOP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

[Serializable]
public class NotificationManager
{
    private Dictionary<string, List<Notification>> notificationsByUser = new Dictionary<string, List<Notification>>();
    private Dictionary<string, List<NotiUserControl>> displayedNotiControls = new Dictionary<string, List<NotiUserControl>>();
    private readonly string filePath = "notifications.json";
    private static NotificationManager instance;
    private List<IObserver> observers = new List<IObserver>();
    private static List<Notification> storedNotifications = new List<Notification>();

    private NotificationManager()
    {
        LoadNotifications();
    }

    public static NotificationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new NotificationManager();
            }
            return instance;
        }
    }
    public void LoadNotifications()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("⚠ File JSON không tồn tại. Khởi tạo danh sách rỗng.");
            notificationsByUser = new Dictionary<string, List<Notification>>();
            return;
        }

        string json = File.ReadAllText(filePath);

        if (string.IsNullOrWhiteSpace(json))
        {
            Console.WriteLine("⚠ File JSON trống. Khởi tạo danh sách rỗng.");
            notificationsByUser = new Dictionary<string, List<Notification>>();
            return;
        }

        try
        {
            notificationsByUser = JsonSerializer.Deserialize<Dictionary<string, List<Notification>>>(json)
                ?? new Dictionary<string, List<Notification>>();
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"❌ Lỗi đọc JSON: {ex.Message}. Khởi tạo danh sách rỗng.");
            notificationsByUser = new Dictionary<string, List<Notification>>();
        }
    }

    public void SaveNotifications()
    {
        try
        {
            string json = JsonSerializer.Serialize(notificationsByUser, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi lưu thông báo: {ex.Message}");
        }
    }

    public void AddNotification(string userId, Notification notification)
    {
        if (!notificationsByUser.ContainsKey(userId))
        {
            notificationsByUser[userId] = new List<Notification>();
        }

        notificationsByUser[userId].Add(notification);

        // **Lưu vào file JSON ngay sau khi thêm thông báo**
        SaveNotifications();
        Console.WriteLine($"Đã thêm thông báo: {notification.NoiDung}");
    }

    public List<Notification> GetNotifications(string userId)
    {
        return notificationsByUser.ContainsKey(userId) ? notificationsByUser[userId] : new List<Notification>();
    }

    // Lưu danh sách NotiUserControl đã hiển thị
    public void SaveDisplayedNotifications(string userId, List<NotiUserControl> controls)
    {
        if (!displayedNotiControls.ContainsKey(userId))
        {
            displayedNotiControls[userId] = new List<NotiUserControl>();
        }
        displayedNotiControls[userId] = controls;
    }

    public List<NotiUserControl> GetDisplayedNotifications(string userId)
    {
        return displayedNotiControls.ContainsKey(userId) ? displayedNotiControls[userId] : new List<NotiUserControl>();
    }

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
        foreach (var notification in storedNotifications)
        {
            observer.Update(notification);
        }
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(Notification notification)
    {
        storedNotifications.Add(notification);
        foreach (var observer in observers)
        {
            observer.Update(notification);
        }
    }

    public void SendAccountNotification(string username)
    {
        Notification notification = new Notification("THÔNG BÁO TÀI KHOẢN", "Hệ thống", DateTime.Now, $"Tài khoản '{username}' đã đăng ký thành công!");
        Notify(notification);
        AddNotification(username, notification);
    }

    public void SendProjectNotification(string username, string projectName)
    {
        Notification notification = new Notification("THÔNG BÁO DỰ ÁN", "Hệ thống", DateTime.Now, $"Dự án '{projectName}' đã được tạo!");
        Notify(notification);
        AddNotification(username, notification);
    }

    public void SendTaskUpdateNotification(string username, string taskName, string status)
    {
        if (status == "Finished")
        {
            Notification notification = new Notification("CẬP NHẬT TRẠNG THÁI", "Hệ thống", DateTime.Now, $"'{taskName}' của bạn đã hoàn thành!");
            Notify(notification);
            AddNotification(username, notification);
        }
    }
}