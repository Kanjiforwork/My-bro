using System;
using System.Windows.Forms;




public class BaseForm : Form
{
    public class ExitHandler
    {
        public bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                  "Exit Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
    public delegate bool ExitEventHandler();
    public event ExitEventHandler OnExitRequested;

    private ExitHandler exitHandler = new ExitHandler();
    private bool isExiting = false;

    public BaseForm()
    {
        if (OnExitRequested == null)
        {
            OnExitRequested += exitHandler.ConfirmExit;
        }

        // Đảm bảo không đăng ký trùng sự kiện FormClosing
        this.FormClosing -= BaseForm_FormClosing;
        this.FormClosing += BaseForm_FormClosing;
    }

    private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Chỉ form đầu tiên xử lý sự kiện thoát
        if (Application.OpenForms.Count > 1)
            return;

        if (!isExiting && OnExitRequested?.Invoke() == false)
        {
            e.Cancel = true;
        }
        else
        {
            isExiting = true;
        }
    }


    protected void ExitApplication()
    {
        if (!isExiting && OnExitRequested?.Invoke() == true)
        {
            isExiting = true;
            Application.Exit();
        }
    }
    // Attach MouseMove & MouseLeave only to the **Panel itself** but still track child elements
    protected void ApplyMouseEvents(Panel panel)
    {
        panel.MouseMove += Panel_MouseMove;
        panel.MouseLeave += Panel_MouseLeave;

        foreach (Control child in panel.Controls)
        {
            child.MouseMove += Child_MouseMove;
            child.MouseLeave += Child_MouseLeave;
        }
    }

    // Xử lý MouseMove cho panel
    private void Panel_MouseMove(object sender, MouseEventArgs e)
    {
        Panel panel = sender as Panel;
        if (panel != null)
        {
            panel.BorderStyle = BorderStyle.Fixed3D;
        }
    }

    // Xử lý MouseLeave cho panel
    private void Panel_MouseLeave(object sender, EventArgs e)
    {
        Panel panel = sender as Panel;
        if (panel != null && !panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
        {
            panel.BorderStyle = BorderStyle.FixedSingle;
        }
    }

    // Xử lý MouseMove cho child, chuyển tiếp sự kiện về panel
    private void Child_MouseMove(object sender, MouseEventArgs e)
    {
        Control child = sender as Control;
        if (child != null && child.Parent is Panel panel)
        {
            Panel_MouseMove(panel, e);
        }
    }

    // Xử lý MouseLeave cho child, chuyển tiếp sự kiện về panel
    private void Child_MouseLeave(object sender, EventArgs e)
    {
        Control child = sender as Control;
        if (child != null && child.Parent is Panel panel)
        {
            Panel_MouseLeave(panel, e);
        }
    }

}
