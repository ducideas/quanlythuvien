using System;
using System.Windows.Forms;
using BLL;

namespace PL
{
    public partial class PL_Login : Form
    {
        public static string ID_USER = "";
        public static string HoVaTenUser = "";
        BLL_NhanVien bllEmployee = new BLL_NhanVien();
        public PL_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dang_Nhap();
        }

        private void ttbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dang_Nhap();
            }
        }

        private void ttbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dang_Nhap();
            }
        }

        private void dang_Nhap()
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (bllEmployee.dangNhap(txtUsername.Text, txtPassword.Text) != "")
                {
                    PL_Home plHome = new PL_Home();
                    plHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoảng và mật khẩu không đúng !");

                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
