using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Report_ReturnBookLate : Form
    {
        BLL_BaoCao bllBaoCao = new BLL_BaoCao();
        public PL_Report_ReturnBookLate()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string dateString = dateTimePicker.Value.ToString("yyyy-MM-dd");
            if (dateString != "")
            {
                DTO_BAOCAO_SACH_TRE dtoBaoCao = new DTO_BAOCAO_SACH_TRE(dateString);
                dataGridViewBorrowBookReport.DataSource = bllBaoCao.layBaoCaoTraSachTre(dateString);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
