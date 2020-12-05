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
            passTxt.PasswordChar = '*';
        }

        private void passWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginBtn.PerformClick();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ admin");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            QuanLyKaraokeDB db = new QuanLyKaraokeDB();
            var row = db.GetData($"select * from NHANVIEN where tenDN='{usernameTxt.Text.ToString()}' and matKhau='{passTxt.Text.ToString()}'").Rows;
            if (row.Count == 1)
            {
                string username = row[0].ItemArray[0].ToString();
                bool isManager = Convert.ToInt32(row[0].ItemArray[8].ToString()) == 1;
                Console.WriteLine(row[0].ItemArray[7]);
                Console.WriteLine(isManager);
                this.Hide();
                TrangChu f = new TrangChu(isManager, username);
                f.Text = "Trang Chủ";
                f.ShowDialog();
            }
            else
            {
                alertLabel.Visible = true;
            }
        }
    }
}
