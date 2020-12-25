using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Report : Form
    {
        PL_Report_BorrowBook_ByCategory plReportBorrowBook;
        PL_Report_ReturnBookLate plReportReturnBookLate;
        public PL_Report()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();
            this.Close();
            plhome.Show();
        }

        private void BorrowBookReportIcon_Click(object sender, EventArgs e)
        {
            plReportBorrowBook = new PL_Report_BorrowBook_ByCategory();
            plReportBorrowBook.Show();
        }

        private void ReturnBookReportIcon_Click(object sender, EventArgs e)
        {

            plReportReturnBookLate = new PL_Report_ReturnBookLate();
            plReportReturnBookLate.Show();
        }
    }
}
