using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MUONSACH
    {
        private int _ID;
        private int _ID_USER;
        private string _NGAYMUON;
        private string _NGAYTRA;
        private int _TONGTIEN;
        private int _TRANGTHAI;
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
        public int ID_USER
        {
            get
            {
                return _ID_USER;
            }
            set
            {
                _ID_USER = value;
            }
        }
        public string NGAYMUON
        {
            get
            {
                return _NGAYMUON;
            }
            set
            {
                _NGAYMUON = value;
            }
        }
        public string NGAYTRA
        {
            get
            {
                return _NGAYTRA;
            }
            set
            {
                _NGAYTRA = value;
            }
        }
        public int TONGTIEN
        {
            get
            {
                return _TONGTIEN;
            }
            set
            {
                _TONGTIEN = value;
            }
        }
        public int TRANGTHAI
        {
            get
            {
                return _TRANGTHAI;
            }
            set
            {
                _TRANGTHAI = value;
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
        public DTO_MUONSACH()
        {

        }
        public DTO_MUONSACH(int id, int id_user, string NgayMuon, string NgayTra, int TongTien, int TrangThai, DateTime created_at, DateTime updated_at)
        {
            this.ID = id;
            this.ID_USER = id_user;
            this.NGAYMUON = NgayMuon;
            this.NGAYTRA = NgayTra;
            this.TONGTIEN = TongTien;
            this.TRANGTHAI = TrangThai;
            this.CREATED_AT = created_at;
            this.UPDATED_AT = updated_at;
        }
    }
}
