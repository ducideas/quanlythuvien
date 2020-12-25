using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Employee_Edit : Form
    {
        private BLL_NhanVien bllnhanvien = new BLL_NhanVien();
        public delegate void CapNhat();
        public CapNhat callback;
        private int idnhanvien;

        public PL_Employee_Edit()
        {
            InitializeComponent();
        }

        public PL_Employee_Edit(int idnhanvien) ///
        {
            InitializeComponent();
            capNhat_DauVao(idnhanvien);
        }
           
        private void capNhat_DauVao(int idnhanvien)
        {
            DTO_NHANVIEN dtonhanvien = bllnhanvien.layNhanVien(idnhanvien);

            this.idnhanvien = idnhanvien;

            ttbTenNV.Text = dtonhanvien.HOVATEN;
            dtpNgaySinh.Text = dtonhanvien.NGAYSINH.ToString();
            ttbDiaChi.Text = dtonhanvien.DIACHI;
            ttbSoDT.Text = dtonhanvien.SODT;
            ttbEmail.Text = dtonhanvien.EMAIL;
            dtpNgayVaoLam.Text = dtonhanvien.NGAYVAOLAM.ToString();
            ttbMatKhau.Text = dtonhanvien.PASSWORD;
        }
        
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (KiemTra_DauVao())
            {
                string ngaysinh, ngayvaolam, chucvu, gioitinh;

                ngaysinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                ngayvaolam = dtpNgayVaoLam.Value.ToString("yyyy-MM-dd");
                gioitinh = cbbGioiTinh.GetItemText(cbbGioiTinh.SelectedItem);
                chucvu = cbbChucVu.GetItemText(cbbChucVu.SelectedItem);

                DTO_NHANVIEN dtonhanvien = new DTO_NHANVIEN() { ID = this.idnhanvien, HOVATEN = ttbTenNV.Text, GIOITINH = gioitinh, 
                NGAYSINH = ngaysinh, SODT = ttbSoDT.Text, EMAIL = ttbEmail.Text, DIACHI = ttbDiaChi.Text,
                NGAYVAOLAM = ngayvaolam, CHUCVU = chucvu, PASSWORD = ttbMatKhau.Text };

                try
                {
                    if (bllnhanvien.suaNhanVien(dtonhanvien))
                    {
                        MessageBox.Show("Thay đổi thông tin thành công");

                        callback();
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thông tin thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool KiemTra_DauVao()
        {
            RegularExp reg = new RegularExp();

            if (!reg.Is_WhiteSpaceAndLetters_Only(ttbTenNV.Text) && !reg.Is_Letter_Only(ttbTenNV.Text))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ");

                return false;
            }

            if (!reg.Is_Numbers_Only(ttbSoDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ không hợp lệ");

                return false;
            }
            /*
            if (!reg.Is_Address_Valid(ttbDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không hợp lệ");

                return false;
            }
            */
            if (!reg.Is_Email_Valid(ttbEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ");

                return false;
            }

            if (!reg.Is_UsernameOrPassword_Valid(ttbMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không hợp lệ");

                return false;
            }

            if (cbbChucVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");

                return false;
            }

            if (cbbGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính");

                return false;
            }
            
            if (string.IsNullOrEmpty(ttbDiaChi.Text))
            {
                MessageBox.Show("Vui lòng thêm vào địa chỉ");

                return false;
            }



            return true;
        }
    }
}
