namespace DTO
{
    public class DTO_NHAP
    {
        private int _ID;
        private int _ID_SACH;
        private int _SOLUONGNHAP;
        private string _NGAYNHAP;

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
        public int SOLUONGNHAP
        {
            get
            {
                return _SOLUONGNHAP;
            }
            set
            {
                _SOLUONGNHAP = value;
            }
        }
        public string NGAYNHAP
        {
            get
            {
                return _NGAYNHAP;
            }
            set
            {
                _NGAYNHAP = value;
            }
        }
        public DTO_NHAP() { }
        public DTO_NHAP(int id, int id_Sach, int SoLuongNhap, string NgayNhap)
        {
            this.ID = id;
            this.ID_SACH = id_Sach;
            this.SOLUONGNHAP = SoLuongNhap;
            this.NGAYNHAP = NgayNhap;
        }
    }
}
