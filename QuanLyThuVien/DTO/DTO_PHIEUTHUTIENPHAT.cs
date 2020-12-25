namespace DTO
{
    public class DTO_PHIEUTHUTIENPHAT
    {
        private int _ID;
        private int _ID_USER;
        private int _SOTIENTHU;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID=value;
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
        public int SOTIENTHU
        {
            get
            {
                return _SOTIENTHU;
            }
            set
            {
                _SOTIENTHU = value;
            }
        }
        public DTO_PHIEUTHUTIENPHAT() { }
        public DTO_PHIEUTHUTIENPHAT(int id, int id_user, int SoTienThu)
        {
            this.ID = id;
            this.ID_USER = id_user;
            this.SOTIENTHU = SoTienThu;
        }
    }
}
