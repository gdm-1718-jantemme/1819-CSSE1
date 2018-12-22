
namespace deel2
{
    class Latte : IBuilder

    {
        private Koffie _koffie = new Koffie();
    
        public void AddIngredients()
        {
        _koffie.Add("1/2 koffie");
        _koffie.Add("1/2 melk");
        _koffie.Add("melkschuim");
        }
    
        public void MaakKoffie()
        {
        _koffie.Show();
        }
    }
}