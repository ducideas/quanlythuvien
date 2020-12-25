using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Setting_Edit : Form
    {
        BLL_QuyDinh bllSetting = new BLL_QuyDinh();
        public delegate void DeLe(string param);
        public DeLe EditDelegate;
        private DTO_SETTING Edit;
        public PL_Setting_Edit(DTO_SETTING setting)
        {
            InitializeComponent();
            Edit = setting;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNameSetting.Text != "" && txtValueSetting.Text != "")
            {

                // Tạo DTo
                DTO_SETTING setting = new DTO_SETTING () { ID = Int32.Parse(txtId.Text),
                    NAMESETTING = txtNameSetting.Text,  VALUESETTING = txtValueSetting.Text };
                // Them
                if (bllSetting.suaQuyDinh(setting))
                {
                    MessageBox.Show("Sửa thành công");
                    this.EditDelegate.Invoke("OK");
                    this.Close();
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

        private void PL_Setting_Edit_Load(object sender, EventArgs e)
        {
            txtId.Text = Edit.ID.ToString();
            txtNameSetting.Text = Edit.NAMESETTING.ToString();
            txtValueSetting.Text = Edit.VALUESETTING.ToString();
        }
    }
}
