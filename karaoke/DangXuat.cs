using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karaoke
{
    public partial class DangXuat : Form
    {
        private bool isManager = false;
        private string username = "";
        public DangXuat(bool isManger, string username)
        {
            InitializeComponent();
            this.isManager = isManager;
            this.username = username;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu(isManager, username);
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void passWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                logIn.PerformClick();
        }
    }
}
