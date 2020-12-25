using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Employee : Form
    {
        private BLL_NhanVien bllnhanvien = new BLL_NhanVien();

        public PL_Employee()
        {
            InitializeComponent();

            capNhat_MaNhanVienDtgv();
        }

        private void capNhat_MaNhanVienDtgv()
        {
            dtgvDSMaNV.Rows.Clear();
            dtgvDSMaNV.Refresh();

            DataTable dttbnhanvien = bllnhanvien.layNhanVien();

            foreach(DataRow row in dttbnhanvien.Rows)
            {
                dtgvDSMaNV.Rows.Add(row["id"]);
            }
            dtgvDSMaNV.ColumnCount = 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PL_Employee_AddNew pled = new PL_Employee_AddNew();
            pled.callback = capNhat_MaNhanVienDtgv;
            pled.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idhangcanxoa = 0, idnhanvien = 0; 

            idhangcanxoa = dtgvDSMaNV.SelectedRows[0].Index;
            idnhanvien = Int32.Parse(dtgvDSMaNV.Rows[idhangcanxoa].Cells["dtgvcMaNV"].Value.ToString());

            PL_Employee_Edit pled = new PL_Employee_Edit(idnhanvien);
            pled.callback = capNhat_MaNhanVienDtgv;
            pled.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idhangcanxoa = 0, idnhanvien = 0; 

            idhangcanxoa = dtgvDSMaNV.SelectedRows[0].Index;
            idnhanvien = Int32.Parse(dtgvDSMaNV.Rows[idhangcanxoa].Cells["dtgvcMaNV"].Value.ToString());

            try
            {
                if (bllnhanvien.xoaNhanVien(idnhanvien))
                {
                    capNhat_MaNhanVienDtgv();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvDSMaNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDSMaNV.SelectedRows.Count > 0)
            {
                int idhang = 0, idnhanvien = 0;

                idhang = dtgvDSMaNV.SelectedRows[0].Index;
                idnhanvien = Int32.Parse(dtgvDSMaNV.Rows[idhang].Cells["dtgvcMaNV"].Value.ToString());

                try
                {
                    DTO_NHANVIEN dtonhanvien = bllnhanvien.layNhanVien(idnhanvien);

                    ttbTenNV.Text = dtonhanvien.HOVATEN;
                    ttbGioiTinh.Text = dtonhanvien.GIOITINH;
                    ttbNgaySinh.Text = dtonhanvien.NGAYSINH;
                    ttbEmail.Text = dtonhanvien.EMAIL;
                    ttbSoDT.Text = dtonhanvien.SODT;
                    ttbDiaChi.Text = dtonhanvien.DIACHI;
                    ttbChucVu.Text = dtonhanvien.CHUCVU;
                    ttbNgayVaoLam.Text = dtonhanvien.NGAYVAOLAM;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();

            this.Hide();
            plhome.Show();
        }
    }
}
