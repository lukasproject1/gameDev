namespace overErven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people= new List<Person>();
         Person lukas= new Person();
            lukas.Name = "lukas";
            people.Add(lukas);
            Employe ik = new Employe();
            ik.Name = "luuk";

            ik.Words();
            people.Add(ik);
        }
    }
}