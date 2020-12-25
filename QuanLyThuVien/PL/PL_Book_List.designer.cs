
namespace PL
{
    partial class PL_Book_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_Book_List));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.datagridDanhSachSach = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnTimSach = new System.Windows.Forms.PictureBox();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDanhSachSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(9, 10);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // datagridDanhSachSach
            // 
            this.datagridDanhSachSach.CausesValidation = false;
            this.datagridDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDanhSachSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TenSach,
            this.TacGia,
            this.id_TheLoai,
            this.NamXuatBan,
            this.NhaXuatBan,
            this.TriGia,
            this.TinhTrang,
            this.SoLuong});
            this.datagridDanhSachSach.Location = new System.Drawing.Point(9, 92);
            this.datagridDanhSachSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagridDanhSachSach.Name = "datagridDanhSachSach";
            this.datagridDanhSachSach.RowHeadersWidth = 51;
            this.datagridDanhSachSach.RowTemplate.Height = 24;
            this.datagridDanhSachSach.Size = new System.Drawing.Size(868, 311);
            this.datagridDanhSachSach.TabIndex = 38;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã sách";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 125;
            // 
            // id_TheLoai
            // 
            this.id_TheLoai.DataPropertyName = "id_TheLoai";
            this.id_TheLoai.HeaderText = "Thể loại";
            this.id_TheLoai.MinimumWidth = 6;
            this.id_TheLoai.Name = "id_TheLoai";
            this.id_TheLoai.Width = 125;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm xuất bản";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.Width = 125;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.Width = 125;
            // 
            // TriGia
            // 
            this.TriGia.DataPropertyName = "TriGia";
            this.TriGia.HeaderText = "Trị giá";
            this.TriGia.MinimumWidth = 6;
            this.TriGia.Name = "TriGia";
            this.TriGia.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThemSach.Location = new System.Drawing.Point(445, 406);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(105, 32);
            this.btnThemSach.TabIndex = 37;
            this.btnThemSach.Text = "Thêm Mới";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnTimSach
            // 
            this.btnTimSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSach.Image")));
            this.btnTimSach.Location = new System.Drawing.Point(695, 59);
            this.btnTimSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(38, 24);
            this.btnTimSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTimSach.TabIndex = 36;
            this.btnTimSach.TabStop = false;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimSach.ForeColor = System.Drawing.Color.Gray;
            this.txtTimSach.Location = new System.Drawing.Point(323, 63);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(377, 23);
            this.txtTimSach.TabIndex = 35;
            this.txtTimSach.Text = "Mã sách, Tên Sách, Tên thể loại";
            this.txtTimSach.Click += new System.EventHandler(this.ttbTimKiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDong.Location = new System.Drawing.Point(772, 408);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 32);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quản Lý Sách";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(554, 407);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 32);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(663, 408);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 32);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(736, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 25);
            this.button1.TabIndex = 42;
            this.button1.Text = "Hiển thị tất cả sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PL_Book_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.datagridDanhSachSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnTimSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PL_Book_List";
            this.RightToLeftLayout = true;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.PL_Book_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDanhSachSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView datagridDanhSachSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.PictureBox btnTimSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button button1;
    }
}