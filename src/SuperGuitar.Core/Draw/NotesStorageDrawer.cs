using SuperGuitar.Core.Enum;
using SuperGuitar.Core.MusicTheory;
using System.Text;

namespace SuperGuitar.Core.Draw
{
    public class NotesStorageDrawer
    {
        private NotesStorage _storage;
        private static NotesStorageDrawer _notesStorageDrawer = null;
        private NotesStorageDrawer()
        {
            _storage = NotesStorage.GetInstance();
        }

        public static NotesStorageDrawer GetInstance()
        {
            if(_notesStorageDrawer == null)
            {
                _notesStorageDrawer = new NotesStorageDrawer();
            }
            return _notesStorageDrawer;
        }

        public string[] Draw(MusicalNotes note)
        {
            int padding = 12;
            int noteIndex = (int)note;
            string[] result = new string[NotesStorage.MAX_NOTES];
            StringBuilder secondLevelRowCount = new StringBuilder('|');
            StringBuilder firstLevelRowCount = new StringBuilder('|');
            StringBuilder divisor = new StringBuilder('|');
            StringBuilder notesRow = new StringBuilder('|');
            for (int i = 0; i < NotesStorage.MAX_NOTES; i++)
            {
                var indexFirstRow = i - noteIndex;
                secondLevelRowCount.Append(Padding(NotesStorage.MAX_NOTES + indexFirstRow, padding)).Append('|');
                divisor.Append(Padding("", padding, '-')).Append('|');
                firstLevelRowCount.Append(Padding(indexFirstRow, padding)).Append('|');
                notesRow.Append(Padding(_storage.AllNotes[i].FormalName, padding)).Append('|');
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
            while (res.Length < padding)
            {
                res = paddingChar + res;
            }
            return res;
        }
    }
}
