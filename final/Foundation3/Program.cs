using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("101 E Viking St", "Rexburg", "ID", "USA");
        Address address2 = new Address("299 Jet Stream Dr", "Rexburg", "ID", "USA");
        Address address3 = new Address("1000 7th E", "Rexburg", "ID", "USA");

        Lecture lecture = new Lecture("Class", "C# Crash Course", "05/29/24", address2, "Chad Macbeth", 50);
        Reception reception = new Reception("Wedding", "Tuft 1 year wedding anniversary", "09/23/2024", address3, "tuft.jordan@gmail.com");
        Outdoor outdoor = new Outdoor("Water Fight", "Water gun fight at the park", "08/10/2024", address1, "Sunny");

        //lecture
        lecture.StandardDetails();
        Console.WriteLine("\n--------------------------\n");

        lecture.FullDetails();
        Console.WriteLine("\n--------------------------\n");

        lecture.ShortDescription();
        Console.WriteLine("\n--------------------------\n");

        //reception
        reception.StandardDetails();
        Console.WriteLine("\n--------------------------\n");

        reception.FullDetails();
        Console.WriteLine("\n--------------------------\n");

        reception.ShortDescription();
        Console.WriteLine("\n--------------------------\n");

        //outdoor
        outdoor.StandardDetails();
        Console.WriteLine("\n--------------------------\n");

        outdoor.FullDetails();
        Console.WriteLine("\n--------------------------\n");

        outdoor.ShortDescription();
        Console.WriteLine("\n--------------------------\n");

        
    }
}