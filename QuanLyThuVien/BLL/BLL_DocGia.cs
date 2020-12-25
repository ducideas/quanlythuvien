using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_DocGia
    {
        DAL_DocGia daldocgia = new DAL_DocGia();

        public DataTable layDocGia()
        {
            return daldocgia.layDocGia();
        }

        public bool xoaDocGia(int DocGia_ID)
        {
            return daldocgia.xoaDocGia(DocGia_ID);
        }

        public bool themDocGia(DTO_DOCGIA user)
        {
            return daldocgia.themDocGia(user);
        }

        public bool suaDocGia(DTO_DOCGIA user)
        {
            return daldocgia.suaDocGia(user);
        }

        public DTO_DOCGIA layDocGia(int iddocgia)
        {
            return daldocgia.layDocGia(iddocgia);
        }
        public DataTable timDocGia(string ThongTinDocGia)
        {
            return daldocgia.timDocGia(ThongTinDocGia);
        }
    }
}