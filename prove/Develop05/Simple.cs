using System;

namespace Develop05
{
    public class Simple:Goal
    {
        public Simple()
        {
            _goalType = "Simple";
        }

        public override string WriteToFile()
        {
            return $"{_goalType}*{_goalName}|{_description}|{_pointValue}|{_completion}";
        }

        public override void CreateOld(string info)
        {
            string[] parts = info.Split("|");
            _goalName = parts[0];
            _description = parts[1];
            _pointValue = int.Parse(parts[2]);
            _completion = bool.Parse(parts[3]);
        }

        public override void ScorePoints()
        {
            if (_completion == true)
            {
                _points = _pointValue;
            }
        }
    }
}