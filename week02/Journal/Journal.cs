using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Put newEntry into _entries
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Display all of the entries in the _entries list
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }

    }

    public void SaveToFile(string flie)
    {
        // Loop through each item in _entires and save in a file
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

        }
    }

    public void LoadFromFile(string file)
    {
        // Loop through each line of the file and create Entry objects to put in the ist
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}