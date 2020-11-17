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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void idUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if (idUser.Text == "admin" && passWord.Text == "admin")
            {
                this.Hide();
                QuanLyNV f = new QuanLyNV();
                f.Text = "Quản lý nhân viên";
                f.ShowDialog();
            }
            else if (idUser.Text == "staff" && passWord.Text == "123456")
            {
                this.Hide();
                TrangChu f = new TrangChu();
                f.Text = "Trang chủ";
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong password or user");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                logIn.PerformClick();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ admin");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
