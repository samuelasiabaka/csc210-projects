using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var item in _entries)
        {
            item.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var item in _entries)
            {
                outputFile.WriteLine($"{item._date}|{item._promptText}|{item._entryText}");
            }
        }
        Console.WriteLine($"Entries saved to {filename}");
    }
    
    public void LoadFromFile(string filename)
    {
        if (System.IO.File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Entries loaded from {filename}");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }

    }
}