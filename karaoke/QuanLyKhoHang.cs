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
    public partial class QuanLyKhoHang : Form
    {
        private bool isManager = false;
        private string username = "";
        public QuanLyKhoHang(bool isManager, string username)
        {
            InitializeComponent();
            serviceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.isManager = isManager;
            this.username = username;
        }

        QuanLyKaraokeDB db = new QuanLyKaraokeDB();

        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKARAOKEDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.quanLyKARAOKEDataSet.DICHVU);
            loadServiceList();

        }

        private void loadServiceList()
        {
            serviceList.DataSource = db.GetData("select * from DICHVU");
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu(isManager ,username);
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (serviceList.SelectedRows.Count == 0)
            {
                alertLable.Visible = true;
                return;
            }

            DataGridViewRow selectedRow = serviceList.SelectedRows[0];
            string serviceName = selectedRow.Cells["tenDV"].Value.ToString();
            string serviceID = selectedRow.Cells["maDV"].Value.ToString();
            string unit = selectedRow.Cells["donViTinh"].Value.ToString();

            using (actionForm importFrom = new actionForm(serviceName, serviceID, unit, "Nhập kho", 1))
            {
                importFrom.ShowDialog();
                loadServiceList();
            }

            alertLable.Visible = false;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (serviceList.SelectedRows.Count == 0)
            {
                alertLable.Visible = true;
                return;
            }

            DataGridViewRow selectedRow = serviceList.SelectedRows[0];
            string serviceName = selectedRow.Cells["tenDV"].Value.ToString();
            string serviceID = selectedRow.Cells["maDV"].Value.ToString();
            string unit = selectedRow.Cells["donViTinh"].Value.ToString();

            using (actionForm importFrom = new actionForm(serviceName, serviceID, unit, "Xuất kho", 2))
            {
                importFrom.ShowDialog();
                loadServiceList();
            }

            alertLable.Visible = false;
        }
    }
}
