using System;

class Program
{
    //Showing creativity and exceeding requirements
    //I implemented a feature where no question is repeated under the Reflecting Activity until they have all been cycled through
    //I did this using a duplicate list of remaining questions and removing the current question from the list until they are all gone. Once the list is empty, it is refilled as it was before.
    static void Main(string[] args)
    {
        var choice="";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice =Console.ReadLine();

            if(choice=="1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                
            }
            else if(choice=="2")
            {
                ReflectingActivity reflectionActivity = new ReflectingActivity();
                reflectionActivity.Run();

            }
            else if(choice=="3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                
            }
            else if(choice=="4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
        while(choice!="4");
    }
}