using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2012;
        job1._endYear = 2020;

        //Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYear}");
        //job1.Display();

        Job job2 = new Job();    

        job2._company = "Microsoft";
        job2._jobTitle = "Designer";
        job2._startYear = 2008;
        job2._endYear = 2016;

        //Console.WriteLine($"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYear}");
        //job2.Display();

        Resume resume = new Resume();
        resume._name = "Reynaldo";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Console.WriteLine($"{resume._jobs[1]._jobTitle}");
        resume.Display();
    }
}