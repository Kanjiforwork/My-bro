using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OOP
{ 
    public class PlaceholderTextBox : TextBox
    {
        private string placeholderText = "Enter text...";
        private bool isPlaceholder = true;

        [Category("Custom"), Description("Sets the placeholder text.")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; SetPlaceholder(); }
        }

        public PlaceholderTextBox()
        {
            this.ForeColor = Color.Gray;
            this.Text = placeholderText;
            this.Enter += RemovePlaceholder;
            this.Leave += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
                isPlaceholder = false;
            }
        }

        private void SetPlaceholder(object sender = null, EventArgs e = null)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                isPlaceholder = true;
                this.Text = placeholderText;
                this.ForeColor = Color.Gray;
            }
        }
    }

}
