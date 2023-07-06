using System;

namespace Develop05
{
    public class Checklist:Goal
    {
        private int _timesCompleted;
        private int _targetTimes;
        private int _completionBonus;

        public Checklist()
        {
            _goalType = "Checklist";
        }

        public override void CreateNew()
        {
            base.CreateNew();
            Console.Write("How many times does this need to be completed to achieve a bonus? ");
            string targetTimesString = Console.ReadLine();
            _targetTimes = int.Parse(targetTimesString);

            Console.Write("What is the bonus for accomplishing this goal that many times? ");
            string completionBonusString = Console.ReadLine();
            _completionBonus = int.Parse(completionBonusString);
        }

        public override string DisplayGoal()
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
            return $"[{completionBar}] {_goalName} ({_description}) -- Currently Completed {_timesCompleted}/{_targetTimes}";
        }

        public override string WriteToFile()
        {
            return $"{_goalType}*{_goalName}|{_description}|{_pointValue}|{_completionBonus}|{_timesCompleted}|{_targetTimes}";
        }
        
        public override void CreateOld(string info)
        {
            string[] parts = info.Split("|");
            _goalName = parts[0];
            _description = parts[1];
            _pointValue = int.Parse(parts[2]);
            _completionBonus = int.Parse(parts[3]);
            _timesCompleted = int.Parse(parts[4]);
            _targetTimes = int.Parse(parts[5]);
        }

        public override void ScorePoints()
        {
            _points = _pointValue * _timesCompleted;
            if (_completion == true)
            {
                _points += _completionBonus;
            }
        }

        public override void CompleteGoal()
        {
            _timesCompleted += 1;
            if (_timesCompleted == _targetTimes)
            {
                _completion = true;
            }
        }
    }
}