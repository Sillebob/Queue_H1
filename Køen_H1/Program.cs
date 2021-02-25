using System;
using System.Collections.Generic;


namespace Køen_H1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string answer;
            
            ListeSvømmere kaldOp = new ListeSvømmere();
            
            do
            {
                Console.Clear(); 
                Console.WriteLine("==================================================");
                Console.WriteLine();
                Console.WriteLine("H1 Queue Operations Menu");
                Console.WriteLine();
                Console.WriteLine("==================================================");
                
                // Printing the Menu.
                GetMenu(); 

                // Declaring a variabel to hold the number the switch checks.
                int caseSwitch = GetAnswer("Enter your choice");
                

                #region Switch statements
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("First name");
                        string firstName = Console.ReadLine();
                        int age = GetAnswer("Age");
                        Svømmer ankommet = new Svømmer(firstName, age);

                        // Calling the Method from the Class Listesvømmere
                        kaldOp.AddSvømmer(ankommet);

                        break;

                    case 2:
                        
                        kaldOp.DeleteSvømmer(kaldOp);
                        break;

                    case 3:
                        kaldOp.ShowNumberOfPersons();
                        break;

                    case 4:
                        kaldOp.FindNextToGetUp();
                        break;

                    case 5:
                        kaldOp.PrintItem();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Ugyldig indtastning");
                        break;
                }
                #endregion
                Console.WriteLine();
                Console.WriteLine("Back to the menu (y/n)");
                answer = Console.ReadLine().ToLower();

            } while (answer == "y");

        }
        // Method for printing the menu.
        public static void GetMenu()
        {
            Console.WriteLine("1. Add a svimmer\n2. Delete a svimmer\n3. Show the number of svimmers\n4. Find next svimmer to exit" +
                "\n5. Print all svimmers\n6. Exit\n");
            
        }
        // Method for getting the users input and checkint if it is an integer.
        public static int GetAnswer(string question)
        {
            Console.WriteLine(question);
            int output;//Erklærer en variabel der skal bruges til at indeholde brugerens svar
            while (!int.TryParse(Console.ReadLine(), out output))/*Brugerens indtastning gemmes i output og 
                                                                 * der testes for om der er indtastet et heltal.
                                                                 * whileløkken kører indtil det er et tal der er indtastet*/
            {
                Console.WriteLine("Invalid input, try again");
            }
            return output;
        }
        
       
      
       
       
    }

}