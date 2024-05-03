using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
    
        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string _choice = Console.ReadLine();

                if (_choice == "1")
                {
                    Entry newEntry = new Entry();
                    PromptGenerator promptGenerator = new PromptGenerator();

                    DateTime _currentTime = DateTime.Now;
                

                    newEntry._date=_currentTime.ToShortDateString();
                    newEntry._promptText=promptGenerator.GetRandomPrompt();


                    Console.WriteLine(newEntry._promptText);
                    Console.Write(">");

                    newEntry._entryText=Console.ReadLine();

                    myJournal.AddEntry(newEntry);
                }
                else if (_choice=="2")
                {
                    myJournal.DisplayAll();
                }
                else if (_choice=="3")
                {
                    Console.WriteLine("Name?");
                    string file=Console.ReadLine();
                    
            
                    myJournal.LoadFromFile(file);

                    Console.WriteLine("Loaded!");
                }
                else if (_choice=="4")
                {
                    Console.WriteLine("Name?");
                    string file=Console.ReadLine();
                    
                    myJournal.SaveToFile(file);
                    Console.WriteLine("Saved!");
                }
                else if (_choice=="5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Please input a number between 1 and 5");
                }










        }
    
                
                
               
    }
}
                
           