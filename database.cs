using System.Globalization;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static string name;
        static string choice;
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("1- Add a user");
            Console.WriteLine("2- Delete a user");
            Console.WriteLine("3- Edit a user");
            Console.WriteLine("4- exit");
            Console.WriteLine("what is your choice");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            int outputInt = 0;
            bool quit = false;
            bool choice1= false;

            

            

            while (!quit)
            {
                string choice = Console.ReadLine();
                int.TryParse(choice, out outputInt);
                Console.WriteLine("input: " + choice);


                switch (outputInt)
                {
                    case 0:
                        Console.WriteLine("choose somthing from the list");
                        break;
                    case 1:
                        //gebruiker toevoegen
                        Person client= new Person();
                        Console.WriteLine("type your name");
                        string nieuweIntput= Console.ReadLine();
                        Console.WriteLine(" this was typt "+ nieuweIntput);
                        client.name = nieuweIntput;
                        Console.WriteLine("type your surname");
                        string nieuweIntputint= Console.ReadLine();
                        Console.WriteLine("this was typt " +  nieuweIntput);
                        client.surname = nieuweIntput;
                        Console.WriteLine("type your adres");
                        string nieuwIntput= Console.ReadLine();
                        Console.WriteLine("this was typt " + nieuweIntput);
                        client.adres = nieuweIntput;
                        Console.WriteLine("type your phone number");
                        nieuweIntput = Console.ReadLine();
                        int outputint=0;
                        int.TryParse(nieuwIntput, out outputInt);
                        Console.WriteLine("this was typt "+outputint );
                        client.phoneNummber = outputInt;

                        Console.WriteLine("data saved");

                        break;
                    case 2:
                        //gebruiker verwijderen
                        break;
                    case 3:
                        //Gebruiker bewerken
                        break;
                    case 4:
                        //exit application
                        quit = true;
                        break;
                    default:
                        //hier komt alle andere input die we niet hebben afgevangen in de cases
                        Console.WriteLine("wrong please choose one one option on the screen");
                        break;
                
                }
            }    
        }
    }
}

    
   