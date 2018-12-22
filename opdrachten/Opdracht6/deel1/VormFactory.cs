namespace opdracht6
{
    public class VormFactory 
    {
        public IVorm GetVorm(string typeVorm)
        {
            if(typeVorm == null)
            {
                return null;
            }
            else if(typeVorm.Equals("cirkel"))
            {
                return new Crikel();
            }
            return null;
        }
    }
}