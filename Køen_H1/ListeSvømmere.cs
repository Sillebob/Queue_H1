using System;
using System.Collections.Generic;
using System.Text;

namespace Køen_H1
{
    class ListeSvømmere
    {   
        // Default constructor.
        public ListeSvømmere()
        { }
       
        
        // Initialising a queue to contain the persons/Swimmers added from Main.
        Queue<Svømmer> svømmeliste = new Queue<Svømmer>();
                     
        //Metoder.

        // Method for adding a swimmer.
        public void AddSvømmer(Svømmer svømmer)
        {
          svømmeliste.Enqueue(svømmer);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{svømmer.FirstName} added to the queue");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        // Method for deleting a swimmer.
        public void DeleteSvømmer(ListeSvømmere navn)
        {
            svømmeliste.Dequeue();
        }

        // Method for showing how many swimmers there are in the queue.
        public void ShowNumberOfPersons()
        {
            int number = _=svømmeliste.Count;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Number of swimmers: {number}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #region not used code - Contains.
        //// Method that was supposed to check if a person was in the queue.
        //public void FindName(string skalFindes, ListeSvømmere kaldOp)
        //{
        //    Svømmer match = new Svømmer(skalFindes);

        //    int length = _ = svømmeliste.Count;
        //    bool contains = false;

        //    for (int i = 0; i < length; i++)
        //    {

        //        if (kaldOp.svømmeliste.Contains(match))
        //        {
        //            contains = true;
        //        }

        //    }

        //    if (contains == true)

        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }
        //}
        #endregion
        
        // Method to find next swimmer to exit the water.
        public void FindNextToGetUp()
        {
            Svømmer næsteDerSkalOp = svømmeliste.Peek();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The next to get out af the water is: {næsteDerSkalOp.FirstName}");
            Console.ForegroundColor = ConsoleColor.White;
            
        }

        // Method to print all swimmers in the queue.
        public void PrintItem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"These Swimmers are in the queue");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Svømmer svømmerNy in svømmeliste)
            {
                Console.WriteLine($"{ svømmerNy.FirstName,8}, { svømmerNy.Age,3}");
            }
        }



}




    
}

