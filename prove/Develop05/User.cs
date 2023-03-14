public class User
{
    private List<Goal> _goals;
    private string _menu;
    private int _typeOfGoal;
    private int _totalPoints;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _timesToBonus;
    private int _bonusPoints;
    private List<Goal> _aux = new List<Goal>();
    private bool _isCompleted;
    private bool _complete;
    private int _index;
    private string _filename;
    private string[] _lines;
    private string[] _parts;

    public User()
    {
        _goals = new List<Goal>();
    }
    public void CreateNewGoal()
    {
        //Console.Clear();
        Console.WriteLine("");
        _menu = "Types of goals:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of goal would you like to create?: ";
        Console.Write(_menu);
        _typeOfGoal = int.Parse(Console.ReadLine());
        switch (_typeOfGoal)
        {
            case 1: //SIMPLE GOAL
                Console.Write("What is the name of your goal? ");
                _goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                _goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with your goal? ");
                _goalPoints = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(_goalName, _goalDescription, _goalPoints, false);
                _goals.Add(simpleGoal);
                break;

            case 2: //ETERNAL GOAL
                Console.Write("What is the name of your goal? ");
                _goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                _goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with your goal? ");
                _goalPoints = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(_goalName, _goalDescription, 0, _goalPoints);
                _goals.Add(eternalGoal);
                break;

            case 3: //CHECKLIST GOAL
                Console.Write("What is the name of your goal? ");
                _goalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                _goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with your goal? ");
                _goalPoints = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                _timesToBonus = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                _bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(_goalName, _goalDescription, _goalPoints, _bonusPoints, _timesToBonus, 0, false);
                _goals.Add(checklistGoal);
                break;
        }
    }
    public void DisplayGoals()
    {
        int i = 1;

        Console.WriteLine("The goals are: ");
        
        foreach (Goal goal in _goals)
        {
            Console.Write(i + ". ");
            goal.DisplayGoal(0);
            i++;
        }
        //Console.WriteLine();
    }
    public void Save()
    {
        // Console.Clear();
        //Console.WriteLine("");
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"00|{_totalPoints}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRep());
            }
        }
    }

    public void Load()
    {
        // Console.Clear();
        //Console.WriteLine("");
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();
        _lines = System.IO.File.ReadAllLines(_filename);
        _goals.Clear();
        foreach (string line in _lines)
        {
            _parts = line.Split("|");
            if (int.Parse(_parts[0]) == 00)
            {
                if (int.Parse(_parts[1]) == 0)
                {
                    _totalPoints = 0;
                }
                else if (int.Parse(_parts[1]) != 0) 
                {
                    _totalPoints = int.Parse(_parts[1]);
                }
                continue;
            }

            if (int.Parse(_parts[0]) == 1)
            {
                // bool isCompleted;
                if (_parts[4].ToLower().Equals("true"))
                {
                    _isCompleted = true;
                }
                else
                {
                    _isCompleted = false;
                }
                SimpleGoal loadedGoal = new SimpleGoal(_parts[1], _parts[2], int.Parse(_parts[3]), _isCompleted);
                _goals.Add(loadedGoal);
            }
            else if (int.Parse(_parts[0]) == 2)
            {
                EternalGoal loadedGoal = new EternalGoal(_parts[1], _parts[2], int.Parse(_parts[3]), int.Parse(_parts[4]));
                _goals.Add(loadedGoal);
            }
            else if (int.Parse(_parts[0]) == 3)
            {
                // bool complete;
                if (_parts[7].ToLower().Equals("true"))
                {
                    _complete = true;
                }
                else
                {
                    _complete = false;
                }
                ChecklistGoal loadedGoal = new ChecklistGoal(_parts[1], _parts[2], int.Parse(_parts[3]), int.Parse(_parts[4]), int.Parse(_parts[5]), int.Parse(_parts[6]), _complete);
                _goals.Add(loadedGoal);
            }
        }
        //Console.WriteLine("");

    }
    public void RecordEvent()
    {
        int i = 1;
        
        Console.WriteLine("");
        Console.WriteLine("The goals are: ");
        
        List<Goal> _aux = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (!goal.GetIsCompleted())
            {
                _aux.Add(goal);
                Console.Write(i + ". ");
                goal.DisplayGoal(1);
                i++;
            }
        }
        Console.WriteLine("");
        if (i > 1)
        {
            Console.Write("Which goal did you accomplish?: ");
            _index = int.Parse(Console.ReadLine()) - 1;
            _aux[_index].SetIsCompleted();
            _totalPoints += _aux[_index].GetPoints();
        }
        else
        {
            Console.WriteLine("Goal list is empty");
        }
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}