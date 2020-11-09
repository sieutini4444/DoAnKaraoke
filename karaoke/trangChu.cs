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
    public partial class trangChu : Form
    {
        
        public trangChu()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void manageUser(object sender, EventArgs e)
        {
            ManageUser f = new ManageUser();
            f.Text = "Quản lý người dùng";
            f.Show();
        }

        private void quanLyQuan_Click(object sender, EventArgs e)
        {
            quanLyDatPhong f = new quanLyDatPhong();
            f.Text = "Quản lý đặt phòng";
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyThueTraPhong f = new QuanLyThueTraPhong();
            f.Text = "Quản lý quán thuê trả phòng";
            f.Show();
        }

        private void dangNhap_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Text = "Đăng nhập";
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoSoNV f = new HoSoNV();
            f.Text = "Thông tin cá nhân";
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyPhong f = new QuanLyPhong();
            f.Text = "Quản lý phòng";
            f.Show();
        }
    }
}
