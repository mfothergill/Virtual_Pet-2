using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication74
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Hello! welcome to the game called: Raise the Widget.\n Please enter the desired age, gender,and coatcolor you would like for your cat...");
            // Calling Properties
            Console.WriteLine("Please enter the age (a number between 1 and 12) first.");
            
            Virtual_Pet pet = new Virtual_Pet();
            
            pet.Age = int.Parse(Console.ReadLine());
          
           
            
            Console.WriteLine("Very good.Now enter the desired gender.");

            
            pet.Gender = Console.ReadLine();

            Console.WriteLine("Thank you.Now please the deisred coat color.");

            pet.Coatcolor = Console.ReadLine();

            //Displaying results of user choices
            Console.WriteLine("Very good! your cat is: {0}", pet.Age);
            Console.WriteLine("The gender is: {0}", pet.Gender);
            Console.WriteLine("The coat is: {0}", pet.Coatcolor);

            Console.WriteLine("Ok,weve determined what the Widget looks like.Now you must raise it.Good luck!");
            //actual game code
            

           

            

            pet.PetStatus();
            Console.WriteLine();
            Console.WriteLine();
            pet.DisplayMenu();
            Console.WriteLine("\n Please enter a number");
            bool keepGoing = true;
            while(keepGoing == true)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        pet.petFeed();
                        pet.Statements();
                        pet.DisplayMenu();
                        break;
                    case 2:
                        pet.petDrink();
                        pet.Statements();
                        pet.DisplayMenu();
                        break;
                    case 3:
                        pet.petPlay();
                        pet.Statements();
                        pet.DisplayMenu();
                        break;
                    case 4:
                        pet.petTrain();
                        pet.Statements();
                        pet.DisplayMenu();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for playing!");
                        keepGoing = false;
                        break;
                }

            }
            
            

        }
    }
}
