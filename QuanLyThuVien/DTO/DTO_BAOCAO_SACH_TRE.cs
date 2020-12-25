namespace DTO
{
    public class DTO_BAOCAO_SACH_TRE
    {
        private int _ID;
        private int _ID_SACH;
        private string _NGAY;
        
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
        public string NGAY
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
        public DTO_BAOCAO_SACH_TRE(string Ngay)
        {
            this.NGAY = Ngay;
        }
    }
}
