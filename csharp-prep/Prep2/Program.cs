using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response=Console.ReadLine();
        int percentage=int.Parse(response);
        string letter="";

        if(percentage>=90){
           letter="A" ;
        }
        else if(percentage>=80){
           letter="B" ;
        }
        else if(percentage>=70){
           letter="C" ;
        }
        else if (percentage>=60){
           letter="D" ;
        }
        else{
           letter="F" ;
        }

        if(letter=="A" || letter=="F"){
        Console.Write($"Your grade is an {letter}. ");
        }
        else{
            Console.Write($"Your grade is a {letter}. ");
        }

        if(percentage>=70){
            Console.Write("Congrats! You passed!");
        }
        else{
            Console.Write("Better luck next time!");
        }
        
    }
}