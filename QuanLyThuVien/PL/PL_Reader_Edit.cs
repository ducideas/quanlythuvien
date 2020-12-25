using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace PL
{
    public partial class PL_Reader_Edit : Form
    {
        BLL_DocGia blldocgia = new BLL_DocGia();
        public delegate void DeLe(string param);
        public DeLe EditDelegate;
        private DTO_DOCGIA Edit;
        public PL_Reader_Edit(DTO_DOCGIA user)
        {

            InitializeComponent();
            Edit = user;
        }


        private void Form_Load(object sender, EventArgs e)
        {
            // Chuyển giá trị lên form
            txtMaDocGia.Text = Edit.ID.ToString();
            txtHoVaTen.Text = Edit.HOVATEN;
            txtDiaChi.Text = Edit.DIACHI;
            txtSoDT.Text = Edit.SODT;
            dtNgaySinh.Value = Convert.ToDateTime(Edit.NGAYSINH);
            txtLoaiDocGia.Text = Edit.LOAIDOCGIA;
            dtNgayLapThe.Value = Convert.ToDateTime(Edit.NGAYLAPTHE);
            txtEmail.Text = Edit.EMAIL;
            if (Edit.GIOITINH == "Nam")
                radioNam.Checked = true;
            else
                radioNu.Checked = true;
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text != "" && txtHoVaTen.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "")
            {
                string sex;
                if (radioNam.Checked == true)
                    sex = "Nam";
                else
                    sex = "Nu";
                // Tạo DTo
                DTO_DOCGIA user = new DTO_DOCGIA(int.Parse(txtMaDocGia.Text), txtHoVaTen.Text, sex, txtSoDT.Text, txtLoaiDocGia.Text, dtNgaySinh.Value.ToString("yyyy-MM-dd"), txtDiaChi.Text, txtEmail.Text, dtNgayLapThe.Value.ToString("yyyy-MM-dd"), 0);
                // Them
                if (blldocgia.suaDocGia(user))
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
    }
}
