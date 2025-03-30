using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class AvatarForm : Form
    {
        private byte[] _avatarBytes;
        public AvatarForm()
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream())
            {
                Properties.Resources.DefaultAvatar.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] avatarBytes = ms.ToArray();
            }
        }

        private void AvatarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _avatarBytes = File.ReadAllBytes(openFileDialog.FileName);
                using (MemoryStream ms = new MemoryStream(_avatarBytes))
                {
                    pbAvatar.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public byte[] GetAvatarBytes()
        {
            return _avatarBytes;
        }
    }
}