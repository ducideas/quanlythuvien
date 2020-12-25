using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SETTING
    {
        private int _ID;
        private string _NAMESETTING;
        private int _VALUESETTING;
        private string _DESCRIPTIONSETTING;

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
        public string NAMESETTING
        {
            get
            {
                return _NAMESETTING;
            }
            set
            {
                _NAMESETTING = value;
            }
        }
        public int VALUESETTING
        {
            get
            {
                return _VALUESETTING;
            }
            set
            {
                _VALUESETTING = value;
            }
        }

        public string DESCRIPTIONSETTING
        {
            get
            {
                return _DESCRIPTIONSETTING;
            }
            set
            {
                _DESCRIPTIONSETTING = value;
            }
        }

        public DTO_SETTING()
        {

        }
        public DTO_SETTING(int id, string nameSetting, int valueSetting, string descriptionsetting)
        {
            this.ID = id;
            this.NAMESETTING = nameSetting;
            this.VALUESETTING = valueSetting;
            this.DESCRIPTIONSETTING = descriptionsetting;
        }
    }
}
