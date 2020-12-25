using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Book_Return : Form
    {
        private BLL_DocGia blldocgia = new BLL_DocGia();
        private BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();
        private BLL_PhieuTraSach bllphieuts = new BLL_PhieuTraSach();

        public PL_Book_Return()
        {
            InitializeComponent();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (kiemTra_DauVao(1))
            {
                try
                {
                    DataTable dtsachm = bllphieums.laySachMuon(Int32.Parse(ttbMaDocGia.Text));

                    dtgvSachMuon.Rows.Clear();
                    dtgvSachMuon.Refresh();
                    capNhat_SachMuonDtgv(dtsachm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void capNhat_SachMuonDtgv(DataTable dtsachmuon)
        {
            IEnumerable<DataRow> drsachmuon = dtsachmuon.Rows.Cast<DataRow>();

            foreach (DataRow row in drsachmuon)
            {
                string[] content = new string[] { row["id"].ToString(), row["TenSach"].ToString(),
                    row["TacGia"].ToString(), row["Ten"].ToString(), row["TinhTrang"].ToString(), 
                    row["TriGia"].ToString(), row["NhaXuatBan"].ToString(), row["NamXuatBan"].ToString() };

                dtgvSachMuon.Rows.Add(content);
            }
            dtgvSachMuon.ColumnCount = 8;
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (!(kiemTra_DauVao() && kiemTra_TinhHopLe()))
            {
                return;
            }

            IEnumerable<DataGridViewRow> selectedSach = dtgvSachMuon.SelectedRows.Cast<DataGridViewRow>();

            if (tra_Sach() != null)
            {
                foreach (DataGridViewRow row in selectedSach)
                {
                    dtgvSachMuon.Rows.Remove(row);
                }
            }
            else 
            {
                MessageBox.Show("Tra sach that bai");
            }

        }

        public DTO_TRASACH tra_Sach(int ctrltinhieu = 0)
        {

            DTO_TRASACH dtots = new DTO_TRASACH() { ID_USER = Int32.Parse(ttbMaDocGia.Text), TIENBOITHUONG = Int32.Parse(ttbSachHong.Text) };

            List<int> lsidsach = lay_DanhSachMaSachTra();

            try
            {
                if (bllphieuts.themPhieuTraSach(ref dtots, lsidsach, ctrltinhieu))
                {
                    dtgvSachMuon.Refresh();

                    DTO_DOCGIA dtodocgia = blldocgia.layDocGia(Int32.Parse(ttbMaDocGia.Text));

                    if (dtodocgia != null)
                    {
                        ttbTenDocGia.Text = dtodocgia.HOVATEN;
                    }

                    ttbNgayTra.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

                    return dtots;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        private List<int> lay_DanhSachMaSachTra()
        {
            IEnumerable<DataGridViewRow> selectedSach = dtgvSachMuon.SelectedRows.Cast<DataGridViewRow>();
            List<int> lsidsach = new List<int>();

            foreach (DataGridViewRow row in selectedSach)
            {
                lsidsach.Add(Int32.Parse(row.Cells[0].Value.ToString()));
            }

            return lsidsach;
        }

        private void btnLapPhieuThuTP_Click(object sender, EventArgs e)
        {
            if (!(kiemTra_DauVao() && kiemTra_TinhHopLe()))
            {
                return;
            }

            try
            {
                DTO_TRASACH dtots = tra_Sach(1);

                if (dtots != null)
                {
                    PL_Payment plpayment = new PL_Payment(dtots);

                    plpayment.Show();
                }
                else
                {
                    MessageBox.Show("Lap Phieu Thu Tien That Bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvSachMuon_SelectionChanged(object sender, EventArgs e)
        {
            if ( dtgvSachMuon.SelectedRows.Count < 1 )
                return;
        
            DataGridViewRow sltHang = null;
            DTO_CHITIETMUONSACH dtoctms = null;
            DateTime datemuonsach;

            try 
            { 
                sltHang = dtgvSachMuon.SelectedRows[0];

                dtoctms = bllphieums.layCTMuonSach_ChuaTra(
                    Int32.Parse(ttbMaDocGia.Text), Int32.Parse(sltHang.Cells[0].Value.ToString()));
                
                if (dtoctms != null)
                {
                    datemuonsach = dtoctms.CREATED_AT;

                    ttbNgayMuon.Clear();
                    ttbNgayMuon.Refresh();
                    ttbNgayMuon.Text = datemuonsach.Date.ToString("dd/MM/yyyy");

                    ttbSoNgayTT.Clear();
                    ttbSoNgayTT.Refresh();
                    ttbSoNgayTT.Text = DateTime.Now.Subtract(datemuonsach).Days.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            if (!reg.Is_Numbers_Only(ttbMaDocGia.Text))
            {
                MessageBox.Show("Mã Độc giả không hợp lệ");

                return false;
            }

            if (ctrltinhieu == 1)
            {
                return true;
            }


            if(!reg.Is_Numbers_Only(ttbSachHong.Text))
            {
                MessageBox.Show("Xin nhập lại số sách hỏng");

                return false;
            }

            return true;
        }

        private bool kiemTra_TinhHopLe()
        {
            if (dtgvSachMuon.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng");

                return false;
            }

            if (dtgvSachMuon.SelectedRows.Count < Int32.Parse(ttbSachHong.Text))
            {
                MessageBox.Show("Số sách hỏng phải nhỏ hơn hoặc bằng số sách được chọn");

                return false;
            }

            return true;
        }
    }
}
