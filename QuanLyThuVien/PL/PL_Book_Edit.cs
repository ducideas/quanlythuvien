using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace PL
{
    public partial class PL_Book_Edit : Form
    {
        BLL_Sach bllsach = new BLL_Sach();
        public delegate void DeLe(string param);
        public DeLe EditDelegate;
        private DTO_SACH Edit;
        public PL_Book_Edit(DTO_SACH book)
        {
            InitializeComponent();
            Edit = book;
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtTheLoai.Text != "" && txtTacGia.Text != "" 
                && txtNamXuatBan.Text != "" && txtNhaXuatBan.Text != "" && txtTriGia.Text != "")
            {
                // Tạo DTo
                DTO_SACH book = new DTO_SACH(int.Parse(txtMaSach.Text), txtTenSach.Text, txtTacGia.Text, 
               int.Parse(txtTheLoai.Text), int.Parse(txtNamXuatBan.Text), txtNhaXuatBan.Text, int.Parse(txtTriGia.Text), txtTrangThai.Text, 0);
                // Them
                if (bllsach.suaSach(book))
                {
                    MessageBox.Show("Sửa thành công");
                    this.EditDelegate.Invoke("OK");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PL_Book_Edit_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = Edit.ID.ToString();
            txtTenSach.Text = Edit.TENSACH;
            txtTacGia.Text = Edit.TACGIA;
            txtTheLoai.Text = Edit.ID_THELOAI.ToString();
            txtNamXuatBan.Text = Edit.NAMXUATBAN.ToString();
            txtNhaXuatBan.Text = Edit.NHAXUATBAN;
            txtTriGia.Text = Edit.TRIGIA.ToString();
            txtTrangThai.Text = Edit.TINHTRANG;
        }
    }
}
