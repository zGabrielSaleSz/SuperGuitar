using SuperGuitar.Core.Enum;
using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.MusicTheory
{
    public static class NotesExplorer
    {
        private static NotesStorage _notesStorage;

        static NotesExplorer() 
        {
            _notesStorage = NotesStorage.GetInstance();
        }

        public static INote AddSemiton(INote baseNote, int semitons)
        {
            return AddSemiton(baseNote.Note, semitons);
        }

        public static INote AddSemiton(MusicalNotes baseNote, int semitons)
        {
            int baseNoteIndex = (int)baseNote;
            int newIndex = (baseNoteIndex + semitons) % NotesStorage.MAX_NOTES;
            return _notesStorage.AllNotes[newIndex];
        }
    }
}
