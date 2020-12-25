using DTO;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Payment : Form
    {
        public PL_Payment()
        {
            InitializeComponent();
        }

        public PL_Payment(DTO_TRASACH dtots)
        {
            InitializeComponent();

            ttbPhiThue.Text = dtots.TIENTHUESACH.ToString();
            ttbTienPhat.Text = dtots.TIENTRE.ToString();
            ttbTienBoiThuong.Text = dtots.TIENBOITHUONG.ToString();

            ttbTongTien.Text = dtots.TONGTIEN.ToString();
        }

        

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();

            this.Hide();
        }
    }
}
