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
        
        public TrangChu()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThueTraPhong f = new QuanLyThueTraPhong();
            f.Text = "Quản lý quán thuê trả phòng";
            f.ShowDialog();
        }

        private void dangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangXuat f = new DangXuat();
            f.Text = "Đăng nhập";
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNV f = new QuanLyNV();
            f.Text = "Thông tin cá nhân";
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangThaiPhong f = new TrangThaiPhong();
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
            QuanLyKhoHang f = new QuanLyKhoHang();
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
