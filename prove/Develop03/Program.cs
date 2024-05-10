using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(_reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths. " );
        bool enterPressed = false;
        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

        while(!scripture.IsCompletelyHidden())
        {
            string userInput = Console.ReadLine().ToLower();
            if(userInput=="quit")
            {
                break;
            }

            if(!enterPressed)
            {
                
                enterPressed=true;
            }

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");


            if(keyPressed.Key==ConsoleKey.Enter)
            {
                scripture.HideRandomWords(2);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            }

            
            

            

            
        }
        
        
        
       /* while(true)
        {
            Console.WriteLine(scripture.GetDisplayText());


            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {
                scripture.HideRandomWords(2);
                Console.WriteLine(scripture.GetDisplayText());
             }

        }
        */

      //  Console.WriteLine(scripture.GetDisplayText());
      //  scripture.HideRandomWords(2);
       // Console.WriteLine(scripture.GetDisplayText());
        

    }
}