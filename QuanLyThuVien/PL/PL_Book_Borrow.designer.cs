namespace PL
{
    partial class PL_Book_Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Book_Borrow));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ttbMaSach = new System.Windows.Forms.TextBox();
            this.ttbNgayMuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbMaDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.dtgvSachMuon = new System.Windows.Forms.DataGridView();
            this.dtgvsachMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachCreatedat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmNămXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvsachmUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(325, 222);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 32);
            this.button5.TabIndex = 58;
            this.button5.Text = "Tìm sách";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1038, 405);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 32);
            this.button4.TabIndex = 57;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(863, 405);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 32);
            this.button3.TabIndex = 56;
            this.button3.Text = "Lập phiếu mượn";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(579, 269);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 81);
            this.panel1.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 19);
            this.button2.TabIndex = 29;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDichTrai_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 19);
            this.button1.TabIndex = 28;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDichPhai_Click);
            // 
            // ttbMaSach
            // 
            this.ttbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbMaSach.Location = new System.Drawing.Point(90, 223);
            this.ttbMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.ttbMaSach.Name = "ttbMaSach";
            this.ttbMaSach.Size = new System.Drawing.Size(224, 28);
            this.ttbMaSach.TabIndex = 50;
            // 
            // ttbNgayMuon
            // 
            this.ttbNgayMuon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttbNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbNgayMuon.Location = new System.Drawing.Point(776, 158);
            this.ttbNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.ttbNgayMuon.Name = "ttbNgayMuon";
            this.ttbNgayMuon.Size = new System.Drawing.Size(180, 28);
            this.ttbNgayMuon.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày mượn";
            // 
            // ttbHoTen
            // 
            this.ttbHoTen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ttbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbHoTen.Location = new System.Drawing.Point(445, 158);
            this.ttbHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.ttbHoTen.Name = "ttbHoTen";
            this.ttbHoTen.Size = new System.Drawing.Size(185, 28);
            this.ttbHoTen.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Họ và tên";
            // 
            // ttbMaDocGia
            // 
            this.ttbMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbMaDocGia.Location = new System.Drawing.Point(217, 157);
            this.ttbMaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.ttbMaDocGia.Name = "ttbMaDocGia";
            this.ttbMaDocGia.Size = new System.Drawing.Size(97, 28);
            this.ttbMaDocGia.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 37);
            this.label4.TabIndex = 43;
            this.label4.Text = "Phiếu mượn sách";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 39);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // dtgvSach
            // 
            this.dtgvSach.AllowUserToAddRows = false;
            this.dtgvSach.AllowUserToDeleteRows = false;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvsachMaSach,
            this.dtgvsachTenSach,
            this.dtgvsachTacGia,
            this.dtgvsachTheLoai,
            this.dtgvsachTinhTrang,
            this.dtgvsachTriGia,
            this.dtgvsachNhaXB,
            this.dtgvsachNamXB,
            this.dtgvsachSoLuong,
            this.dtgvsachCreatedat,
            this.dtgvsachUpdatedAt});
            this.dtgvSach.Location = new System.Drawing.Point(44, 260);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowHeadersVisible = false;
            this.dtgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSach.Size = new System.Drawing.Size(505, 102);
            this.dtgvSach.TabIndex = 59;
            // 
            // dtgvSachMuon
            // 
            this.dtgvSachMuon.AllowUserToAddRows = false;
            this.dtgvSachMuon.AllowUserToDeleteRows = false;
            this.dtgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvsachmMaSach,
            this.dtgvsachmTenSach,
            this.dtgvsachmTacGia,
            this.dtgvsachmTheLoai,
            this.dtgvsachmTinhTrang,
            this.dtgvsachmTriGia,
            this.dtgvsachmNhaXB,
            this.dtgvsachmNămXB,
            this.dtgvsachmSoLuong,
            this.dtgvsachmCreatedAt,
            this.dtgvsachmUpdatedAt});
            this.dtgvSachMuon.Location = new System.Drawing.Point(663, 260);
            this.dtgvSachMuon.Name = "dtgvSachMuon";
            this.dtgvSachMuon.ReadOnly = true;
            this.dtgvSachMuon.RowHeadersVisible = false;
            this.dtgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSachMuon.Size = new System.Drawing.Size(490, 102);
            this.dtgvSachMuon.TabIndex = 60;
            // 
            // dtgvsachMaSach
            // 
            this.dtgvsachMaSach.HeaderText = "Id";
            this.dtgvsachMaSach.Name = "dtgvsachMaSach";
            this.dtgvsachMaSach.ReadOnly = true;
            this.dtgvsachMaSach.Width = 30;
            // 
            // dtgvsachTenSach
            // 
            this.dtgvsachTenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvsachTenSach.HeaderText = "Tên Sách";
            this.dtgvsachTenSach.Name = "dtgvsachTenSach";
            this.dtgvsachTenSach.ReadOnly = true;
            // 
            // dtgvsachTacGia
            // 
            this.dtgvsachTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvsachTacGia.HeaderText = "Tác Giả";
            this.dtgvsachTacGia.Name = "dtgvsachTacGia";
            this.dtgvsachTacGia.ReadOnly = true;
            // 
            // dtgvsachTheLoai
            // 
            this.dtgvsachTheLoai.HeaderText = "Thể Loại";
            this.dtgvsachTheLoai.Name = "dtgvsachTheLoai";
            this.dtgvsachTheLoai.ReadOnly = true;
            this.dtgvsachTheLoai.Width = 90;
            // 
            // dtgvsachTinhTrang
            // 
            this.dtgvsachTinhTrang.HeaderText = "Tình Trạng";
            this.dtgvsachTinhTrang.Name = "dtgvsachTinhTrang";
            this.dtgvsachTinhTrang.ReadOnly = true;
            this.dtgvsachTinhTrang.Width = 90;
            // 
            // dtgvsachTriGia
            // 
            this.dtgvsachTriGia.HeaderText = "Trị Giá";
            this.dtgvsachTriGia.Name = "dtgvsachTriGia";
            this.dtgvsachTriGia.ReadOnly = true;
            this.dtgvsachTriGia.Visible = false;
            // 
            // dtgvsachNhaXB
            // 
            this.dtgvsachNhaXB.HeaderText = "Nhà Xuất Bản";
            this.dtgvsachNhaXB.Name = "dtgvsachNhaXB";
            this.dtgvsachNhaXB.ReadOnly = true;
            this.dtgvsachNhaXB.Visible = false;
            // 
            // dtgvsachNamXB
            // 
            this.dtgvsachNamXB.HeaderText = "Năm Xuất Bản";
            this.dtgvsachNamXB.Name = "dtgvsachNamXB";
            this.dtgvsachNamXB.ReadOnly = true;
            this.dtgvsachNamXB.Visible = false;
            // 
            // dtgvsachSoLuong
            // 
            this.dtgvsachSoLuong.HeaderText = "Số Lượng";
            this.dtgvsachSoLuong.Name = "dtgvsachSoLuong";
            this.dtgvsachSoLuong.ReadOnly = true;
            this.dtgvsachSoLuong.Visible = false;
            // 
            // dtgvsachCreatedat
            // 
            this.dtgvsachCreatedat.HeaderText = "Thời Gian Tạo";
            this.dtgvsachCreatedat.Name = "dtgvsachCreatedat";
            this.dtgvsachCreatedat.ReadOnly = true;
            this.dtgvsachCreatedat.Visible = false;
            // 
            // dtgvsachUpdatedAt
            // 
            this.dtgvsachUpdatedAt.HeaderText = "Thời Gian Cập Nhật";
            this.dtgvsachUpdatedAt.Name = "dtgvsachUpdatedAt";
            this.dtgvsachUpdatedAt.ReadOnly = true;
            this.dtgvsachUpdatedAt.Visible = false;
            // 
            // dtgvsachmMaSach
            // 
            this.dtgvsachmMaSach.HeaderText = "Id";
            this.dtgvsachmMaSach.Name = "dtgvsachmMaSach";
            this.dtgvsachmMaSach.ReadOnly = true;
            this.dtgvsachmMaSach.Width = 30;
            // 
            // dtgvsachmTenSach
            // 
            this.dtgvsachmTenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvsachmTenSach.HeaderText = "Tên Sách";
            this.dtgvsachmTenSach.Name = "dtgvsachmTenSach";
            this.dtgvsachmTenSach.ReadOnly = true;
            // 
            // dtgvsachmTacGia
            // 
            this.dtgvsachmTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvsachmTacGia.HeaderText = "Tác Giả";
            this.dtgvsachmTacGia.Name = "dtgvsachmTacGia";
            this.dtgvsachmTacGia.ReadOnly = true;
            // 
            // dtgvsachmTheLoai
            // 
            this.dtgvsachmTheLoai.HeaderText = "Thể Loại";
            this.dtgvsachmTheLoai.Name = "dtgvsachmTheLoai";
            this.dtgvsachmTheLoai.ReadOnly = true;
            this.dtgvsachmTheLoai.Width = 90;
            // 
            // dtgvsachmTinhTrang
            // 
            this.dtgvsachmTinhTrang.HeaderText = "Tình Trạng";
            this.dtgvsachmTinhTrang.Name = "dtgvsachmTinhTrang";
            this.dtgvsachmTinhTrang.ReadOnly = true;
            this.dtgvsachmTinhTrang.Width = 90;
            // 
            // dtgvsachmTriGia
            // 
            this.dtgvsachmTriGia.HeaderText = "Trị Giá";
            this.dtgvsachmTriGia.Name = "dtgvsachmTriGia";
            this.dtgvsachmTriGia.ReadOnly = true;
            this.dtgvsachmTriGia.Visible = false;
            // 
            // dtgvsachmNhaXB
            // 
            this.dtgvsachmNhaXB.HeaderText = "Nhà Xuất Bản";
            this.dtgvsachmNhaXB.Name = "dtgvsachmNhaXB";
            this.dtgvsachmNhaXB.ReadOnly = true;
            this.dtgvsachmNhaXB.Visible = false;
            // 
            // dtgvsachmNămXB
            // 
            this.dtgvsachmNămXB.HeaderText = "Năm Xuất Bản";
            this.dtgvsachmNămXB.Name = "dtgvsachmNămXB";
            this.dtgvsachmNămXB.ReadOnly = true;
            this.dtgvsachmNămXB.Visible = false;
            // 
            // dtgvsachmSoLuong
            // 
            this.dtgvsachmSoLuong.HeaderText = "Số Lượng";
            this.dtgvsachmSoLuong.Name = "dtgvsachmSoLuong";
            this.dtgvsachmSoLuong.ReadOnly = true;
            this.dtgvsachmSoLuong.Visible = false;
            // 
            // dtgvsachmCreatedAt
            // 
            this.dtgvsachmCreatedAt.HeaderText = "Thời Gian Tạo";
            this.dtgvsachmCreatedAt.Name = "dtgvsachmCreatedAt";
            this.dtgvsachmCreatedAt.ReadOnly = true;
            this.dtgvsachmCreatedAt.Visible = false;
            // 
            // dtgvsachmUpdatedAt
            // 
            this.dtgvsachmUpdatedAt.HeaderText = "Thời Gian Cập Nhật";
            this.dtgvsachmUpdatedAt.Name = "dtgvsachmUpdatedAt";
            this.dtgvsachmUpdatedAt.ReadOnly = true;
            this.dtgvsachmUpdatedAt.Visible = false;
            // 
            // PL_Book_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 470);
            this.Controls.Add(this.dtgvSachMuon);
            this.Controls.Add(this.dtgvSach);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ttbMaSach);
            this.Controls.Add(this.ttbNgayMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbMaDocGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Name = "PL_Book_Borrow";
            this.Text = "Lập Phiếu Mượn Sách";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ttbMaSach;
        private System.Windows.Forms.TextBox ttbNgayMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbMaDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.DataGridView dtgvSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachCreatedat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachUpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmNămXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvsachmUpdatedAt;
    }
}