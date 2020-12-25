
namespace PL
{
    partial class PL_Report_BorrowBook_ByCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Report_BorrowBook_ByCategory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewBorrowBookReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowBookReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(572, 38);
            this.label5.TabIndex = 96;
            this.label5.Text = "Thống kê Mượn sách Theo Thể Loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewBorrowBookReport
            // 
            this.dataGridViewBorrowBookReport.AllowUserToAddRows = false;
            this.dataGridViewBorrowBookReport.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowBookReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowBookReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TenTheLoai,
            this.SoLuotMuon});
            this.dataGridViewBorrowBookReport.Location = new System.Drawing.Point(114, 174);
            this.dataGridViewBorrowBookReport.Name = "dataGridViewBorrowBookReport";
            this.dataGridViewBorrowBookReport.ReadOnly = true;
            this.dataGridViewBorrowBookReport.RowHeadersWidth = 51;
            this.dataGridViewBorrowBookReport.RowTemplate.Height = 24;
            this.dataGridViewBorrowBookReport.Size = new System.Drawing.Size(565, 323);
            this.dataGridViewBorrowBookReport.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Tháng";
            // 
            // cbbThang
            // 
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(193, 112);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(125, 37);
            this.cbbThang.TabIndex = 99;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXemBaoCao.Location = new System.Drawing.Point(343, 110);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(156, 39);
            this.btnXemBaoCao.TabIndex = 100;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDong.Location = new System.Drawing.Point(523, 110);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 39);
            this.btnDong.TabIndex = 101;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "ten";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            this.TenTheLoai.Width = 125;
            // 
            // SoLuotMuon
            // 
            this.SoLuotMuon.DataPropertyName = "SoLuotMuon";
            this.SoLuotMuon.HeaderText = "Số Lượt Mượn";
            this.SoLuotMuon.MinimumWidth = 6;
            this.SoLuotMuon.Name = "SoLuotMuon";
            this.SoLuotMuon.ReadOnly = true;
            this.SoLuotMuon.Width = 125;
            // 
            // PL_Report_BorrowBook_ByCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBorrowBookReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PL_Report_BorrowBook_ByCategory";
            this.Text = "Thống kê Mượn sách Theo Thể Loại";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowBookReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewBorrowBookReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotMuon;
    }
}