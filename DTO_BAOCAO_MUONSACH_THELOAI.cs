using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BAOCAO_MUONSACH_THELOAI
    {
        int _ID;
        int _ID_THELOAI;
        int _THANG;
        int _SOLUOTMUON;

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
        public int ID_THELOAI
        {
            get
            {
                return _ID_THELOAI;
            }
            set
            {
                _ID_THELOAI = value;
            }
        }
        public int THANG
        {
            get
            {
                return _THANG;
            }
            set
            {
                _THANG = value;
            }
        }
        public int SOLUOTMUON
        {
            get
            {
                return _SOLUOTMUON;
            }
            set
            {
                _SOLUOTMUON = value;
            }
        }

        public DTO_BAOCAO_MUONSACH_THELOAI()
        {

        }
        
        public DTO_BAOCAO_MUONSACH_THELOAI(int id, int id_TheLoai, int Thang, int SoLuotMuon)
        {
            this.ID = id;
            this.ID_THELOAI = id_TheLoai;
            this.THANG = Thang;
            this.SOLUOTMUON = SoLuotMuon;
        }
    }
}
