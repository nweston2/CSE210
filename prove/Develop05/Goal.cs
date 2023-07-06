using System;

namespace Develop05
{
    public class Goal
    {
        protected int _points;
        protected int _pointValue;
        protected string _goalName;
        protected string _goalType;
        protected string _description;
        protected bool _completion = false;

        public Goal()
        {}

        public int Tally()
        {
            this.ScorePoints();
            return _points;
        }

        public virtual void ScorePoints()
        {}

        public virtual void CompleteGoal()
        {
            _completion = true;
        }

        public string GetName()
        {
            return _goalName;
        }

        public bool Accomplished()
        {
            return _completion;
        }

        public virtual string DisplayGoal()
        {
            string completionBar;
            if (_completion == true)
            {
                completionBar = "X";
            }

            else
            {
                completionBar = " ";
            }
            return $"[{completionBar}] {_goalName} ({_description})";
        }

        public virtual string WriteToFile()
        {
            return "whoops. this slipped through somehow";
        }

        public virtual void CreateNew()
        {
            Console.Write("What would you like to name this goal? ");
            string goalName = Console.ReadLine();
            _goalName = goalName;

            Console.Write("Please enter a short description of this goal: ");
            string goalDescription = Console.ReadLine();
            _description = goalDescription;

            Console.Write("How many points would you like to associate with this goal? ");
            string goalPointsString = Console.ReadLine();
            int goalPoints = int.Parse(goalPointsString);
            _pointValue = goalPoints;
        }

        public virtual void CreateOld(string info)
        {}
    }
}