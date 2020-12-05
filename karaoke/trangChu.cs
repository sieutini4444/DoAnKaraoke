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
    public partial class TrangChu : Form
    {
        private bool isManager = false;
        private string username = "";
        public TrangChu(bool isManager, string username)
        {
            InitializeComponent();
            this.isManager = isManager;
            this.username = username;
            if (this.isManager)
            {
                staffManagementBtn.Visible = true;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThueTraPhong f = new QuanLyThueTraPhong(isManager, username);
            f.Text = "Quản lý quán thuê trả phòng";
            f.ShowDialog();
        }

        private void dangNhap_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Text = "Đăng nhập";
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(username);
            f.Text = "Thông tin cá nhân";
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangThaiPhong f = new TrangThaiPhong(isManager);
            f.Text = "Quản lý phòng";
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhoHang f = new QuanLyKhoHang(isManager, username);
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNV f = new QuanLyNV(isManager, username);
            f.Text = "Quản lý nhân viên";
            f.ShowDialog();
        }
    }
}
