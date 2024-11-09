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

        public static INote AddSemiton(int baseNoteIndex, int semitons)
        {
            int newIndex = (baseNoteIndex + semitons) % NotesStorage.MAX_NOTES;
            return _notesStorage.AllNotes[newIndex];
        }
    }
}
