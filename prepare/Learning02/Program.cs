using System;

class Program
{
    static void Main(string[] args)
    {
        //For this assigment, I wanted to use my personal jobs informations
        Job job1 = new Job()
        job1._company = "Amazon";
        job1-_jobTitle = "Warehouse Associate";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "operations Supervisor";
        job2._startYear = 2021;
        job2._endYear = 2023;
        //Displaying name and all the jobs
        Resume resume = new Resume();
        resume._name = "Alan Ronaldo Bazan Monge";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}