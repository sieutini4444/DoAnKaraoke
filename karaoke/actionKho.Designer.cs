namespace karaoke
{
    partial class actionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.serviceIDLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.actionBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Dịch Vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(63, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Dịch Vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(77, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng :";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.quantityTxt.Location = new System.Drawing.Point(174, 125);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(115, 26);
            this.quantityTxt.TabIndex = 3;
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.serviceNameLabel.Location = new System.Drawing.Point(170, 46);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(88, 19);
            this.serviceNameLabel.TabIndex = 4;
            this.serviceNameLabel.Text = "serviceName";
            // 
            // serviceIDLabel
            // 
            this.serviceIDLabel.AutoSize = true;
            this.serviceIDLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.serviceIDLabel.Location = new System.Drawing.Point(170, 85);
            this.serviceIDLabel.Name = "serviceIDLabel";
            this.serviceIDLabel.Size = new System.Drawing.Size(67, 19);
            this.serviceIDLabel.TabIndex = 5;
            this.serviceIDLabel.Text = "serviceID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(94, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Vị :";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.unitLabel.Location = new System.Drawing.Point(170, 168);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(30, 19);
            this.unitLabel.TabIndex = 7;
            this.unitLabel.Text = "unit";
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(172, 212);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(86, 35);
            this.actionBtn.TabIndex = 8;
            this.actionBtn.Text = "actionTxt";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(274, 212);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(86, 35);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Hủy";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // actionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 276);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serviceIDLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "actionForm";
            this.Text = "Quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.Label serviceIDLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Button backBtn;
    }
}