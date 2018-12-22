namespace deel1._1
{
    public class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(string name1, string email1, char gender1)
        {
            name = name1;
            email = email1;
            gender = gender1;
        }

        public string getName()
        {
            return name;
        }
    }
}