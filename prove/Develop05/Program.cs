using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Exceeding Requirements
        //Level system is implemented with names for each rank. Each 1000 points earned takes you to the next level
        //rank and title is displated next to your score count
        
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}