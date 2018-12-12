namespace deel2
{
    public class Persoon : Gebruiker
    {
        private string naam;
        private string voornaam;

        public string Naam
        {
            get
            {
                return this.naam;
            }
            set
            {
                this.naam = value;
            }
        }

         public string Voornaam
        {
            get
            {
                return this.voornaam;
            }
            set
            {
                this.voornaam = value;
            }
        }

        public string VolledigeNaam
        {
            get
            {
                return naam + " " + voornaam;
            }
        } 

        public override string GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }
    }
}