namespace DTO
{
    public class DTO_BAOCAO_MUONSACH_THELOAI
    {
        private int _ID;
        private int _ID_THELOAI;
        private int _THANG;
        private int _SOLUOTMUON;

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
        
        public DTO_BAOCAO_MUONSACH_THELOAI(int Thang)
        {
            this.THANG = Thang;
        }
    }
}
