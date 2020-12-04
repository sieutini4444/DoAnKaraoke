namespace karaoke
{
    partial class QuanLyKhoHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serviceList = new System.Windows.Forms.DataGridView();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKARAOKEDataSet = new karaoke.QuanLyKARAOKEDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dICHVUTableAdapter = new karaoke.QuanLyKARAOKEDataSetTableAdapters.DICHVUTableAdapter();
            this.loaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertLable = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceList);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 505);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mặt hàng";
            // 
            // serviceList
            // 
            this.serviceList.AutoGenerateColumns = false;
            this.serviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loaiDV,
            this.tenDV,
            this.donViTinh,
            this.giaDV,
            this.soLuong,
            this.maDV});
            this.serviceList.DataSource = this.dICHVUBindingSource;
            this.serviceList.Location = new System.Drawing.Point(6, 25);
            this.serviceList.Name = "serviceList";
            this.serviceList.ReadOnly = true;
            this.serviceList.Size = new System.Drawing.Size(773, 447);
            this.serviceList.TabIndex = 1;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.quanLyKARAOKEDataSet;
            // 
            // quanLyKARAOKEDataSet
            // 
            this.quanLyKARAOKEDataSet.DataSetName = "QuanLyKARAOKEDataSet";
            this.quanLyKARAOKEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alertLable);
            this.groupBox4.Controls.Add(this.exportBtn);
            this.groupBox4.Controls.Add(this.importBtn);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(837, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 381);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(36, 90);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(109, 34);
            this.exportBtn.TabIndex = 0;
            this.exportBtn.Text = "Xuất";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(36, 37);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(109, 36);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Nhập";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(873, 516);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(109, 33);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Thoát";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(460, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Kho";
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // loaiDV
            // 
            this.loaiDV.DataPropertyName = "loaiDV";
            this.loaiDV.HeaderText = "Loại Dịch Vụ";
            this.loaiDV.Name = "loaiDV";
            // 
            // tenDV
            // 
            this.tenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenDV.DataPropertyName = "tenDV";
            this.tenDV.HeaderText = "Tên Dịch Vụ";
            this.tenDV.Name = "tenDV";
            this.tenDV.Width = 111;
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn vị ";
            this.donViTinh.Name = "donViTinh";
            // 
            // giaDV
            // 
            this.giaDV.DataPropertyName = "giaDV";
            this.giaDV.HeaderText = "Giá Dịch Vụ";
            this.giaDV.Name = "giaDV";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuongDV";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã Dịch Vụ";
            this.maDV.Name = "maDV";
            // 
            // alertLable
            // 
            this.alertLable.AutoSize = true;
            this.alertLable.ForeColor = System.Drawing.Color.Red;
            this.alertLable.Location = new System.Drawing.Point(32, 160);
            this.alertLable.Name = "alertLable";
            this.alertLable.Size = new System.Drawing.Size(114, 19);
            this.alertLable.TabIndex = 1;
            this.alertLable.Text = "Hãy chọn dịch vụ";
            this.alertLable.Visible = false;
            // 
            // QuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 631);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyKhoHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKARAOKEDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView serviceList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label label1;
        private QuanLyKARAOKEDataSet quanLyKARAOKEDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QuanLyKARAOKEDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.Label alertLable;
    }
}