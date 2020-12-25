using System;

namespace DTO
{
    public class DTO_TRASACH
    {
        private int _ID;
        private int _ID_USER;
        private string _NGAYTRA;
        private int _SONGAYTRE;
        private int _TIENTRE;
        private int _TIENBOITHUONG;
        private int _TIENTHUESACH;
        private int _TONGTIEN;
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
        public int SONGAYTRE
        {
            get
            {
                return _SONGAYTRE;
            }
            set
            {
                _SONGAYTRE = value;
            }
        }
        public int TIENTRE
        {
            get
            {
                return _TIENTRE;
            }
            set
            {
                _TIENTRE = value;
            }
        }
        public int TIENBOITHUONG
        {
            get
            {
                return _TIENBOITHUONG;
            }
            set
            {
                _TIENBOITHUONG = value;
            }
        }
        public int TIENTHUESACH
        {
            get
            {
                return _TIENTHUESACH;
            }
            set
            {
                _TIENTHUESACH = value;
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
        public DTO_TRASACH() { }
        public DTO_TRASACH(int id, int id_user, string NgayTra, int SoNgayTre, int TienTre, int TienBoiThuong, int TienThueSach, int TongTien, DateTime created_at, DateTime updated_at)
        {
            this.ID = id;
            this.ID_USER = id_user;
            this.NGAYTRA = NgayTra;
            this.SONGAYTRE = SoNgayTre;
            this.TIENTRE = TienTre;
            this._TIENBOITHUONG = TienBoiThuong;
            this.TIENTHUESACH = TienThueSach;
            this.TONGTIEN = TongTien;
        }
    }
}
