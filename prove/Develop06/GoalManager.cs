using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public class GoalManager
{
    // Private fields
    private List<Goal> _goals;
    private int _score;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public void Start()
    {
        Console.WriteLine("You have 0 points");
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // Method to list goal names
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    // Method to list goal details
    public void ListGoalDetails()
    {
        // foreach (var goal in _goals)
        // {
        //     Console.WriteLine(
        //         $"{_goals.IndexOf(goal, _goals.IndexOf(goal)) + 1}. [ ] {goal.GetShortName()} ({goal.GetDescription()}) "
        //     );
        // }
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals.Count > 0)
            {
                Console.WriteLine($"{i + 1}. [ ] {_goals[i].GetShortName()} ({_goals[i].GetDescription()}) ");
            }
        }
    }

    // Method to create a goal
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to record an event
    public void RecordEvent()
    {
        Console.WriteLine("Event recorded.");
    }

    // Method to save goals to a file
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(
                    $"{goal.GetShortName()},{goal.GetDescription()},{goal.GetPoints()}"
                );
            }
        }
        Console.WriteLine("Goals saved.");
    }

    // Method to load goals from a file
    public void LoadGoals()
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    var goal = new Goal(parts[0], parts[1], parts[2]);
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}
