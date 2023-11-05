using System.ComponentModel.DataAnnotations;

public class Journal
{
    public List<JournalEntry> _journalEntry = new List<JournalEntry>();

    public void DisplayAttribute()
    {
        foreach (JournalEntry journalEntry in _journalEntry)
        {
            Console.WriteLine($"Date: {journalEntry._entryDate} - Prompt: {journalEntry._prompt}");
            Console.WriteLine(journalEntry._entry);
        }

    }
}