using System;

namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._jobTitle = "Safari Tour Guide";
            job1._endYear = "2023";
            job1._startYear = "2022";
            job1._company = "Cenozioc Park";

            Job job2 = new Job();
            job2._jobTitle = "SaberTooth Tamer";
            job2._endYear = "10,000 BC";
            job2._startYear = "10,000 BC";
            job2._company = "Main Cave";

            Resume myResume = new Resume();
            myResume._name = "Clunk";
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            myResume.ResumeDisplay();
        }
    }
}