using SuperGuitar.Core.Draw;
using SuperGuitar.Core.MusicTheory;

namespace SuperGuitar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotesStorageDrawer.GetInstance().Draw(Core.Enum.MusicalNotes.C);

            var readresult = "1";
            while (readresult != "0")
            {
                Console.WriteLine("1 - Quizz notes in portuguese");
                Console.WriteLine("2 - Find out notes in fretboard");
                Console.WriteLine("0 - Exit");
                readresult = Console.ReadLine();
                switch (readresult)
                {
                    case "0":
                        break;
                    case "1":
                        _1QuizzNotes.Initialize();
                        break;
                    case "2":
                        _2FretboardExplorer.Initialize();
                        break;
                    default:
                        Console.WriteLine("Unknown option");
                        break;
                        
                }
            }
        }
    }
}