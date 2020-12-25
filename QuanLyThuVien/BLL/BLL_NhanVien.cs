using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien dalnhanvien = new DAL_NhanVien();

        public string dangNhap(string username, string pass)
        {
            return dalnhanvien.layMaNhanVien(username, pass);
        }

        public bool themNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            return dalnhanvien.themNhanVien(dtonhanvien);
        }

        public bool suaNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            return dalnhanvien.suaNhanVien(dtonhanvien);
        }

        public bool xoaNhanVien(int idnhanvien)
        {
            return dalnhanvien.xoaNhanVien(idnhanvien);
        }

        public DTO_NHANVIEN layNhanVien(int idnhanvien)
        {
            return dalnhanvien.layNhanVien(idnhanvien);
        }

        public DataTable layNhanVien()
        {
            return dalnhanvien.layNhanVien();
        }
    }
}
