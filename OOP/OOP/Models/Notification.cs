using Microsoft.VisualBasic.ApplicationServices;
using OOP;
using OOP.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public interface IObserver
{
    void Update(Notification notification);
}
[Serializable]
public class Notification
{
    private string tieuDe;
    private string nguoiDung;
    private DateTime thoiGian;
    private string noiDung;

    public string TieuDe
    {
        get { return this.tieuDe; }
        set { this.tieuDe = value; }
    }

    public string NguoiDung
    {
        get { return this.nguoiDung; }
        set { this.nguoiDung = value; }
    }

    public DateTime ThoiGian
    {
        get { return this.thoiGian; }
        set { this.thoiGian = value; }
    }

    public string NoiDung
    {
        get { return this.noiDung; }
        set { this.noiDung = value; }
    }


    public Notification(string tieuDe, string nguoiDung, DateTime thoiGian, string noiDung)
    {
        this.tieuDe = tieuDe;
        this.nguoiDung = nguoiDung;
        this.thoiGian = thoiGian;
        this.noiDung = noiDung;
    }
}