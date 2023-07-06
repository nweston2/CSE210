using System;

namespace Develop05
{
    public class Eternal:Goal
    {
        private int _timesCompleted;

        public Eternal()
        {
            _goalType = "Eternal";
            _timesCompleted = 0;
        }

        public override string WriteToFile()
        {
            return $"{_goalType}*{_goalName}|{_description}|{_pointValue}|{_timesCompleted}";
        }

        public override void CreateOld(string info)
        {
            string[] parts = info.Split("|");
            _goalName = parts[0];
            _description = parts[1];
            _pointValue = int.Parse(parts[2]);
            _timesCompleted = int.Parse(parts[3]);
        }

        public override void ScorePoints()
        {
            _points = _pointValue * _timesCompleted;
        }

        public override void CompleteGoal()
        {
            _timesCompleted += 1;
        }
    }
}