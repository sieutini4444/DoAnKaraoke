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
    public partial class QuanLyThueTraPhong : Form
    {
        QuanLyKaraokeDB db = new QuanLyKaraokeDB();
        private bool isManager = false;
        private string username = "";

        public QuanLyThueTraPhong(bool isManager, string username)
        {
            InitializeComponent();
            this.isManager = isManager;
            this.username = username;
            loadList(roomList, "PHONG");
            loadList(serviceList, "DICHVU");


            roomList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            invoiceDetailList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            roomList.RowHeadersVisible=false;
            serviceList.RowHeadersVisible=false;
            invoiceDetailList.RowHeadersVisible=false;

            filterAllRoomRad.Checked = true;
        }

        private void loadList(DataGridView datagrid, string table)
        {
            datagrid.DataSource = db.GetData($"select * from {table}");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu(isManager, username);
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void filterAllRoomRad_CheckedChanged(object sender, EventArgs e)
        {
            if (filterAllRoomRad.Checked == true)
                loadList(roomList, "PHONG");
        }

        private void filterEmptyRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (filterEmptyRoom.Checked == true)
                roomList.DataSource = db.GetData($"select * from PHONG where maTinhTrang=0");
        }

        private void filterInUseRoom_CheckedChanged(object sender, EventArgs e)
        {

            if (filterInUseRoom.Checked == true)
                roomList.DataSource = db.GetData($"select * from PHONG where maTinhTrang=1");
        }

        private void roomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = roomList.Rows[e.RowIndex];
                roomIDTxt.Text = row.Cells["maPhong"].Value.ToString();
                roomTypeLabel.Text = row.Cells["loaiPhong"].Value.ToString();
                roomPriceLabel.Text = row.Cells["giaPhong"].Value.ToString();
                priceLabel.Text = row.Cells["giaPhong"].Value.ToString();
                alertLabel.Visible = false;

                var ticket = db.GetData($"select * from PHIEUDAT where maPhong='{roomIDTxt.Text}' ORDER BY maPD DESC").Rows;
                if (ticket.Count != 0 && Convert.ToInt32(db.GetData($"select maTinhTrang from PHONG where maPhong='{roomIDTxt.Text}'").Rows[0].ItemArray[0]) == 1)
                {
                    nameTxt.Text = ticket[0].ItemArray[2].ToString();
                    phoneTxt.Text = ticket[0].ItemArray[3].ToString();
                    IDTxt.Text = ticket[0].ItemArray[4].ToString();
                    invoiceDetailList.DataSource = db.GetData($"select * from CHITIETHOADON where maPD={ticket[0].ItemArray[5]}");
                    var dataRows = db.GetData($"select SUM(thanhGia) from CHITIETHOADON where maPD={ticket[0].ItemArray[5]}").Rows;
                    if (dataRows[0].ItemArray[0] != DBNull.Value)
                    {
                        int servicePrice = Convert.ToInt32(dataRows[0].ItemArray[0]);
                        servicePriceLabel.Text = servicePrice.ToString();
                        priceLabel.Text = (Convert.ToInt32(priceLabel.Text.ToString()) + servicePrice).ToString();
                    }
                }
                else
                {
                    nameTxt.Text = "";
                    phoneTxt.Text = "";
                    IDTxt.Text = "";
                    servicePriceLabel.Text = "0";
                    invoiceDetailList.DataSource = null;
                }
            }
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            string roomID = roomIDTxt.Text;

            var room = db.GetData($"select maTinhTrang from PHONG where maPHONG='{roomID}'").Rows;
            if (room.Count != 0)
                if (Convert.ToInt32(room[0].ItemArray[0]) != 0)
                { 
                    successLabel.Visible = false;
                    alertLabel.Visible = true;
                    return;
                }
            
            string customerName = nameTxt.Text;
            string phoneNumber = phoneTxt.Text;
            string personalID = IDTxt.Text;

            if (customerName == "" || phoneNumber == "" ||  personalID == "")
            {
                inforAlertLabel.Visible = true;
                return;
            }

            DateTime datetime = DateTime.Now;
            var ticket = db.GetData($"select * from PHIEUDAT ORDER BY maPD DESC").Rows;
            int maxID = 0;

            if (ticket.Count != 0)
                maxID = Convert.ToInt32(ticket[0].ItemArray[5]) + 1;

            db.Execute($"insert into PHIEUDAT values ('{roomID}', '{datetime}', N'{customerName}', '{phoneNumber}', {personalID}, {maxID})");
            db.Execute($"update PHONG set maTinhTrang=1, tinhTrang=N'Đang Dùng' where maPhong='{roomID}'");

            loadList(roomList, "PHONG");
            successLabel.Visible = true;
            inforAlertLabel.Visible = false;
            alertLabel.Visible = false;
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            string roomID = roomIDTxt.Text;

            var room = db.GetData($"select maTinhTrang from PHONG where maPHONG='{roomID}'").Rows;
            if (room.Count != 2)
                if (Convert.ToInt32(room[0].ItemArray[0]) == 2)
                {
                    successLabel.Visible = false;
                    alertLabel.Visible = true;
                    return;
                }


            var HDRows = db.GetData($"select * from HOADON ORDER BY maHD DESC").Rows;
            int maxID = 0;
            if (HDRows.Count != 0)
                maxID = Convert.ToInt32(HDRows[0].ItemArray[0]) + 1;

            var ticketID = db.GetData($"select * from PHIEUDAT where maPhong='{roomID}' ORDER BY maPD DESC").Rows[0].ItemArray[5];
            db.Execute($"insert into HOADON values ({maxID}, '{roomID}', {ticketID}, {priceLabel.Text})");

            nameTxt.Text = "";
            phoneTxt.Text = "";
            IDTxt.Text = "";
            servicePriceLabel.Text = "0";
            priceLabel.Text = "0";
                
            db.Execute($"update PHONG set maTinhTrang=0, tinhTrang=N'Trống' where maPhong='{roomID}'");
            invoiceDetailList.DataSource = null;
            loadList(roomList, "PHONG");
            successLabel.Visible = true;
            alertLabel.Visible = false;
        }

        private void serviceTypeDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = serviceTypeDropBox.SelectedItem.ToString();
            if (item.Equals("Tất cả"))
            {
                loadList(serviceList, "DICHVU");
                return;
            }
            serviceList.DataSource = db.GetData($"select * from DICHVU where loaiDV=N'{item}'");
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(db.GetData($"select maTinhTrang from PHONG where maPhong='{roomIDTxt.Text}'").Rows[0].ItemArray[0]) != 1)
            {
                alertLabel.Visible = true;
                return;
            }

            string serviceID = serviceList.SelectedRows[0].Cells["maDV"].Value.ToString();
            int quantity = (int)quantityNUD.Value;

            int remainQuantity = Convert.ToInt32(db.GetData($"select soLuongDV from DICHVU where maDV='{serviceID}'").Rows[0].ItemArray[0]);
            remainQuantity -= quantity;
            if (remainQuantity < 0)
            {
                alertServiceLabel.Visible = true;
                return;
            }


            string serviceName = serviceList.SelectedRows[0].Cells["tenDV"].Value.ToString();
            int servicePrice = Convert.ToInt32(serviceList.SelectedRows[0].Cells["giaDV"].Value);
            var invoiceDetail = db.GetData($"select * from CHITIETHOADON ORDER BY maCTHD DESC").Rows;
            var ticketID = db.GetData($"select * from PHIEUDAT where maPhong='{roomIDTxt.Text}' ORDER BY maPD DESC").Rows[0].ItemArray[5];
            int maxID = 0;

            if (invoiceDetail.Count != 0)
                maxID = Convert.ToInt32(invoiceDetail[0].ItemArray[0]) + 1;

            db.Execute($"update DICHVU set soLuongDV={remainQuantity} where maDV='{serviceID}'");
            db.Execute($"insert into CHITIETHOADON values ({maxID}, '{serviceID}', N'{serviceName}', {quantity}, {servicePrice}, {servicePrice * quantity}, '0', {ticketID})");
            alertServiceLabel.Visible = false;
            alertLabel.Visible = false;
            loadList(serviceList, "DICHVU");
            invoiceDetailList.DataSource = db.GetData($"select * from CHITIETHOADON where maPD='{ticketID}'");

            int servicesPrice = Convert.ToInt32(db.GetData($"select SUM(thanhGia) from CHITIETHOADON where maPD='{ticketID}'").Rows[0].ItemArray[0]);
            servicePriceLabel.Text = servicesPrice.ToString();
            priceLabel.Text = (Convert.ToInt32(roomPriceLabel.Text.ToString()) + servicesPrice).ToString();
        }
    }
}
