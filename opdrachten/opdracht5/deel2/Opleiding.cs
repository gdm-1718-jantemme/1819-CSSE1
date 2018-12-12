namespace deel2
{
    public class Opleiding : IInformatie
    {
        private string afkortingCampus;
        protected int campusNummer;

        public string Campus
        {
            get;
            set;
        }

        public string Opleidingsnaam
        {
            get;
            set;
        }

        string GetWifiCode() 
        {
            return "code";
        }

        public Opleiding()
        {
            this.afkortingCampus = this.Campus.Substring(0,3);
        }

        public string ToString()
        {
            return string.Format("Campus {0}", this.Campus);
        }
    }
}