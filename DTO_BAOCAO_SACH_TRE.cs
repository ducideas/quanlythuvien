using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BAOCAO_SACH_TRE
    {
        private int _ID;
        private int _ID_SACH;
        private int _NGAY;
        
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        public int ID_SACH
        {
            get
            {
                return _ID_SACH;
            }
            set
            {
                _ID_SACH = value;
            }
        }
        public int NGAY
        {
            get
            {
                return _NGAY;
            }
            set
            {
                _NGAY = value;
            }
        }
        public DTO_BAOCAO_SACH_TRE()
        {

        }
        public DTO_BAOCAO_SACH_TRE(int id, int id_sach, int Ngay)
        {
            this.ID = id;
            this.ID_SACH = id_sach;
            this.NGAY = Ngay;
        }
    }
}
