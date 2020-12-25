using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Home : Form
    {
        public PL_Home()
        {
            InitializeComponent();
        }

        private void picQuanLyDocGia_Click(object sender, EventArgs e)
        {
            PL_Reader_List Reader = new PL_Reader_List();
            this.Close();
            Reader.Show();
        }

        
        private void picDangXuat_Click(object sender, EventArgs e)
        {
            PL_Login Login = new PL_Login();
            Login.Show();
            this.Hide();
        }

        private void picQuanLySach_Click(object sender, EventArgs e)
        {
            PL_Book_List Book = new PL_Book_List();
            this.Close();
            Book.Show();
        }

        private void picBaoCao_Click(object sender, EventArgs e)
        {
            PL_Report Report = new PL_Report();
            this.Close();
            Report.Show();
        }

        private void picThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            PL_Setting Setting = new PL_Setting();
            Setting.Show();
        }


        private void picMuonSach_Click(object sender, EventArgs e)
        {
            PL_Book_Borrow plbookborrow = new PL_Book_Borrow();
            this.Hide();
            plbookborrow.Show();
        }

        private void picTraSach_Click(object sender, EventArgs e)
        {
            PL_Book_Return plbookreturn = new PL_Book_Return();
            this.Hide();
            plbookreturn.Show();
        }

        private void EmployeeIcon_Click(object sender, EventArgs e)
        {
            PL_Employee plemployee = new PL_Employee();
            this.Hide();
            plemployee.Show();
        }
    } 
}
