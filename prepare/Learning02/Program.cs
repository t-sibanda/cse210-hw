using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Create a new job.
        Job job1 = new Job("Projects Engineer", "Techniplas LLC", 2023, 2024);

        // Create a second job.
        Job job2 = new Job("Facilities Manager", "Dawn Properties Pvt Ltd", 2021, 2022);

        // Create a third job.
        Job job3 = new Job("Account Manager", "Vivo Energy", 2020, 2021);
     

        // Create a new resume.
        Resume resume = new Resume("Terrence Sibanda");

        // Add the jobs to the resume.
        resume.AddJob(job1);
        resume.AddJob(job2);
        resume.AddJob(job3);

        // Display the resume.
        resume.Display();
    }
}