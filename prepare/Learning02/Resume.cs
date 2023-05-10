using System;
using System.Collections.Generic;

namespace Learning02
{
    public class Resume
    {
        public string _name;
        public List<Job> _jobs;

        public Resume()
        {
            _jobs = new List<Job>();
        }

        public void ResumeDisplay()
        {
            Console.WriteLine($"Name: {_name}\nJobs:");

            foreach (Job job in _jobs)
            {
                job.JobDisplay();
            }
        }
    }
}