namespace karaoke
{
    partial class Change_Password
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.currentPass = new System.Windows.Forms.TextBox();
            this.changePass = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ và Tên NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Xác nhận mật khẩu mới";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.Location = new System.Drawing.Point(174, 135);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(180, 20);
            this.confirmPass.TabIndex = 3;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(174, 94);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(180, 20);
            this.newPass.TabIndex = 3;
            // 
            // currentPass
            // 
            this.currentPass.Location = new System.Drawing.Point(174, 49);
            this.currentPass.Name = "currentPass";
            this.currentPass.Size = new System.Drawing.Size(180, 20);
            this.currentPass.TabIndex = 3;
            // 
            // changePass
            // 
            this.changePass.Location = new System.Drawing.Point(174, 183);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(90, 23);
            this.changePass.TabIndex = 4;
            this.changePass.Text = "Đổi mật khẩu";
            this.changePass.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(279, 183);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Hủy";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 251);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.currentPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox currentPass;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Button Cancel;
    }
}