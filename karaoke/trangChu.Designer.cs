namespace karaoke
{
    partial class trangChu
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
            this.button1 = new System.Windows.Forms.Button();
            this.quanLyQuan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dangNhap = new System.Windows.Forms.Button();
            this.suaHoSo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Danh sách người dùng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.manageUser);
            // 
            // quanLyQuan
            // 
            this.quanLyQuan.Location = new System.Drawing.Point(25, 274);
            this.quanLyQuan.Name = "quanLyQuan";
            this.quanLyQuan.Size = new System.Drawing.Size(139, 23);
            this.quanLyQuan.TabIndex = 2;
            this.quanLyQuan.Text = "Quản lý đặt phòng";
            this.quanLyQuan.UseVisualStyleBackColor = true;
            this.quanLyQuan.Click += new System.EventHandler(this.quanLyQuan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quản lý thuê trả phòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dangNhap
            // 
            this.dangNhap.Location = new System.Drawing.Point(561, 102);
            this.dangNhap.Name = "dangNhap";
            this.dangNhap.Size = new System.Drawing.Size(120, 23);
            this.dangNhap.TabIndex = 4;
            this.dangNhap.Text = "Đăng nhập";
            this.dangNhap.UseVisualStyleBackColor = true;
            this.dangNhap.Click += new System.EventHandler(this.dangNhap_Click);
            // 
            // suaHoSo
            // 
            this.suaHoSo.Location = new System.Drawing.Point(561, 61);
            this.suaHoSo.Name = "suaHoSo";
            this.suaHoSo.Size = new System.Drawing.Size(120, 23);
            this.suaHoSo.TabIndex = 5;
            this.suaHoSo.Text = "Sửa hồ sơ";
            this.suaHoSo.UseVisualStyleBackColor = true;
            this.suaHoSo.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Quản lý phòng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Đăng xuất";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.dangNhap_Click);
            // 
            // trangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.suaHoSo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dangNhap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.quanLyQuan);
            this.Controls.Add(this.button1);
            this.Name = "trangChu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quanLyQuan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dangNhap;
        private System.Windows.Forms.Button suaHoSo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}