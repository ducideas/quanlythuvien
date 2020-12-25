using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DOCGIA
    {
        private int _ID;
        private string _HOVATEN;
        private string _GIOITINH;
        private string _SODT;
        private string _LOAIDOCGIA;
        private string _NGAYSINH;
        private string _DIACHI;
        private string _EMAIL;
        private string _NGAYLAPTHE;
        private int _TONGNO;

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
        public string HOVATEN
        {
            get
            {
                return _HOVATEN;
            }
            set
            {
                _HOVATEN = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return _GIOITINH;
            }
            set
            {
                _GIOITINH = value;
            }
        }
        public string SODT
        {
            get
            {
                return _SODT;
            }
            set
            {
                _SODT = value;
            }
        }
        public string LOAIDOCGIA
        {
            get
            {
                return _LOAIDOCGIA;
            }
            set
            {
                _LOAIDOCGIA = value;
            }
        }
        public string NGAYSINH
        {
            get
            {
                return _NGAYSINH;
            }
            set
            {
                _NGAYSINH = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }
            set
            {
                _DIACHI = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return _EMAIL;
            }
            set
            {
                _EMAIL = value;
            }
        }
        public string NGAYLAPTHE
        {
            get
            {
                return _NGAYLAPTHE;
            }
            set
            {
                _NGAYLAPTHE = value;
            }
        }
        public int TONGNO
        {
            get
            {
                return _TONGNO;
            }
            set
            {
                _TONGNO = value;
            }
        }
        public DTO_DOCGIA() { }
        public DTO_DOCGIA(int id, string HoVaTen, string GioiTinh, string SoDT, string LoaiDocGia, string NgaySinh, string DiaChi, string Email, string NgayLapThe, int TongNo)
        {
            this.ID = id;
            this.HOVATEN = HoVaTen;
            this.GIOITINH = GioiTinh;
            this.SODT = SoDT;
            this.LOAIDOCGIA = LoaiDocGia;
            this.NGAYSINH = NgaySinh;
            this.DIACHI = DiaChi;
            this.EMAIL = Email;
            this.NGAYLAPTHE = NgayLapThe;
            this.TONGNO = TongNo;
        }
    }
}
