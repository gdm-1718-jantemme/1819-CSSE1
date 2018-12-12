namespace deel2
{
    public class Gebruiker 
    {

        protected string wachtwoord;

        public string GebruikersNaam
        {
            get;
            set;
        }

        public virtual string GenereerWachtwoord()
        {
            return "wachtwoord";
        }

        public Gebruiker()
        {
            this.wachtwoord = GenereerWachtwoord();
        }

    }
}