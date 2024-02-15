using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    
    public int GetScore()
    {       
        return _score;
    }

    public void CalculateScore()
    {
    
        int totalPoints = 0;
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                totalPoints += goal.GetPoint();
            }
        }
        Console.WriteLine($"You now have {_score} points");
        Console.WriteLine();
        
    }


    public void Start()
    {

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {GetScore()} points");
            Console.WriteLine();
            // Display menu options

            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goal");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            // Get user input
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Perform action based on user input
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }

 
    public void ListGoalName()
    {
                
        for (int index = 0; index < GetGoals().Count; index++)
        {   
            Console.WriteLine($"{index+1}. {GetGoals()[index]}");
        }

    }

    public void ListGoalDetails()
    {
            Console.WriteLine();
            Console.WriteLine("Your current list of goals are:\n");

            for (int i = 0; i < GetGoals().Count; i++ )
            {
                if (GetGoals()[i].IsComplete())
                {
                    Console.WriteLine($"{i + 1}. [X] {GetGoals()[i].GetDetailsString()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {GetGoals()[i].GetDetailsString()}");
                }
            }

                
    }

    public void CreateGoal()
    {
        
            Console.WriteLine();
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal.");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Habit Goal");
            Console.WriteLine("Which type of goal would like to create? ");
            Console.WriteLine();

            int goalChoice = int.Parse(Console.ReadLine());

            switch(goalChoice)
            {
                case 1:
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is the short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("what is the amount of point associated with this goal? ");
                int point = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal1 = new SimpleGoal(name, description, point);
                GetGoals().Add(simpleGoal1);

                break;

                case 2:
                Console.Write("What is the name of your goal? ");
                string names = Console.ReadLine();
                Console.Write("What is the short description of your goal? ");
                string descriptions = Console.ReadLine();
                Console.Write("what is the amount of point associated with this goal? ");
                int pointz = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(names, descriptions, pointz);
                GetGoals().Add(eternalGoal);

                break;

                case 3:
                Console.Write("What is the name of your goal? ");
                string namec = Console.ReadLine();
                Console.Write("What is the short description of your goal? ");
                string descriptionc = Console.ReadLine();
                Console.Write("what is the amount of point associated with this goal? ");
                int pointc = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                CheckListGoal checkListGoal = new CheckListGoal(namec, descriptionc, pointc, bonus, target);
                GetGoals().Add(checkListGoal);

                break;

                case 4:
                Console.Write("What is that habit you want to start as a goal? ");
                string nameh = Console.ReadLine();
                Console.Write("What is the short description of your goal? ");
                string descriptionh = Console.ReadLine();
                Console.Write("what is the amount of point associated with this goal? ");
                int pointh = int.Parse(Console.ReadLine());

                HabitGoal habitGoal = new HabitGoal(nameh, descriptionh, pointh);
                GetGoals().Add(habitGoal);

                break;
            }        
            Console.WriteLine();
    }

    public void RecordEvent()
    {
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Which goal have you completed?");
        
        foreach (Goal goal in GetGoals())
        {
            Console.WriteLine($"{GetGoals().IndexOf(goal)}. {goal.GetShortName()}");
        }
        
        int selectedGoalIndex;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Enter the index of the completed goal: ");
            if (int.TryParse(Console.ReadLine(), out selectedGoalIndex) &&
                selectedGoalIndex >= 0 && selectedGoalIndex < GetGoals().Count)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
        Goal selectedGoal = GetGoals()[selectedGoalIndex];
        selectedGoal.RecordEvent();
        _score += selectedGoal.GetPoint();

        CalculateScore();
        Console.WriteLine();

    }



    public void SaveGoals()
    {
        

        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {

            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

    }


    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if (System.IO.File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                // Deserialize the specific goal type based on the goalType
                switch (parts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        _goals.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        _goals.Add(eternalGoal);
                        break;

                    case "CheckListGoal":
                        CheckListGoal checklistGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        _goals.Add(checklistGoal);
                        break;

                    case "HabitGoal":
                        HabitGoal habitGoal = new HabitGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        _goals.Add(habitGoal);
                        break;

                }
            }

            Console.WriteLine();
            Console.WriteLine("The loaded goals: ");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{_goals.IndexOf(goal)}. {goal.GetDetailsString()}");
            }
            GetGoals();
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine($"'{fileName}' file does not exist!!");
        }

            
        }
}