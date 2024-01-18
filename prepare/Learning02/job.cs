using System;
// I created a class name Job
public class Job
{
    // Added some responsibilties which is the c# convention and you can also notice that i used underscore _ to start the member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // This part is to display my responsibilties which is the _jobTitle, _company, _startYear and the _endYear
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
        
    }
}