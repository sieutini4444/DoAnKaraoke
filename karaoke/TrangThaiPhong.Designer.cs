namespace karaoke
{
    partial class TrangThaiPhong
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
            this.roomList = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKARAOKEDataSet2 = new karaoke.QuanLyKARAOKEDataSet();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKARAOKEDataSet1 = new karaoke.QuanLyKARAOKEDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.alertLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomTypeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maintainRad = new System.Windows.Forms.RadioButton();
            this.usingRad = new System.Windows.Forms.RadioButton();
            this.emptyRad = new System.Windows.Forms.RadioButton();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quanLyKARAOKEDataSet = new karaoke.QuanLyKARAOKEDataSet();
            this.quanLyKARAOKEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new karaoke.QuanLyKARAOKEDataSetTableAdapters.NHANVIENTableAdapter();
            this.pHONGTableAdapter = new karaoke.QuanLyKARAOKEDataSetTableAdapters.PHONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomList
            // 
            this.roomList.AutoGenerateColumns = false;
            this.roomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.tinhTrang,
            this.maTinhTrang,
            this.loaiPhong,
            this.giaPhong});
            this.roomList.DataSource = this.pHONGBindingSource1;
            this.roomList.Location = new System.Drawing.Point(39, 287);
            this.roomList.Name = "roomList";
            this.roomList.ReadOnly = true;
            this.roomList.Size = new System.Drawing.Size(800, 222);
            this.roomList.TabIndex = 6;
            this.roomList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomList_CellClick);
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã Phòng";
            this.maPhong.Name = "maPhong";
            this.maPhong.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // maTinhTrang
            // 
            this.maTinhTrang.DataPropertyName = "maTinhTrang";
            this.maTinhTrang.HeaderText = "maTinhTrang";
            this.maTinhTrang.Name = "maTinhTrang";
            this.maTinhTrang.ReadOnly = true;
            this.maTinhTrang.Visible = false;
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "loaiPhong";
            this.loaiPhong.HeaderText = "Loại Phòng";
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.ReadOnly = true;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "giaPhong";
            this.giaPhong.HeaderText = "Giá Phòng";
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.ReadOnly = true;
            // 
            // pHONGBindingSource1
            // 
            this.pHONGBindingSource1.DataMember = "PHONG";
            this.pHONGBindingSource1.DataSource = this.quanLyKARAOKEDataSet2;
            // 
            // quanLyKARAOKEDataSet2
            // 
            this.quanLyKARAOKEDataSet2.DataSetName = "QuanLyKARAOKEDataSet";
            this.quanLyKARAOKEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.quanLyKARAOKEDataSet1;
            // 
            // quanLyKARAOKEDataSet1
            // 
            this.quanLyKARAOKEDataSet1.DataSetName = "QuanLyKARAOKEDataSet";
            this.quanLyKARAOKEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(252, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(350, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "Quản Lý Trạng Thái Phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.backBtn);
            this.groupBox4.Controls.Add(this.saveBtn);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(647, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 195);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(48, 114);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(109, 33);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Thoát";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(48, 49);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 35);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.alertLabel);
            this.groupBox3.Controls.Add(this.priceTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.roomTypeTxt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maintainRad);
            this.groupBox3.Controls.Add(this.usingRad);
            this.groupBox3.Controls.Add(this.emptyRad);
            this.groupBox3.Controls.Add(this.IDTxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(39, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 195);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.ForeColor = System.Drawing.Color.Red;
            this.alertLabel.Location = new System.Drawing.Point(95, 27);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(153, 19);
            this.alertLabel.TabIndex = 8;
            this.alertLabel.Text = "Mã phòng không tồn tại";
            this.alertLabel.Visible = false;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(431, 107);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(153, 26);
            this.priceTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Phòng";
            // 
            // roomTypeTxt
            // 
            this.roomTypeTxt.Location = new System.Drawing.Point(431, 49);
            this.roomTypeTxt.Name = "roomTypeTxt";
            this.roomTypeTxt.Size = new System.Drawing.Size(153, 26);
            this.roomTypeTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giá";
            // 
            // maintainRad
            // 
            this.maintainRad.AutoSize = true;
            this.maintainRad.Location = new System.Drawing.Point(99, 145);
            this.maintainRad.Name = "maintainRad";
            this.maintainRad.Size = new System.Drawing.Size(126, 23);
            this.maintainRad.TabIndex = 3;
            this.maintainRad.TabStop = true;
            this.maintainRad.Text = "Đang Sửa Chữa";
            this.maintainRad.UseVisualStyleBackColor = true;
            // 
            // usingRad
            // 
            this.usingRad.AutoSize = true;
            this.usingRad.Location = new System.Drawing.Point(214, 107);
            this.usingRad.Name = "usingRad";
            this.usingRad.Size = new System.Drawing.Size(83, 23);
            this.usingRad.TabIndex = 2;
            this.usingRad.TabStop = true;
            this.usingRad.Text = "Đang SD";
            this.usingRad.UseVisualStyleBackColor = true;
            // 
            // emptyRad
            // 
            this.emptyRad.AutoSize = true;
            this.emptyRad.Location = new System.Drawing.Point(99, 106);
            this.emptyRad.Name = "emptyRad";
            this.emptyRad.Size = new System.Drawing.Size(62, 23);
            this.emptyRad.TabIndex = 2;
            this.emptyRad.TabStop = true;
            this.emptyRad.Text = "Trống";
            this.emptyRad.UseVisualStyleBackColor = true;
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(97, 49);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(200, 26);
            this.IDTxt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tình Trạng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên Phòng";
            // 
            // quanLyKARAOKEDataSet
            // 
            this.quanLyKARAOKEDataSet.DataSetName = "QuanLyKARAOKEDataSet";
            this.quanLyKARAOKEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyKARAOKEDataSetBindingSource
            // 
            this.quanLyKARAOKEDataSetBindingSource.DataSource = this.quanLyKARAOKEDataSet;
            this.quanLyKARAOKEDataSetBindingSource.Position = 0;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyKARAOKEDataSetBindingSource;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // TrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 534);
            this.Controls.Add(this.roomList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "TrangThaiPhong";
            this.Text = "QuanLyPhong";
            this.Load += new System.EventHandler(this.TrangThaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton usingRad;
        private System.Windows.Forms.RadioButton emptyRad;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton maintainRad;
        private QuanLyKARAOKEDataSet quanLyKARAOKEDataSet;
        private System.Windows.Forms.BindingSource quanLyKARAOKEDataSetBindingSource;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QuanLyKARAOKEDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QuanLyKARAOKEDataSet quanLyKARAOKEDataSet1;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QuanLyKARAOKEDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private QuanLyKARAOKEDataSet quanLyKARAOKEDataSet2;
        private System.Windows.Forms.BindingSource pHONGBindingSource1;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomTypeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.Label alertLabel;
    }
}