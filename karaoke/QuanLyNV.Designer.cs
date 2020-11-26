namespace karaoke
{
    partial class QuanLyNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeList = new System.Windows.Forms.DataGridView();
            this.tenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKARAOKEDataSet = new karaoke.QuanLyKARAOKEDataSet();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.femaleRad = new System.Windows.Forms.RadioButton();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.maleRad = new System.Windows.Forms.RadioButton();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.alertLable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nHANVIENTableAdapter = new karaoke.QuanLyKARAOKEDataSetTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeList
            // 
            this.employeList.AllowUserToAddRows = false;
            this.employeList.AutoGenerateColumns = false;
            this.employeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDN,
            this.matKhau,
            this.hoTen,
            this.gioiTinh,
            this.ngaySinh,
            this.sdt,
            this.cmnd,
            this.chucVu});
            this.employeList.DataSource = this.nHANVIENBindingSource;
            this.employeList.Location = new System.Drawing.Point(17, 19);
            this.employeList.Name = "employeList";
            this.employeList.ReadOnly = true;
            this.employeList.Size = new System.Drawing.Size(845, 206);
            this.employeList.TabIndex = 0;
            this.employeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeList_CellClick);
            // 
            // tenDN
            // 
            this.tenDN.DataPropertyName = "tenDN";
            this.tenDN.HeaderText = "Tên Đăng Nhập";
            this.tenDN.Name = "tenDN";
            this.tenDN.ReadOnly = true;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "matKhau";
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            this.matKhau.Visible = false;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.FalseValue = "false";
            this.gioiTinh.HeaderText = "Nữ";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            this.gioiTinh.TrueValue = "true";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // chucVu
            // 
            this.chucVu.DataPropertyName = "chucVu";
            this.chucVu.HeaderText = "Chức Vụ";
            this.chucVu.Name = "chucVu";
            this.chucVu.ReadOnly = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyKARAOKEDataSet;
            // 
            // quanLyKARAOKEDataSet
            // 
            this.quanLyKARAOKEDataSet.DataSetName = "QuanLyKARAOKEDataSet";
            this.quanLyKARAOKEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(25, 35);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(114, 29);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(25, 266);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(114, 32);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Thoát";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.roleBox.Location = new System.Drawing.Point(127, 265);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(235, 27);
            this.roleBox.TabIndex = 21;
            // 
            // femaleRad
            // 
            this.femaleRad.AutoSize = true;
            this.femaleRad.Location = new System.Drawing.Point(214, 78);
            this.femaleRad.Name = "femaleRad";
            this.femaleRad.Size = new System.Drawing.Size(48, 23);
            this.femaleRad.TabIndex = 17;
            this.femaleRad.TabStop = true;
            this.femaleRad.Text = "Nữ";
            this.femaleRad.UseVisualStyleBackColor = true;
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(127, 221);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(235, 26);
            this.IDTxt.TabIndex = 20;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(127, 173);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(235, 26);
            this.phoneTxt.TabIndex = 20;
            // 
            // maleRad
            // 
            this.maleRad.AutoSize = true;
            this.maleRad.Location = new System.Drawing.Point(127, 78);
            this.maleRad.Name = "maleRad";
            this.maleRad.Size = new System.Drawing.Size(57, 23);
            this.maleRad.TabIndex = 18;
            this.maleRad.TabStop = true;
            this.maleRad.Text = "Nam";
            this.maleRad.UseVisualStyleBackColor = true;
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(127, 122);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(235, 26);
            this.birthDate.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(127, 34);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(235, 26);
            this.nameTxt.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.saveBtn);
            this.groupBox5.Controls.Add(this.updateBtn);
            this.groupBox5.Controls.Add(this.addBtn);
            this.groupBox5.Controls.Add(this.backBtn);
            this.groupBox5.Controls.Add(this.removeBtn);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(763, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 316);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(25, 186);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 29);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(25, 86);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(114, 29);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(25, 138);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(114, 29);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Xóa";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeList);
            this.groupBox1.Location = new System.Drawing.Point(40, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 242);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alertLable);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.userNameTxt);
            this.groupBox4.Controls.Add(this.passTxt);
            this.groupBox4.Controls.Add(this.roleBox);
            this.groupBox4.Controls.Add(this.femaleRad);
            this.groupBox4.Controls.Add(this.IDTxt);
            this.groupBox4.Controls.Add(this.phoneTxt);
            this.groupBox4.Controls.Add(this.maleRad);
            this.groupBox4.Controls.Add(this.birthDate);
            this.groupBox4.Controls.Add(this.nameTxt);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(40, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 318);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hồ sơ";
            // 
            // alertLable
            // 
            this.alertLable.AutoSize = true;
            this.alertLable.ForeColor = System.Drawing.Color.Red;
            this.alertLable.Location = new System.Drawing.Point(466, 199);
            this.alertLable.Name = "alertLable";
            this.alertLable.Size = new System.Drawing.Size(158, 19);
            this.alertLable.TabIndex = 26;
            this.alertLable.Text = "Tên đăng nhập đã tồn tại";
            this.alertLable.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tên DN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mật khẩu";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(470, 221);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(153, 26);
            this.userNameTxt.TabIndex = 23;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(470, 265);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(153, 26);
            this.passTxt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(331, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quản Lý Nhân Viên";
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 652);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Name = "QuanLyNV";
            this.Text = "HoSoAdmin";
            this.Load += new System.EventHandler(this.QuanLyNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.RadioButton femaleRad;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.RadioButton maleRad;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private QuanLyKARAOKEDataSet quanLyKARAOKEDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QuanLyKARAOKEDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private System.Windows.Forms.Label alertLable;
    }
}