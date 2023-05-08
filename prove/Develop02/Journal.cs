using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }
        public void AddEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }
        public List<Entry> GetAllEntries()
        {
            return this.entries;
        }
    }
}