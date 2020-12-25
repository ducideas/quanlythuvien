
namespace PL
{
    partial class PL_Reader_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Reader_List));
            this.datagridDanhSachDocGia = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaDocGia = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.ttbSearchDocGia = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.btnXoaDocGia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDanhSachDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridDanhSachDocGia
            // 
            this.datagridDanhSachDocGia.AllowUserToAddRows = false;
            this.datagridDanhSachDocGia.AllowUserToDeleteRows = false;
            this.datagridDanhSachDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDanhSachDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.HoVaTen,
            this.LoaiDocGia,
            this.GioiTinh,
            this.NgaySinh,
            this.Email,
            this.DiaChi,
            this.SoDT,
            this.NgayLapThe,
            this.TongNo});
            this.datagridDanhSachDocGia.Location = new System.Drawing.Point(9, 91);
            this.datagridDanhSachDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.datagridDanhSachDocGia.Name = "datagridDanhSachDocGia";
            this.datagridDanhSachDocGia.ReadOnly = true;
            this.datagridDanhSachDocGia.RowHeadersWidth = 51;
            this.datagridDanhSachDocGia.RowTemplate.Height = 24;
            this.datagridDanhSachDocGia.Size = new System.Drawing.Size(868, 311);
            this.datagridDanhSachDocGia.TabIndex = 38;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã độc giả";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 105;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ và tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            this.HoVaTen.Width = 125;
            // 
            // LoaiDocGia
            // 
            this.LoaiDocGia.DataPropertyName = "LoaiDocGia";
            this.LoaiDocGia.HeaderText = "Loại độc giả";
            this.LoaiDocGia.MinimumWidth = 6;
            this.LoaiDocGia.Name = "LoaiDocGia";
            this.LoaiDocGia.ReadOnly = true;
            this.LoaiDocGia.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 120;
            // 
            // NgayLapThe
            // 
            this.NgayLapThe.DataPropertyName = "NgayLapThe";
            this.NgayLapThe.HeaderText = "Ngày lập thẻ";
            this.NgayLapThe.MinimumWidth = 6;
            this.NgayLapThe.Name = "NgayLapThe";
            this.NgayLapThe.ReadOnly = true;
            this.NgayLapThe.Width = 125;
            // 
            // TongNo
            // 
            this.TongNo.DataPropertyName = "TongNo";
            this.TongNo.HeaderText = "Tổng nợ";
            this.TongNo.MinimumWidth = 6;
            this.TongNo.Name = "TongNo";
            this.TongNo.ReadOnly = true;
            this.TongNo.Width = 125;
            // 
            // btnSuaDocGia
            // 
            this.btnSuaDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSuaDocGia.Location = new System.Drawing.Point(554, 407);
            this.btnSuaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaDocGia.Name = "btnSuaDocGia";
            this.btnSuaDocGia.Size = new System.Drawing.Size(105, 32);
            this.btnSuaDocGia.TabIndex = 37;
            this.btnSuaDocGia.Text = "Sửa";
            this.btnSuaDocGia.UseVisualStyleBackColor = false;
            this.btnSuaDocGia.Click += new System.EventHandler(this.btnSuaDocGia_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(703, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 21);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 36;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ttbSearchDocGia
            // 
            this.ttbSearchDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ttbSearchDocGia.ForeColor = System.Drawing.Color.Gray;
            this.ttbSearchDocGia.Location = new System.Drawing.Point(373, 61);
            this.ttbSearchDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.ttbSearchDocGia.Name = "ttbSearchDocGia";
            this.ttbSearchDocGia.Size = new System.Drawing.Size(320, 23);
            this.ttbSearchDocGia.TabIndex = 35;
            this.ttbSearchDocGia.Text = "Mã độc giả hoặc tên độc giả hoặc số ĐT";
            this.ttbSearchDocGia.Click += new System.EventHandler(this.ttbTimKiem_Click);
            this.ttbSearchDocGia.TextChanged += new System.EventHandler(this.ttbSearchDocGia_TextChanged);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDong.Location = new System.Drawing.Point(772, 407);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 32);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quản Lý Độc Giả";
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemDocGia.Location = new System.Drawing.Point(445, 407);
            this.btnThemDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(105, 32);
            this.btnThemDocGia.TabIndex = 39;
            this.btnThemDocGia.Text = "Thêm Mới";
            this.btnThemDocGia.UseVisualStyleBackColor = false;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // btnXoaDocGia
            // 
            this.btnXoaDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoaDocGia.Location = new System.Drawing.Point(663, 407);
            this.btnXoaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDocGia.Name = "btnXoaDocGia";
            this.btnXoaDocGia.Size = new System.Drawing.Size(105, 32);
            this.btnXoaDocGia.TabIndex = 40;
            this.btnXoaDocGia.Text = "Xóa";
            this.btnXoaDocGia.UseVisualStyleBackColor = false;
            this.btnXoaDocGia.Click += new System.EventHandler(this.btnXoaDocGia_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 25);
            this.button1.TabIndex = 43;
            this.button1.Text = "Hiển thị Độc giả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PL_Reader_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoaDocGia);
            this.Controls.Add(this.btnThemDocGia);
            this.Controls.Add(this.datagridDanhSachDocGia);
            this.Controls.Add(this.btnSuaDocGia);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ttbSearchDocGia);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Name = "PL_Reader_List";
            this.Text = "PL_Reader_List";
            this.Load += new System.EventHandler(this.PL_Reader_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridDanhSachDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagridDanhSachDocGia;
        private System.Windows.Forms.Button btnSuaDocGia;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox ttbSearchDocGia;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.Button btnXoaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNo;
        private System.Windows.Forms.Button button1;
    }
}