using System.Runtime.InteropServices;
using System.IO; 

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        // Add all goals from text file into list here
    }

    public void Start()
    {
        int userAnswer = 0;
        Console.WriteLine("Welcome to goal logging!");

        while (userAnswer !=6)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("What would you like to do?: ");
            string userAnswerString = Console.ReadLine();
            userAnswer = int.Parse(userAnswerString);

            if (userAnswer == 1)
            {
                CreateGoal();
            }
            else if (userAnswer == 2)
            {
                ListGoalDetails();
            }
            else if (userAnswer == 3)
            {
                SaveGoals();
            }
            else if (userAnswer == 4)
            {
                LoadGoals();
            }
            else if (userAnswer == 5)
            {
                RecordEvent();
            }
            else if (userAnswer == 6)
            {

            }
            else 
            {
                Console.WriteLine("That wasn't an option, try again!");
            }
        }
        

    }

    public void DisplayPlayerInfo()
    {
       // display the points
        Console.WriteLine($"You have {_score} points.");

    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are: ");
        
        int numberCount = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"    {numberCount}. ");
            string name = goal.ListName();
            
            
            numberCount += 1;
        }
        
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
           goal.GetDetailsString();
        }
        Console.WriteLine("Press enter to go back to home.");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string typeString = Console.ReadLine();
        int goalType = int.Parse(typeString);

        Console.WriteLine("What is the name of your goal?: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?: ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?: ");
        string goalPointsString = Console.ReadLine();
        int goalPoints = int.Parse(goalPointsString);
        if (goalType == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
            _goals.Add(simpleGoal);

        }
        else if (goalType == 2)
        {
            int count = 0;
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, count);
            _goals.Add(eternalGoal);
        }
        else if (goalType == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?: ");
            string numberToCompleteString = Console.ReadLine();
            int numberToComplete = int.Parse(numberToCompleteString);
            Console.WriteLine("What is the bonus for accomplishing it that many times?: ");
            string bonusPointsString = Console.ReadLine();
            int bonusPoints = int.Parse(bonusPointsString);
            int numberComleted = 0;

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, numberToComplete, bonusPoints, numberComleted);
            _goals.Add(checklistGoal);

        }
        else
        {
            Console.WriteLine("That is not an option, sorry.");
        }

    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Write or load a goal before recording.");
        }
        else{
            ListGoalNames();
            Console.WriteLine("Which goal did you accomplish?");
            string accomplishedGoalString = Console.ReadLine();
            int accomplishedGoal = int.Parse(accomplishedGoalString);
            _goals[accomplishedGoal - 1].RecordEvent();
            _score += _goals[accomplishedGoal -1].ReturnScore();
        }
    }

    public void SaveGoals()
    {
        List<string> pushList = new List<string>();
        Console.WriteLine("What file would you like to save to?: ");
        string fileName = Console.ReadLine();
        string score = _score.ToString();
        pushList.Add(score);

        foreach (Goal goal in _goals)
        {   
            string stringRepresentation =goal.GetRepresentation();
            pushList.Add(stringRepresentation);
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in pushList)
            {
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What file would you like to load from?: ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "Simple Goal") {
                int points = int.Parse(parts[3]);
                bool completion = true;
                if(parts[4] == "true")
                {
                    completion = true;
                }
                else if (parts[4].ToLower() == "false")
                {
                    completion = false;
                }
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], points, completion);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "Eternal Goal")
            {
                int points = int.Parse(parts[3]);
                int count = int.Parse(parts[4]);
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], points, count);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "Checklist Goal")
            {
                int points = int.Parse(parts[3]);
                int numberToComplete = int.Parse(parts[4]);
                int bonusPoints = int.Parse(parts[5]);
                int count = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], points, numberToComplete, bonusPoints, count);
                _goals.Add(checklistGoal);
            }
            else {
                string scoreString = parts[0];
                int score = int.Parse(scoreString);
                _score = score;
            }
        }
    }
}