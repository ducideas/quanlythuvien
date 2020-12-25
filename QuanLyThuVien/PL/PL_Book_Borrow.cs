using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Book_Borrow : Form
    {
        private BLL_DocGia blldocgia = new BLL_DocGia();
        private BLL_Sach bllsach = new BLL_Sach();
        private BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();

        public PL_Book_Borrow()
        {
            InitializeComponent();

            capNhat_SachDtgv();
        }
        //-->
        private void capNhat_SachDtgv()
        {
            DataTable dttbsach = bllsach.laySachVaTheLoai();

            if (dttbsach != null )
            {
                foreach (DataRow row in dttbsach.Rows)
                {
                    string[] content = new string[] { row["id"].ToString(), row["TenSach"].ToString(),
                    row["TacGia"].ToString(), row["Ten"].ToString(), row["TinhTrang"].ToString() };
                    dtgvSach.Rows.Add(content);
                }

                dtgvSach.ColumnCount = 5;
                dtgvSachMuon.ColumnCount = 5;
            }
        }  

        
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if (kiemTra_DauVao(1))
            {
                try
                {
                    DataTable foundsach = bllsach.laySach(ttbMaSach.Text);

                    if (foundsach != null)
                    {
                        capNhat_SachDtgv(foundsach);
                    } 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //-->
        private void capNhat_SachDtgv(DataTable dtfoundsach)
        {
            IEnumerable<DataRow> dthang = dtfoundsach.Rows.Cast<DataRow>();
            IEnumerable<DataGridViewRow> dtgvhang = dtgvSach.Rows.Cast<DataGridViewRow>();

            int positionsach = 0;

            foreach (DataGridViewRow gvrow in dtgvhang)
            {
                gvrow.DefaultCellStyle.BackColor = Color.White;
            }

            foreach (DataRow row in dthang)
            {
                foreach (DataGridViewRow gvrow in dtgvhang)
                { 
                    if (row["id"].ToString() == gvrow.Cells[0].Value.ToString())
                    {
                        dtgvSach.Rows.Remove(gvrow);
                        dtgvSach.Rows.Insert(positionsach, gvrow);
                        dtgvSach.Rows[positionsach++].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
               
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (kiemTra_DauVao())
            {
                if(dtgvSachMuon.Rows.Count < 1)
                {
                    MessageBox.Show("Vui lòng chọn sách cần mượn");
                    return;
                }

                DTO_MUONSACH dtomuonsach = new DTO_MUONSACH() { ID_USER = Int32.Parse(ttbMaDocGia.Text) };

                List<int> lsidsachmuon = lay_MaSachMuon();
                
                try
                {
                    if (bllphieums.themPhieuMuonSach(dtomuonsach, lsidsachmuon))
                    {
                        DTO_DOCGIA dtodocgia = blldocgia.layDocGia(Int32.Parse(ttbMaDocGia.Text));
                        
                        if (dtodocgia != null)
                        {
                            ttbHoTen.Text = dtodocgia.HOVATEN;
                        }

                        ttbNgayMuon.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

                        MessageBox.Show("Lập phiếu thành công");
                    }
                    else
                    {
                        // NOT FINISHED
                        MessageBox.Show("Lập phiếu thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
        }


        //-->
        private List<int> lay_MaSachMuon()
        {
            IEnumerable<DataGridViewRow> lssachmuon = dtgvSachMuon.Rows.Cast<DataGridViewRow>();
            List<int> lsidsachmuon = new List<int>();

            foreach (DataGridViewRow sach in lssachmuon)
            {
                lsidsachmuon.Add(Int32.Parse(sach.Cells["dtgvsachmMaSach"].Value.ToString()));
            }

            return lsidsachmuon;
        }

        private void btnDichPhai_Click(object sender, EventArgs e)
        {
            IEnumerable<DataGridViewRow> selectedSach = dtgvSach.SelectedRows.Cast<DataGridViewRow>();
            int ishethang = 0;

            foreach (DataGridViewRow row in selectedSach)
            {
                if(row.Cells["dtgvsachTinhTrang"].Value.ToString() == "Con Hang")
                {
                    dtgvSach.Rows.Remove(row);
                    dtgvSachMuon.Rows.Add(row);
                }
                else
                {
                    ishethang = 1;
                }
                   
            }

            if (ishethang != 0)
            {
                MessageBox.Show("Một só sách đã hết hàng");
            }
        }

        private void btnDichTrai_Click(object sender, EventArgs e)
        {
            IEnumerable<DataGridViewRow> selectedSach = dtgvSachMuon.SelectedRows.Cast<DataGridViewRow>();

            foreach (DataGridViewRow row in selectedSach)
            {
                dtgvSachMuon.Rows.Remove(row);
                dtgvSach.Rows.Add(row);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();

            this.Hide();
            plhome.Show();
        }

        private bool kiemTra_DauVao(int ctrltinhieu = 0)
        {
            RegularExp reg = new RegularExp();

            if (ctrltinhieu == 0)
            {
                if (!reg.Is_Numbers_Only(ttbMaDocGia.Text))
                {
                    MessageBox.Show("Mã độc giả không hợp lệ");
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(ttbMaSach.Text))
                {
                    MessageBox.Show("Mã sách không hợp lệ");
                    return false;
                }
            }

            return true;
        }
    }
}
