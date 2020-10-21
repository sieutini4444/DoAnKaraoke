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
    public partial class HoSoNV : Form
    {
        public HoSoNV()
        {
            InitializeComponent();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            Change_Password f = new Change_Password();
            f.Text = "Đổi mật khẩu";
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
