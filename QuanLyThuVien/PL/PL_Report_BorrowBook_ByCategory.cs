using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Report_BorrowBook_ByCategory : Form
    {
        BLL_BaoCao bllBaoCao = new BLL_BaoCao();
        public PL_Report_BorrowBook_ByCategory()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (cbbThang.Text!="")
            {
                int thang = Int16.Parse(cbbThang.Text);
                DTO_BAOCAO_MUONSACH_THELOAI dtoBaoCao = new DTO_BAOCAO_MUONSACH_THELOAI(thang);
                dataGridViewBorrowBookReport.DataSource=bllBaoCao.layBaoCaoMuonSachTheLoai(dtoBaoCao.THANG);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng để xem báo cáo!", "Thông báo");
            }    
        }
    }
}
