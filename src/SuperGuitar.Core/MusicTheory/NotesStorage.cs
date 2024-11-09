using SuperGuitar.Core.Enum;
using SuperGuitar.Core.Notes;
using SuperGuitar.Core.Notes.Notes;
using System.Text;

namespace SuperGuitar.Core.MusicTheory
{
    public class NotesStorage
    {
        public const int MAX_NOTES = 12;
        private static NotesStorage? _instance = null;
        public readonly INote[] AllNotes = new INote[MAX_NOTES];
        private NotesStorage()
        {
            AllNotes[(int)MusicalNotes.A] = new A();
            AllNotes[(int)MusicalNotes.ASharp] = new ABSemiton();
            AllNotes[(int)MusicalNotes.B] = new B();
            AllNotes[(int)MusicalNotes.C] = new C();
            AllNotes[(int)MusicalNotes.CSharp] = new CDSemiton();
            AllNotes[(int)MusicalNotes.D] = new D();
            AllNotes[(int)MusicalNotes.DSharp] = new DESemiton();
            AllNotes[(int)MusicalNotes.E] = new E();
            AllNotes[(int)MusicalNotes.F] = new F();
            AllNotes[(int)MusicalNotes.FSharp] = new FGSemiton();
            AllNotes[(int)MusicalNotes.G] = new G();
            AllNotes[(int)MusicalNotes.GSharp] = new GASemiton();
        }

        public static NotesStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NotesStorage();
            }
            return _instance;
        }

        public INote Get(MusicalNotes note)
        {
            return AllNotes[(int)note];
        }

        public string[] Draw(MusicalNotes note)
        {
            int padding = 12;
            int noteIndex = (int)note;
            string[] result = new string[MAX_NOTES];
            StringBuilder secondLevelRowCount = new StringBuilder('|');
            StringBuilder firstLevelRowCount = new StringBuilder('|');
            StringBuilder divisor = new StringBuilder('|');
            StringBuilder notesRow = new StringBuilder('|');
            for (int i = 0; i < MAX_NOTES; i++)
            {
                var indexFirstRow = i - noteIndex;
                secondLevelRowCount.Append(Padding(MAX_NOTES + indexFirstRow, padding)).Append('|');
                divisor.Append(Padding("", padding, '-')).Append('|');
                firstLevelRowCount.Append(Padding(indexFirstRow, padding)).Append('|');
                notesRow.Append(Padding(AllNotes[i].FormalName, padding)).Append('|');
            }
            Console.WriteLine(secondLevelRowCount.ToString());
            Console.WriteLine(firstLevelRowCount.ToString());
            Console.WriteLine(divisor.ToString());
            Console.WriteLine(notesRow.ToString());
            Console.WriteLine(divisor.ToString());
            Console.WriteLine();
            return result;
        }

        private string Padding(object content, int padding, char paddingChar = ' ')
        {
            // dumb logic, whatever
            string res = content.ToString();
            while(res.Length < padding)
            {
                res = paddingChar + res;
            }
            return res;
        }
    }
}
