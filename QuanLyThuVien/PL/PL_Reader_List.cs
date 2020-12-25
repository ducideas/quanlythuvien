using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace PL
{
    public partial class PL_Reader_List : Form
    {
        BLL_DocGia blldocgia = new BLL_DocGia();
        private PL_Reader_AddNew AddNewForm;
        private PL_Reader_Edit EditForm;

        public PL_Reader_List()
        {
            InitializeComponent();
        }

        private void PL_Reader_List_Load_By_Search()
        {
            datagridDanhSachDocGia.DataSource = blldocgia.timDocGia(ttbSearchDocGia.Text);
        }
        private void PL_Reader_List_Load()
        {
            datagridDanhSachDocGia.DataSource = blldocgia.layDocGia();
        }
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            AddNewForm = new PL_Reader_AddNew();
            AddNewForm.TestDelegate = TestListen;
            AddNewForm.Show();
        }

        private void btnSuaDocGia_Click(object sender, EventArgs e)
        {

            if (datagridDanhSachDocGia.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagridDanhSachDocGia.SelectedRows[0];

                // Tạo DTo
                DTO_DOCGIA user = new DTO_DOCGIA(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), int.Parse(row.Cells[9].Value.ToString())); // Vì ID tự tăng nên để ID số gì cũng dc

                EditForm = new PL_Reader_Edit(user);
                EditForm.EditDelegate = TestListen;
                EditForm.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn độc giả muốn sửa");
            }
        }
        private void TestListen(string param)
        {
            // update DB 
            datagridDanhSachDocGia.DataSource = blldocgia.layDocGia(); // refresh datagridview
            var x = param;
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (datagridDanhSachDocGia.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = datagridDanhSachDocGia.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (blldocgia.xoaDocGia(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    datagridDanhSachDocGia.DataSource = blldocgia.layDocGia(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn độc giả muốn xóa");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();
            this.Close();
            plhome.Show();
        }

        private void ttbSearchDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PL_Reader_List_Load_By_Search();
        }

        private void PL_Reader_List_Load(object sender, EventArgs e)
        {
            datagridDanhSachDocGia.DataSource = blldocgia.layDocGia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL_Reader_List_Load();
        }

        private void ttbTimKiem_Click(object sender, EventArgs e)
        {
            ttbSearchDocGia.Clear();
        }
    }
}
