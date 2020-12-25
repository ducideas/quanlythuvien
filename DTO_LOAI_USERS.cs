using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOAI_USERS
    {
        private int _ID;
        private string _TENLOAI;

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
        public string TENLOAI
        {
            get
            {
                return _TENLOAI;
            }
            set
            {
                _TENLOAI = value;
            }
        }
        public DTO_LOAI_USERS() { }
        public DTO_LOAI_USERS(int id, string TenLoai)
        {
            this.ID = id;
            this.TENLOAI = TenLoai;
        }
    }
}
