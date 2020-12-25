using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NHANVIEN
    {
        private int _ID;
        private string _USERNAME;
        private string _PASSWORD;
        private string _HOVATEN;
        private string _GIOITINH;
        private string _SODT;
        private string _NGAYSINH;
        private string _DIACHI;
        private string _EMAIL;
        private string _NGAYVAOLAM;
        private string _CHUCVU;

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
        public string USERNAME
        {
            get
            {
                return _USERNAME;
            }
            set
            {
                _USERNAME = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return _PASSWORD;
            }
            set
            {
                _PASSWORD = value;
            }
        }
        public string HOVATEN
        {
            get
            {
                return _HOVATEN;
            }
            set
            {
                _HOVATEN = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return _GIOITINH;
            }
            set
            {
                _GIOITINH = value;
            }
        }
        public string SODT
        {
            get
            {
                return _SODT;
            }
            set
            {
                _SODT = value;
            }
        }
        public string NGAYSINH
        {
            get
            {
                return _NGAYSINH;
            }
            set
            {
                _NGAYSINH = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }
            set
            {
                _DIACHI = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return _EMAIL;
            }
            set
            {
                _EMAIL = value;
            }
        }
        public string NGAYVAOLAM
        {
            get
            {
                return _NGAYVAOLAM;
            }
            set
            {
                _NGAYVAOLAM = value;
            }
        }
        public string CHUCVU
        {
            get
            {
                return _CHUCVU;
            }
            set
            {
                _CHUCVU = value;
            }
        }

        public DTO_NHANVIEN() { }
        public DTO_NHANVIEN(int id, string username, string password, string hovaten, string gioitinh, string sodt, string ngaysinh, string diachi, string email, string ngayvaolam, string chucvu)
        {
            this.ID = id;
            this.USERNAME = username;
            this.PASSWORD = password;
            this.HOVATEN = hovaten;
            this.GIOITINH = gioitinh;
            this.SODT = sodt;
            this.NGAYSINH = ngaysinh;
            this.DIACHI = diachi;
            this.EMAIL = email;
            this.NGAYVAOLAM = ngayvaolam;
            this.CHUCVU = chucvu;
        }
    }
}
