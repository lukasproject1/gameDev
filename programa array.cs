using System.Drawing;

namespace eerstec_Project
{
    internal class Program
    {
     
      static string achterNaam = "wirht";
      static  string no = "16";
      static  double lengte = 1.79 ;
      static  string naam = ("Lukas");
      static  char lukas = 'L';
      static int cijfer = 2;
      static int cijfers = 3;
      static int antwoord = 0;
      static int gewoon = 4;
      static int op = 3;
      

        static void Main(string[] args)
        {
            int leeftijd = 16;
            Console.WriteLine(naam+" "+achterNaam);
            Console.WriteLine(lengte+" m");
            Console.WriteLine(no+" jaar");
            
            antwoord = cijfer + cijfers;
            Console.WriteLine(antwoord);
            string kopper = "jo";

            List<Clas1>peopList= new List<Clas1>(); 

            Clas1 lukas = new Clas1();
            lukas.name = "lukas";
            lukas.age = 16;
            lukas.length = 1.79f;

            peopList.Add(lukas);

            Clas1 andereNaam = new Clas1();
            andereNaam.name= "liem";
            andereNaam.age = 17;
            andereNaam.length = 1.67f;
             
            

            peopList.Add(andereNaam);

            for (int i = 0; i < peopList.Count; i++)
            {

             Console.WriteLine(peopList[i].name);
            }

           

            Console.WriteLine(" the name = "+lukas.name+" the age = "+lukas.age+" the length = "+ lukas.length );
            Console.WriteLine(" the name = " + andereNaam.name + " the age = " + andereNaam.age + " the length = " + andereNaam.length);




        }
      
    }
}









