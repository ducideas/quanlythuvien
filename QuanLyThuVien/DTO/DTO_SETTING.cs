namespace DTO
{
    public class DTO_SETTING
    {
        private int _ID;
        private string _NAMESETTING;
        private string _VALUESETTING;

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
        public string VALUESETTING
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
        public DTO_SETTING()
        {

        }
        public DTO_SETTING(string nameSetting, string valueSetting)
        {
            this.NAMESETTING = nameSetting;
            this.VALUESETTING = valueSetting;
        }
    }
}
