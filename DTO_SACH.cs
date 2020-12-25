using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SACH
    {
        private int _ID;
        private string _TENSACH;
        private string _TACGIA;
        private int _ID_THELOAI;
        private int _NAMXUATBAN;
        private string _NHAXUATBAN;
        private int _TRIGIA;
        private string _TINHTRANG;
        private int _SOLUONG;
        private DateTime _CREATED_AT;
        private DateTime _UPDATED_AT;

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
        public string TENSACH
        {
            get
            {
                return _TENSACH;
            }
            set
            {
                _TENSACH = value;
            }
        }
        public string TACGIA
        {
            get
            {
                return _TACGIA;
            }
            set
            {
                _TACGIA = value;
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
        public int NAMXUATBAN
        {
            get
            {
                return _NAMXUATBAN;
            }
            set
            {
                _NAMXUATBAN = value;
            }
        }
        public string NHAXUATBAN
        {
            get
            {
                return _NHAXUATBAN;
            }
            set
            {
                _NHAXUATBAN = value;
            }
        }
        public int TRIGIA
        {
            get
            {
                return _TRIGIA;
            }
            set
            {
                _TRIGIA = value;
            }
        }
        public string TINHTRANG
        {
            get
            {
                return _TINHTRANG;
            }
            set
            {
                _TINHTRANG = value;
            }
        }
        public int SOLUONG
        {
            get
            {
                return _SOLUONG;
            }
            set
            {
                _SOLUONG = value;
            }
        }
        public DateTime CREATED_AT
        {
            get
            {
                return _CREATED_AT;
            }
            set
            {
                _CREATED_AT = value;
            }
        }
        public DateTime UPDATED_AT
        {
            get
            {
                return _UPDATED_AT;
            }
            set
            {
                _UPDATED_AT = value;
            }
        }
        public DTO_SACH() { }
        public DTO_SACH(int id, string TenSach, string TacGia, int id_TheLoai, int NamXuatBan, string NhaXuatBan, int TriGia, string TinhTrang, int SoLuong, DateTime created_at, DateTime updated_at)
        {
            this.ID = id;
            this.TENSACH = TenSach;
            this.TACGIA = TacGia;
            this.ID_THELOAI = id_TheLoai;
            this.NAMXUATBAN = NamXuatBan;
            this.NHAXUATBAN = NhaXuatBan;
            this.TRIGIA = TriGia;
            this.TINHTRANG = TinhTrang;
            this.SOLUONG = SoLuong;
            this.CREATED_AT = created_at;
            this.UPDATED_AT = updated_at;

        }
    }
}
