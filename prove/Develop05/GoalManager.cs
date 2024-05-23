public class GoalManager
{
    protected List <Goal> _goals = new List<Goal>();
    protected List <string> _ranks = new List<string>
    {"Noob", "Novice Goalsetter", "Goalkeeper Certified", "Acomplished Goalsetter", "Legendary Goalsetter", "Mythic Goalsetter", "Grand Master Goal Legend"

    };
    protected int _score;
   

public GoalManager()
{


}
public void Start()
{
     
  
        var choice="";
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice =Console.ReadLine();

            if(choice=="1")
            {
                CreateGoal();
            }
            else if(choice=="2")
            {
                ListGoalDetails();

            }
            else if(choice=="3")
            {
               SaveGoals();
                
            }
            else if(choice=="4")
            {
                LoadGoals();
            }
            else if(choice == "5")
            {
                RecordEvent();
            }
            else if(choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
        while(choice!="6");  
}
public void DisplayPlayerInfo()
{
    int level = _score / 1000;
    string rank = _ranks[_score/1000];

    Console.WriteLine($"You have {_score} points");
    Console.WriteLine($"Level: {level} {rank}");
    Console.WriteLine($"Next level: {_score % 1000}/{1000}");
    
}
public void ListGoalNames()
{
    int count = 1;

    foreach (Goal goal in _goals)
    {
        Console.WriteLine($"{count}. {goal.GetName()}");
        count++;
    }

}
public void ListGoalDetails()
{
    int count = 1;
    foreach(Goal goal in _goals)
    {
        
        Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        count++;
    }
}
public void CreateGoal()
{
    var goalChoice="";

    do{
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");

    Console.Write("Which type of goal would you like to create?");
    goalChoice=Console.ReadLine();

    string name="";
    string description="";
    string points="";
    int target=0;
    int bonus=0;

    if (goalChoice == "1")
        {
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with this goal?");
            points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);

                        
            break;
        }
        else if (goalChoice == "2")
        {
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);

            break;
        }
        else if (goalChoice == "3")
        {
            Console.WriteLine("What is the name of your goal?");
            name = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with this goal?");
            points = Console.ReadLine();

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);

            break;
        }

        } while (goalChoice != "4");
                
}
public void RecordEvent()
{
    int choice=0;

    Console.WriteLine("The goals are: ");
    ListGoalNames();
    Console.WriteLine("Which goal did you accomplish? ");

    choice=int.Parse(Console.ReadLine()) - 1;

    _goals[choice].RecordEvent();
   
    _score+= int.Parse(_goals[choice].GetPoints());

    Console.WriteLine($"Congratulations! You have earned {_goals[choice].GetPoints()} points!");
    Console.WriteLine($"You now have {_score} points.");
    Console.WriteLine("");
    

    
}
public void SaveGoals()
{
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(filename))
    {
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            if(goal.IsComplete()==true)
            {
                writer.WriteLine(goal.GetStringRepresentation());  
            }
            else
            {
            writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
}
public void LoadGoals()
{
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    _goals.Clear();

    using (StreamReader reader = new StreamReader(filename))
    {
        _score = int.Parse(reader.ReadLine());
        string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts[0]=="SimpleGoal" && bool.Parse(parts[4]))
                {
                    SimpleGoal goal = new SimpleGoal(parts[1], parts[2], parts[3], true);
                    _goals.Add(goal);
                }
                else if(parts[0]=="SimpleGoal" && !bool.Parse(parts[4]))
                {
                    SimpleGoal goal = new SimpleGoal(parts[1], parts[2], parts[3], false);
                    _goals.Add(goal);
                }
                else if(parts[0]=="EternalGoal")
                {
                    EternalGoal goal = new EternalGoal(parts[1], parts[2], parts[3]);
                    _goals.Add(goal);
                }
                else if(parts[0]=="ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]),int.Parse(parts[6]));
                    _goals.Add(goal);
                }
                
                
            }
    }


}

    


}