using System;

namespace DTO
{
    public class DTO_CHITIETTRASACH
    {
        private int _ID;
        private int _ID_TRASACH;
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
        public int ID_TRASACH
        {
            get
            {
                return _ID_TRASACH;
            }
            set
            {
                _ID_TRASACH = value;
            }
        }
        public int ID_SACH
        {
            get
            {
                return _ID_TRASACH;
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
        public DTO_CHITIETTRASACH() { }
        public DTO_CHITIETTRASACH(int id_TraSach, int id_Sach, DateTime created_at, DateTime updated_at)
        {
            this.ID_TRASACH = id_TraSach;
            this.ID_SACH = id_Sach;
            this.CREATED_AT = created_at;
            this.UPDATED_AT = updated_at;
        }
    }
}
