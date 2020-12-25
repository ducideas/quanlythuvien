
namespace PL
{
    partial class PL_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Report));
            this.btnDong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnBookReportIcon = new System.Windows.Forms.PictureBox();
            this.BorrowBookReportIcon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookReportIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBookReportIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDong.Location = new System.Drawing.Point(316, 397);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 39);
            this.btnDong.TabIndex = 106;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 105;
            this.label3.Text = "Thống kê Sách trả trễ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 25);
            this.label2.TabIndex = 104;
            this.label2.Text = "Thống kê Mượn sách Theo Thể Loại";
            // 
            // ReturnBookReportIcon
            // 
            this.ReturnBookReportIcon.Image = ((System.Drawing.Image)(resources.GetObject("ReturnBookReportIcon.Image")));
            this.ReturnBookReportIcon.Location = new System.Drawing.Point(465, 163);
            this.ReturnBookReportIcon.Name = "ReturnBookReportIcon";
            this.ReturnBookReportIcon.Size = new System.Drawing.Size(252, 150);
            this.ReturnBookReportIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReturnBookReportIcon.TabIndex = 103;
            this.ReturnBookReportIcon.TabStop = false;
            this.ReturnBookReportIcon.Click += new System.EventHandler(this.ReturnBookReportIcon_Click);
            // 
            // BorrowBookReportIcon
            // 
            this.BorrowBookReportIcon.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBookReportIcon.Image")));
            this.BorrowBookReportIcon.Location = new System.Drawing.Point(138, 163);
            this.BorrowBookReportIcon.Name = "BorrowBookReportIcon";
            this.BorrowBookReportIcon.Size = new System.Drawing.Size(163, 150);
            this.BorrowBookReportIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorrowBookReportIcon.TabIndex = 102;
            this.BorrowBookReportIcon.TabStop = false;
            this.BorrowBookReportIcon.Click += new System.EventHandler(this.BorrowBookReportIcon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 46);
            this.label5.TabIndex = 101;
            this.label5.Text = "Báo cáo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // PL_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturnBookReportIcon);
            this.Controls.Add(this.BorrowBookReportIcon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Name = "PL_Report";
            this.Text = "PL_Report";
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookReportIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBookReportIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ReturnBookReportIcon;
        private System.Windows.Forms.PictureBox BorrowBookReportIcon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}