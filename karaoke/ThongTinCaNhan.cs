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
    public partial class ThongTinCaNhan : Form
    {
        QuanLyKaraokeDB db = new QuanLyKaraokeDB();
        private string username = "";

        public ThongTinCaNhan(string username)
        {
            InitializeComponent();
            this.username = username;
            var staffInfo = db.GetData($"select * from NHANVIEN where tenDN='{username}'").Rows[0].ItemArray;
            loginNameLabel.Text = staffInfo[0].ToString();
            nameLabel.Text = staffInfo[2].ToString();
            sexLabel.Text = staffInfo[3].ToString();
            DoBLabel.Text = ((DateTime)staffInfo[4]).ToShortDateString();
            phoneLabel.Text = staffInfo[5].ToString();
            IDLabel.Text = staffInfo[6].ToString();
            positionLabel.Text = staffInfo[7].ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau(username);
            f.ShowDialog();
        }
    }
}
