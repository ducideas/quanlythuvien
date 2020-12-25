using System;

namespace DTO
{
    public class DTO_CHITIETMUONSACH
    {
        private int _ID;
        private int _ID_MUONSACH;
        private int _ID_SACH;
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
        public int ID_MUONSACH
        {
            get
            {
                return _ID_MUONSACH;
            }
            set
            {
                _ID_MUONSACH = value;
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
        public DTO_CHITIETMUONSACH() { }
        public DTO_CHITIETMUONSACH(int id_MuonSach, int id_Sach, DateTime created_at, DateTime updated_at)
        {
            this.ID_MUONSACH = id_MuonSach;
            this.ID_SACH = id_Sach;
            this.CREATED_AT = created_at;
            this.UPDATED_AT = updated_at;
        }
    }
}
