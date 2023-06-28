namespace Develop05
{
    public class Checklist:Goal
    {
        private int _timesCompleted;
        private int _targetTimes;

        public Checklist(string name)
        {
            _goalType = "Checklist";
            _goalName = name;
        }
    }
}