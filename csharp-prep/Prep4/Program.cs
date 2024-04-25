using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int current_number=1;
        List<int> numbers_list = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(current_number!=0){
            Console.Write("Enter a number: ");
            current_number=int.Parse(Console.ReadLine());
            numbers_list.Add(current_number);
        }


        int sum=0;
        foreach(int number in numbers_list){
            sum+=number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers_list.Count;
        Console.WriteLine($"The average is {average}");

        int max=numbers_list[0];

        foreach (int number in numbers_list)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");


    }
}