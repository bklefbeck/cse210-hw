using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Technology Support Technician";
        job1._company = "BYU-Idaho";
        job1._startYear = 2024;
        job1._endYear = 2028;

        Job job2 = new Job();
        job2._jobTitle = "Network Engineer";
        job2._company = "Amazon";
        job2._startYear = 2029;
        job2._endYear = 2060;

        Resume myResume = new Resume();
        myResume._name = "Bailey Klefbeck";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}