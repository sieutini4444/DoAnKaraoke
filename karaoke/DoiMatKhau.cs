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
    public partial class DoiMatKhau : Form
    {
        QuanLyKaraokeDB db = new QuanLyKaraokeDB();
        private string username = "";

        public DoiMatKhau(string username)
        {
            InitializeComponent();
            this.username = username;
            oldPassTxt.PasswordChar = '*';
            newPassTxt.PasswordChar = '*';
            newPassTxt2.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            string oldPass = oldPassTxt.Text.ToString();
            string newPass = newPassTxt.Text.ToString();
            string newPass2 = newPassTxt2.Text.ToString();

            var row = db.GetData($"select * from NHANVIEN where tenDN='{username}' and matKhau='{oldPass}'").Rows;
            if (row.Count == 1 && newPass.Equals(newPass2))
            {
                db.Execute($"update NHANVIEN set matKhau='{newPass}' where tenDN='{username}'");
                alertLabel.Visible = true;
                alertLabel.ForeColor = System.Drawing.Color.Green;
                alertLabel.Text = "Thành Công";
            }
            if (row.Count == 0)
            {
                alertLabel.Text = "Sai Mật Khẩu";
                alertLabel.Visible = true;
                return;
            }
            else if (!newPass.Equals(newPass2))
            {
                alertLabel.Text = "Nhập lại không khớp";
                alertLabel.Visible = true;
                return;
            }
        }
    }
}
