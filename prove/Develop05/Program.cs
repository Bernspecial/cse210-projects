using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        goalManager.LoadGoals();
        goalManager.ListGoalDetails();
        goalManager.CreateGoal();
        goalManager.GetGoals();
        goalManager.SaveGoals();
        goalManager.RecordEvent();
        goalManager.CalculateScore();
        goalManager.GetScore();
        goalManager.ListGoalName();
    }
}