using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Worldwide Online";
        job1._jobTitle = "Assistant Project Manager";
        job1._startYear = 2025;
        job1._endYear = 2026;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Adobe";
        job2._jobTitle = "Intern";
        job2._startYear = 2009;
        job2._endYear = 2028;
        // job2.Display();

        Resume resume = new Resume();
        resume._name = "Lincoln Hanks";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();

        // Console.WriteLine(resume._jobs[0]._jobTitle);
    }
}