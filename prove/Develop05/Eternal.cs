namespace Develop05
{
    public class Eternal:Goal
    {
        private int _timesCompleted;

        public Eternal(string name)
        {
            _goalType = "Eternal";
            _goalName = name;
        }
    }
}