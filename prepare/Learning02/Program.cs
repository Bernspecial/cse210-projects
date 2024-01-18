using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

// This is where i add values to the classes, meaning this is where i simplify everything without facing or going through any complicated objects
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        {
            Job job1 = new Job();
            job1._jobTitle = "Web & Computer Programmer";
            job1._company = "Google";
            job1._startYear = 2017;
            job1._endYear = 2023;

            Job job2 = new Job();
            job2._jobTitle = "Project Manager";
            job2._company = "Amazon";
            job2._startYear = 2010;
            job2._endYear = 2016;

            // job1.DisplayJobDetails();
            // job2.DisplayJobDetails();

            Resume myResume = new Resume();
            myResume._name = "Michael Bernard";

            myResume._jobsList.Add(job1);
            myResume._jobsList.Add(job2);

            // Console.WriteLine(myResume._jobsList[0]._jobTitle);



            myResume.DisplayResume();

        }
    }
}