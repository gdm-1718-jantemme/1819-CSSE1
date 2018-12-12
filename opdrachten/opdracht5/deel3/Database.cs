namespace deel3
{
    public class Database
    {
        private static Database _instance;

        private Database()
        {

        }

        public static Database Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new Database();

                return _instance;
            }
        }

        public string Name { get; set; }
    }
}