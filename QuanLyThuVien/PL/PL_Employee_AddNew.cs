using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Employee_AddNew : Form
    {
        private BLL_NhanVien bllnhanvien = new BLL_NhanVien();
        public delegate void CapNhat();
        public CapNhat callback;
        public PL_Employee_AddNew()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (KiemTra_DauVao())
            {
                string gioitinh, chucvu, ngayvaolam, ngaysinh;

                ngaysinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                ngayvaolam = dtpNgayVaoLam.Value.ToString("yyyy-MM-dd");
                gioitinh = cbbGioiTinh.GetItemText(cbbGioiTinh.SelectedItem);
                chucvu = cbbChucVu.GetItemText(cbbChucVu.SelectedItem);

                DTO_NHANVIEN dtonhanvien = new DTO_NHANVIEN() { USERNAME = ttbTenDN.Text, PASSWORD = ttbMatKhau.Text, 
                HOVATEN = ttbTenNV.Text, NGAYSINH = ngaysinh, DIACHI = ttbDiaChi.Text, SODT = ttbSoDT.Text, 
                GIOITINH = gioitinh, EMAIL = ttbEmail.Text, NGAYVAOLAM = ngayvaolam, CHUCVU = chucvu };

                try
                {
                    if (bllnhanvien.themNhanVien(dtonhanvien))
                    {
                        MessageBox.Show("Thêm nhân viên thành công");

                        callback();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
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
            if(!reg.Is_Address_Valid(ttbDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không hợp lệ");

                return false;
            }
            */
            if(!reg.Is_Email_Valid(ttbEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ");

                return false;
            }

            if(!reg.Is_UsernameOrPassword_Valid(ttbTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ");

                return false;
            }

            if(!reg.Is_UsernameOrPassword_Valid(ttbMatKhau.Text))
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
