using System;

namespace Learning02
{
    public class Job
    {
        public string _jobTitle;
        public string _company;
        public string _startYear;
        public string _endYear;

        public Job()
        {}

        public void JobDisplay()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
        }
    }
}