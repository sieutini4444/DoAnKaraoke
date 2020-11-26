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
    public partial class QuanLyNV : Form
    {
        public QuanLyNV()
        {
            InitializeComponent();
            employeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            passTxt.PasswordChar = '*';
            loadData();
        }

        QuanLyKaraokeDB db = new QuanLyKaraokeDB();

        public void loadData()
        {
            employeList.DataSource = db.GetData("select * from NHANVIEN");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu();
            f.Text = "Trang chủ";
            f.ShowDialog();
        }

        private void QuanLyNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKARAOKEDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.quanLyKARAOKEDataSet.NHANVIEN);

        }


        private void employeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = employeList.Rows[e.RowIndex];
                userNameTxt.Text = row.Cells["tenDN"].Value.ToString();
                nameTxt.Text = row.Cells["hoTen"].Value.ToString();
                IDTxt.Text = row.Cells["cmnd"].Value.ToString();
                phoneTxt.Text = row.Cells["sdt"].Value.ToString();
                roleBox.Text = row.Cells["chucVu"].Value.ToString();
                birthDate.Value = (DateTime)row.Cells["ngaySinh"].Value;
                maleRad.Checked = !(bool)row.Cells["gioiTinh"].Value;
                femaleRad.Checked = (bool)row.Cells["gioiTinh"].Value;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var userName = userNameTxt.Text;

            if (db.GetData($"select * from NHANVIEN where NHANVIEN.tenDN='{userName}'").Rows.Count == 1)
            {
                alertLable.Visible = true;
                return;
            }

            var password = passTxt.Text;
            var name = nameTxt.Text;
            var phoneNum = phoneTxt.Text;
            var ID = IDTxt.Text;
            var sex =  !maleRad.Checked && femaleRad.Checked ? 1 : 0;
            var DOB = birthDate.Value.ToString();
            var role = roleBox.Text;

            var query = $"insert into NHANVIEN values ('{userName}', '{password}', N'{name}', {sex}, '{DOB}', '{phoneNum}', '{ID}', N'{role}')";
            db.Execute(query);
            alertLable.Visible = false;
            loadData();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var userName = userNameTxt.Text;

            db.Execute($"delete from NHANVIEN where NHANVIEN.tenDN='{userName}'");
            loadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var userName = userNameTxt.Text;
            var password = passTxt.Text;
            var name = nameTxt.Text;
            var phoneNum = phoneTxt.Text;
            var ID = IDTxt.Text;
            var sex =  !maleRad.Checked && femaleRad.Checked ? 1 : 0;
            var DOB = birthDate.Value.ToString();
            var role = roleBox.Text;

            var query = $"update NHANVIEN set " +
                        (password != "" ? $"matKhau='{password}'," : "") +
                        $"hoTen=N'{name}', gioiTinh={sex}, ngaySinh='{DOB}', sdt='{phoneNum}', cmnd='{ID}', chucVu=N'{role}' where NHANVIEN.tenDN='{userName}'";

            db.Execute(query);
            loadData();
        }
    }
}
