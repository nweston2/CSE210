namespace Develop05
{
    public class Goal
    {
        private int _points;
        protected string _goalName;
        protected string _goalType;
        private string _description;
        private bool _completion;

        public Goal()
        {}

        public int GetPoints()
        {
            return 42;
        }

        public void ScorePoints()
        {}

        public void CompleteGoal()
        {}
    }
}