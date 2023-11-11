using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        string a = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        scriptures.Add(new Scripture("John",3,16,a));
        a ="Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        scriptures.Add(new Scripture("Proverbs",3,5,a));
        a="In all thy ways acknowledge him, and he shall direct thy paths.";
        scriptures.Add(new Scripture("Proverbs",3,6,a));

        int c = 0;
        Reference reference = new Reference();
        
        foreach (Scripture scripture in scriptures)
        {
            if (c==1)
            {
                reference.setVar(scripture.GetReference(),scripture.GetText());
            }
            else if (c==2)
            {
                reference.AddScripture(scripture.GetReference(),scripture.GetText());
            }
            c=c+1;
        }
        string guessRef = reference.GetRef();
        string guessText = reference.GetText();
        HideWords word = new HideWords(guessText);
        c=0;
        do
        {
            Console.Clear();
            Console.WriteLine(guessRef + " " + word.GetWords());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            a = Console.ReadLine();
            if (word.GetHiddenCount()==word.GetLength())
            {
                a="quit";
            }
            word.Redact();
        }while (a!="quit");
    }
}