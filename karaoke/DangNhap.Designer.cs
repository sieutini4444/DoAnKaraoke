﻿namespace karaoke
{
    partial class DangNhap
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
            this.Cancel = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.idUser = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(249, 141);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Hủy";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(144, 141);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(90, 23);
            this.logIn.TabIndex = 11;
            this.logIn.Text = "Đăng nhập";
            this.logIn.UseVisualStyleBackColor = true;
            // 
            // idUser
            // 
            this.idUser.Location = new System.Drawing.Point(144, 52);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(180, 20);
            this.idUser.TabIndex = 9;
            this.idUser.TextChanged += new System.EventHandler(this.idUser_TextChanged);
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(144, 93);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(180, 20);
            this.passWord.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên đăng nhập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 212);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}