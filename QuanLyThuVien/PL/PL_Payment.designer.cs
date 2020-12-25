namespace PL
{
    partial class PL_Payment
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
            this.ttbPhiThue = new System.Windows.Forms.TextBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbTienBoiThuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbTienPhat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbTongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phí thuê";
            // 
            // ttbPhiThue
            // 
            this.ttbPhiThue.Location = new System.Drawing.Point(128, 59);
            this.ttbPhiThue.Name = "ttbPhiThue";
            this.ttbPhiThue.ReadOnly = true;
            this.ttbPhiThue.Size = new System.Drawing.Size(286, 20);
            this.ttbPhiThue.TabIndex = 1;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(201, 304);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(96, 37);
            this.btnHoanTat.TabIndex = 2;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền bồi thường";
            // 
            // ttbTienBoiThuong
            // 
            this.ttbTienBoiThuong.Location = new System.Drawing.Point(128, 144);
            this.ttbTienBoiThuong.Name = "ttbTienBoiThuong";
            this.ttbTienBoiThuong.ReadOnly = true;
            this.ttbTienBoiThuong.Size = new System.Drawing.Size(286, 20);
            this.ttbTienBoiThuong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiện phạt";
            // 
            // ttbTienPhat
            // 
            this.ttbTienPhat.Location = new System.Drawing.Point(128, 101);
            this.ttbTienPhat.Name = "ttbTienPhat";
            this.ttbTienPhat.ReadOnly = true;
            this.ttbTienPhat.Size = new System.Drawing.Size(286, 20);
            this.ttbTienPhat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // ttbTongTien
            // 
            this.ttbTongTien.Location = new System.Drawing.Point(128, 216);
            this.ttbTongTien.Name = "ttbTongTien";
            this.ttbTongTien.ReadOnly = true;
            this.ttbTongTien.Size = new System.Drawing.Size(286, 20);
            this.ttbTongTien.TabIndex = 1;
            // 
            // PL_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.ttbTienPhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttbTienBoiThuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbPhiThue);
            this.Controls.Add(this.label1);
            this.Name = "PL_Payment";
            this.Text = "Phiếu Thu Tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbPhiThue;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbTienBoiThuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbTienPhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbTongTien;
    }
}