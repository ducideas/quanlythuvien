using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BLL_PhieuMuonSach
    {
        private DAL_PhieuMuonSach dalphieums = new DAL_PhieuMuonSach();

        public bool themPhieuMuonSach(DTO_MUONSACH dtoms, List<int> lsmasach)
        {
            BLL_Sach bllsach = new BLL_Sach();
            BLL_QuyDinh bllquydinh = new BLL_QuyDinh();
            int idmuonsach = 0, maxsongaymuon = 0, totalphims = 0, feemuonsach = 0;

            maxsongaymuon = bllquydinh.layQuyDinh("So Ngay Muon Toi Da"); // 3
            feemuonsach = bllquydinh.layQuyDinh("Tien Muon Sach"); // 2

            foreach (int idsach in lsmasach)
            {
                totalphims += feemuonsach;
            }

            dtoms.NGAYMUON = DateTime.Today.Date.ToString("yyyy-MM-dd");
            dtoms.NGAYTRA = DateTime.Today.AddDays(maxsongaymuon).Date.ToString("yyyy-MM-dd");
            dtoms.TONGTIEN = totalphims;
            dtoms.TRANGTHAI = 0; 
            dtoms.CREATED_AT = DateTime.Now;

            idmuonsach = dalphieums.themPhieuMuonSach(dtoms);


            if (idmuonsach > -1)
            {
                foreach (int idsach in lsmasach)
                {
                    themCTP_MuonSach(idmuonsach, idsach);
                    bllsach.suaTinhTrangSach(idsach, "Het Hang");
                }

                return true;
            }

            return false;
        }

        public bool themCTP_MuonSach(int idmuonsach, int idsach)
        {
            DTO_CHITIETMUONSACH dtoctms = new DTO_CHITIETMUONSACH() { ID_MUONSACH = idmuonsach, ID_SACH = idsach, CREATED_AT = DateTime.Now};

            return dalphieums.themCTP_MuonSach(dtoctms);
        }

        public bool suaCTP_MuonSach(int iddocgia, int idsach)
        {
            DTO_CHITIETMUONSACH dtoctms = new DTO_CHITIETMUONSACH() { ID_SACH = idsach, UPDATED_AT = DateTime.Now };

            return dalphieums.suaCTP_MuonSach(iddocgia, dtoctms);

        }

        public bool tongKet_MuonSach(int iddocgia)
        {
            return dalphieums.tongKet_MuonSach(iddocgia);
        }

        public DTO_CHITIETMUONSACH layCTMuonSach_ChuaTra(int iddocgia, int idsach)
        {
            return dalphieums.lay_CTMuonSach_ChuaTra(iddocgia, idsach);
        }

        public DataTable laySachMuon(int iddocgia)
        {
            return dalphieums.laySachMuon(iddocgia);
        }
    }
}
