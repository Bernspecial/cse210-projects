using System;
public class Resume
{
    public string _name;
    public List<Job> _jobsList = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Job List: ");

        foreach (Job jobList in _jobsList)
        {
            jobList.DisplayJobDetails();
        }
    }
}