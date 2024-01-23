using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry> ();

    public void AddEntry (Entry newEntry)
    {
        /*
        is going to add the newwEntry to _entries list
        */
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
       /*
        the Journal display method could iterate through all 
        Entry objects and call the Entry display method. 
       */ 
       foreach (Entry entry in _entries)
       {
            entry.Display();
       } 
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
        // You can add text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
        // You can use the $ and include variables just like with Console.WriteLine
        
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}" );
            }
        }
    }   

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string dateText = parts[0];
            string prompt = parts[1];
            string entryText = parts[2];

            Entry entry = new();
            entry._date = dateText;
            entry._promptText = prompt;
            entry._entryText = entryText;
            
            _entries.Add(entry);
        }
    }
}