using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Sach
    {
        DAL_Sach dalsach = new DAL_Sach();

        public DataTable laySach()//
        {
            return dalsach.laySach();
        }
        public bool xoaSach(int Sach_ID)
        {
            return dalsach.xoaSach(Sach_ID);
        }
        public bool themSach(DTO_SACH book)
        {
            return dalsach.themSach(book);
        }
        public bool suaSach(DTO_SACH book)
        {
            return dalsach.suaSach(book);
        }

        public bool suaTinhTrangSach(int idsach, string statussach)
        {
            return dalsach.suaTinhTrangSach(idsach, statussach);
        }

        public DataTable laySachVaTheLoai()//
        {
            return dalsach.laySachVaTheLoai();
        }

        public DataTable laySach(string infosach)
        {
            return dalsach.laySach(infosach);
        }
        public DataTable timSach(String ThongTinSach)
        {
            return dalsach.timSach(ThongTinSach);
        }
    }
}