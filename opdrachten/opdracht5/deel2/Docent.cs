namespace deel2{
    public class Docent : Persoon 
    {
        public string Emailadres
        {
            get;
            set;
        }

        public Opleiding Opleiding
        {
            get;
            set;
        }

        public int GenereerWachtwoord()
        {
            return 12345;
        }
    }
}