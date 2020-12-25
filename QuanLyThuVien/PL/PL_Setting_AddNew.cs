using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Setting_AddNew : Form
    {
        BLL_QuyDinh bllquydinh = new BLL_QuyDinh();
        public delegate void Test(string param);
        public Test TestDelegate;
        public PL_Setting_AddNew()
        {
            InitializeComponent();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (txtNameSetting.Text!="" && txtValueSetting.Text!="")
            {
                // Tạo DTo
                DTO_SETTING dtoSetting = new DTO_SETTING(txtNameSetting.Text, txtValueSetting.Text);
                // Them
                if (bllquydinh.themQuyDinh(dtoSetting))
                {
                    MessageBox.Show("Thêm thành công");
                    this.TestDelegate.Invoke("OK");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại");
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
