using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_PhieuTraSach
    {
        private DAL_PhieuTraSach dalphieuts = new DAL_PhieuTraSach();

        public bool themPhieuTraSach(ref DTO_TRASACH dtots, List<int> lsmasach, int ctrltinhieu)
        {
            BLL_Sach bllsach = new BLL_Sach();
            BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();
            int idtrasach = 0, numsachhong = dtots.TIENBOITHUONG;

            khoiTao_DoiTuongTraSach(ref dtots);

            foreach (int idsach in lsmasach)
            {
                int ishong = (numsachhong-- > 0 ? 1 : 0);
                tra_TungSach(ref dtots, idsach, ishong);
            }

            if(ctrltinhieu == 1)
            {
                return true;
            }

            idtrasach = dalphieuts.themPhieuTraSach(dtots);

            if (idtrasach > -1)
            {
                foreach (int idsach in lsmasach)
                {
                    themCTP_TraSach(idtrasach, idsach);
                    bllsach.suaTinhTrangSach(idsach, "Con Hang");
                    bllphieums.suaCTP_MuonSach(dtots.ID_USER, idsach);
                }

                bllphieums.tongKet_MuonSach(dtots.ID_USER);

                return true;
            }
            
            return false;
        }

        public void khoiTao_DoiTuongTraSach(ref DTO_TRASACH dtots)
        {
            dtots.NGAYTRA = DateTime.Today.Date.ToString("yyyy-MM-dd");
            dtots.CREATED_AT = DateTime.Now;
            dtots.SONGAYTRE = 0;
            dtots.TIENTRE = 0;
            dtots.TIENBOITHUONG = 0;
            dtots.TIENTHUESACH = 0;
            dtots.TONGTIEN = 0;
        }

        public void tra_TungSach(ref DTO_TRASACH dtots, int idsach, int ishong)
        {
            BLL_Sach bllsach = new BLL_Sach();
            BLL_QuyDinh bllquydinh = new BLL_QuyDinh();
            BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();

            DTO_CHITIETMUONSACH dtoctms = null;
            DateTime datemuonsach;
            int numngaytratre = 0, maxngaytra = 0, paymtratre = 0, feethuesach = 0, paymboithuong = 0;
            
            try
            {
                dtoctms = bllphieums.layCTMuonSach_ChuaTra(dtots.ID_USER, idsach);
                datemuonsach = dtoctms.CREATED_AT;

               
                maxngaytra = bllquydinh.layQuyDinh("So Ngay Muon Toi Da"); // 3 
                paymtratre = bllquydinh.layQuyDinh("Tien Phat"); // 1
                feethuesach = bllquydinh.layQuyDinh("Tien Muon Sach"); // 2
                paymboithuong = bllquydinh.layQuyDinh("Tien Boi Thuong"); // 4

                numngaytratre = DateTime.Now.Subtract(datemuonsach).Days - maxngaytra;
                numngaytratre = (numngaytratre > 0 ? numngaytratre : 0);

                dtots.SONGAYTRE += numngaytratre;
                dtots.TIENTRE += numngaytratre * paymtratre;
                dtots.TIENBOITHUONG +=  ishong * paymboithuong; 
                dtots.TIENTHUESACH += feethuesach;
                dtots.TONGTIEN = dtots.TIENTRE + dtots.TIENBOITHUONG + dtots.TIENTHUESACH;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool themCTP_TraSach(int idtrasach, int idsach)
        {
            DTO_CHITIETTRASACH dtoctts = new DTO_CHITIETTRASACH() { ID_TRASACH = idtrasach, ID_SACH = idsach, CREATED_AT = DateTime.Now };

            return dalphieuts.themCTP_TraSach(dtoctts);
        }
    }
}
