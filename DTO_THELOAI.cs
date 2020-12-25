using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_THELOAI
    {
        private int _ID;
        private string _TEN;
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
        public string TEN
        {
            get
            {
                return _TEN;
            }
            set
            {
                _TEN = value;
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
        public DTO_THELOAI() { }
        public DTO_THELOAI(int id, string Ten, DateTime created_at, DateTime updated_at) {
            this.ID = id;
            this.TEN = Ten;
            this.CREATED_AT = created_at;
            this.UPDATED_AT = updated_at;
        }
    }
}
