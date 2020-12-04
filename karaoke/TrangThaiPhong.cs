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

        QuanLyKaraokeDB db = new QuanLyKaraokeDB();


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu();
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void TrangThaiPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKARAOKEDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyKARAOKEDataSet.NHANVIEN);
            roomList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadRoomList();
        }

        private void loadRoomList()
        {
            roomList.DataSource = db.GetData("select * from PHONG");
        }

        private void roomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = roomList.Rows[e.RowIndex];
                IDTxt.Text = row.Cells["maPhong"].Value.ToString();
                roomTypeTxt.Text = row.Cells["loaiPhong"].Value.ToString();
                priceTxt.Text = row.Cells["giaPhong"].Value.ToString();

                int stateID = (int)row.Cells["maTinhTrang"].Value;

                if (stateID == 1)
                    usingRad.Checked = true;
                else if (stateID == 0)
                    emptyRad.Checked = true;
                else
                    maintainRad.Checked = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string roomID = IDTxt.Text;

            if (db.GetData($"select * from PHONG where PHONG.maPhong='{roomID}'").Rows.Count != 1)
            {
                alertLabel.Visible = true;
                return;
            }

            string roomType = roomTypeTxt.Text;
            string price = priceTxt.Text;

            int stateID = -1;
            string roomState = "";
            if (emptyRad.Checked)
            {
                stateID = 0;
                roomState = "Trống";
            } else if (usingRad.Checked) {
                stateID = 1;
                roomState = "Đang Dùng";
            } else {
                stateID = 2;
                roomState = "Đang Sửa Chữa";
            }

            db.Execute($"update PHONG set tinhTrang=N'{roomState}', maTinhTrang={stateID}, giaPhong={price}, loaiPhong=N'{roomType}' where maPHong='{roomID}'");
            loadRoomList();
        }
    }
}
