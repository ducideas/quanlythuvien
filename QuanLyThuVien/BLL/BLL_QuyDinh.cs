using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_QuyDinh
    {
        DAL_QuyDinh dalquydinh = new DAL_QuyDinh();
        public DataTable layQuyDinh()
        {
            return dalquydinh.layQuyDinh();
        }
        public bool themQuyDinh(DTO_SETTING dtoSetting)
        {
            return dalquydinh.themSetting(dtoSetting);
        }
        public bool xoaQuyDinh(int IdSetting)
        {
            return dalquydinh.xoaQuyDinh(IdSetting);
        }
        public bool suaQuyDinh(DTO_SETTING dtoSetting)
        {
            return dalquydinh.suaQuyDinh(dtoSetting);
        }

        public int layQuyDinh(string namequydinh)
        {
            return dalquydinh.layQuyDinh(namequydinh);
        }

    }
}
