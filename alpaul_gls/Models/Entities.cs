

public class Entities
{
    public class Properties
    {
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string SERVER_NAME { get; set; }
        public string DATABASE { get; set; }
        public string CONNECTION_STRING { get; set; }
        public bool AUTHENTICATION { get; set; }
        public string DOWNLOABLE_NAME { get; set; }
    }

    public class Table
    {
        public bool PROCESS { get; set; }
        public string TABLE_CATALOG { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_TYPE { get; set; }
        public string NAME
        {
            get
            {
                string _name = string.Format("{0}.{1}", TABLE_SCHEMA, TABLE_NAME);
                _name = (_name.Length >= 30) ? _name.Substring(0, 30) + "..." : _name;
                return _name;
            }
        }
    }

    public class Fields
    {
        public string TABLE_CATALOG { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public string TABLE_NAME { get; set; }
        public int ORDINAL_POSITION { get; set; }
        public string COLUMN_NAME { get; set; }
        public string DATA_TYPE { get; set; }
        public string IS_NULLABLE { get; set; }
        public int CHARACTER_MAXIMUM_LENGTH { get; set; }
        public string CONSTRAINT_TYPE { get; set; }
        public int KEY_CODE { get; set; }
        public string CONSTRAINT_NAME { get; set; }
        public string COLUMN_DEFAULT { get; set; }
        public string TABLE_NAME_RELATIONSHIP { get; set; }
        public string CLASS_TYPE { get; set; }
    }
}
