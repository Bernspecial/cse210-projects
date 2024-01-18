using System;

// i created another class called Resume because i want the values in class Job to be added to my resume
public class Resume
{
    // Added some responsibilties which is the c# convention and you can also notice that i used underscore _ to start the member variables
    public string _name;

    // this convention actually makes you of array that allows me to refrence the class Job into, so that it add the values into it
    public List<Job> _jobsList = new List<Job>();

    // This diplays the _name and the list of jobs from the class Job and also iterate through them.
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