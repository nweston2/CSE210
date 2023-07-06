namespace Develop02
{
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;

        public string ConvertToString()
        {
            return $"{date}\n{prompt}\n{response}";
        }

        public string WriteToFile()
        {
            return $"{date}*{prompt}*{response}";
        }
        public void Hold(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }

        public Entry()
        {}
    }
}