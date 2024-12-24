using SuperGuitar.Core.Guitar;

namespace SuperGuitar
{
    public class _2FretboardExplorer
    {
        public static async void Initialize()
        {
            GuitarFretboard guitarFretboard = GuitarFretboard.GetInstance();
            string answer = "";
            while (answer != "exit")
            {
                try
                {
                    Console.WriteLine($"[ What's the note you want to know ? ]");
                    answer = Console.ReadLine();
                    var note = guitarFretboard.GetNote(answer.Trim());
                    Console.WriteLine($"{note.FormalName}      {note.PortugueseName}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Coundn't handle the result note of {answer} in fretboard explorer");
                }
            }
        }
    }
}
