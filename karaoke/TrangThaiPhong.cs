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
    public partial class TrangThaiPhong : Form
    {
        public TrangThaiPhong()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
                    }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu();
            f.Text = "Trang chủ";
            f.ShowDialog();
        }
    }
}
