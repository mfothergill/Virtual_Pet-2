using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication74
{
    class Virtual_Pet
    {
        //Fields
        public int hunger;
        public int thirst;
        public int boredom;
        public int weakness;

        private int age;
        private string gender;
        private string coatcolor;

        //Constructors
        public Virtual_Pet()
        {
            this.hunger = 50;
            this.thirst = 50;
            this.boredom = 50;
            this.weakness = 50;
        }
        //Properties
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
            
        }   
        public string Gender
        {
            get { return this.gender; }
            set { gender = value; }
            
            
        }
        public string Coatcolor
        {
            get { return this.coatcolor; }
            set { coatcolor = value; }
        }
           
        //Methods
      public void petFeed()
        {           
            Console.WriteLine("Widget hunger{0}",hunger += 10);
            Console.WriteLine("Widget boredom{0}",boredom -= 5);
            Console.WriteLine("Widget thirst{0}",thirst -= 5);
            Console.WriteLine("Widget weakness{0}",weakness -= 5);
            return;
        }
        public void petDrink()
        {
            Console.WriteLine("Widget thirst{0}",thirst += 10);
            Console.WriteLine("Widget weakness{0}",weakness -= 5);
            Console.WriteLine("Widget hunger {0}",hunger -= 5);
            Console.WriteLine("Widget boredom {0}",boredom -= 5);
            return;
        }
        public void petPlay()
        {
            Console.WriteLine("Widget boredom{0}",boredom+= 10);
            Console.WriteLine("Widget hunger{0}",hunger -= 5);
            Console.WriteLine("Widget thirst{0}",thirst -= 5);
            Console.WriteLine("Widget weakness{0}",weakness -= 5);
            return;
        }
        public void petTrain()
        {
            Console.WriteLine("Widget weakness{0}",weakness += 10);
            Console.WriteLine("Widget thirst{0}",thirst -= 5);
            Console.WriteLine("Widget hunger{0}",hunger -= 5);
            Console.WriteLine("Widget boredom{0}",boredom -= 5);
            
        }
        public void PetStatus()
        {
            Console.WriteLine("Widget hunger{0}", hunger);
            Console.WriteLine("Widget thirst{0}", thirst);
            Console.WriteLine("Widget boredom{0}",boredom);
            Console.WriteLine("Widget weakness{0}", weakness);
            
        }
        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Feed the Widget");
            Console.WriteLine("2.Give the Widget some liquid refreshment");
            Console.WriteLine("3. Play with the Widget");
            Console.WriteLine("4. Teach the Widget Karate");
            Console.WriteLine("5. Quit Game");
        }
        public void Statements()
        {
            if (hunger >= 30 && hunger <= 40)
            {
                Console.WriteLine("The Widget needs food-its hungry");
            }
            else if (hunger >= 15 && hunger <= 25)
            {
                Console.WriteLine("\t\t\t\t IM STARVING MAN!!! FEEED MEEEE!!!");
            }
            else if (thirst >= 30 && thirst <= 40)
            {
                Console.WriteLine("The Widget throat is a little parched");
            }
            else if (thirst >= 15 && thirst <= 25)
            {
                Console.WriteLine("\t\t\t\t COUGH! COUGH! IM THIRSTY!!");
            }
            else if(boredom >= 30 && boredom <= 40)
            {
                Console.WriteLine("Theres nothing to do man,play with me!!");
            }
            else if(boredom >= 15 && boredom <= 25)
            {
                Console.WriteLine("\t\t\t\t The Widget is devolving into an amoeba-like state");
            }   
            else if(weakness >= 30 && weakness <= 40)
            {
                Console.WriteLine("The Widget is getting picked on in deez skreetz");
            }
            else if (weakness >=15 && weakness <= 25)
            {
                Console.WriteLine("\t\t\t\t The Widget is getting robbed on a regular basis");
            }
        }
    }

       
}
