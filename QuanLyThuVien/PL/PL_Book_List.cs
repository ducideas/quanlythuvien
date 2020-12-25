using System;
using System.Windows.Forms;
using DTO;
using BLL;


namespace PL
{
    public partial class PL_Book_List : Form
    {
        BLL_Sach bllsach = new BLL_Sach();
        public PL_Book_List()
        {
            InitializeComponent();
        }

        private void PL_Book_List_Load(object sender, EventArgs e)
        {
            datagridDanhSachSach.DataSource = bllsach.laySach();
        }
        private void PL_Book_List_Load_By_Search()
        {
            datagridDanhSachSach.DataSource = bllsach.timSach(txtTimSach.Text);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            PL_Book_AddNew AddNewForm = new PL_Book_AddNew();
            AddNewForm.TestDelegate = TestListen;
            AddNewForm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (datagridDanhSachSach.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagridDanhSachSach.SelectedRows[0];

                // Tạo DTo
                DTO_SACH book = new DTO_SACH(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString()
                                            , row.Cells[2].Value.ToString(), int.Parse(row.Cells[3].Value.ToString())
                                            , int.Parse(row.Cells[4].Value.ToString()), row.Cells[5].Value.ToString()
                                            , int.Parse(row.Cells[6].Value.ToString()), row.Cells[7].Value.ToString()
                                            , int.Parse(row.Cells[8].Value.ToString())); // Vì ID tự tăng nên để ID số gì cũng dc
                PL_Book_Edit EditForm = new PL_Book_Edit(book);
                EditForm.EditDelegate = TestListen;
                EditForm.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn sách muốn sửa");
            }
        }
        private void TestListen(string param)
        {
            // update DB 
            datagridDanhSachSach.DataSource = bllsach.laySach(); // refresh datagridview
            var x = param;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (datagridDanhSachSach.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagridDanhSachSach.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (bllsach.xoaSach(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    datagridDanhSachSach.DataSource = bllsach.laySach(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn sách muốn xóa");
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();
            this.Close();
            plhome.Show();
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            PL_Book_List_Load_By_Search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridDanhSachSach.DataSource = bllsach.laySach();
        }

        private void ttbTimKiem_Click(object sender, EventArgs e)
        {
            txtTimSach.Clear();
        }
    }
}
