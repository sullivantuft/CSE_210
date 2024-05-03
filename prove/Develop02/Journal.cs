public class Journal
{

    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
                entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.Write($"{entry._date}|");
                outputFile.Write($"{entry._promptText}|");
                outputFile.Write($"{entry._entryText}|");
                
            }
        }
    }
    public void LoadFromFile(string file)
    {
        
        
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(file);
        

            foreach (string line in lines)
            {
                
                string[] section = line.Split("|");
                Entry newEntry = new Entry();
                
                

                newEntry._date = section[0];
                newEntry._promptText = section[1];
                newEntry._entryText = section[2];

                _entries.Add(newEntry);
                
         
                
            }
    }    
    
}