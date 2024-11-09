using SuperGuitar.Core.Enum;
using SuperGuitar.Core.MusicTheory;
using SuperGuitar.Core.Tools;

namespace SuperGuitar.Core.Notes.Notes
{
    public abstract class NoteBase : INote
    {
        public abstract MusicalNotes Note { get; }
        public abstract string PortugueseName { get; }
        public virtual bool IsSemiton => false;
        public NoteBase()
        {
            
        }
        
        public string FormalName => GetType().Name;
        public string PortugueseCleanName => TextTools.CleanupNoteName(PortugueseName);

        

        public INote GetMajorThird()
        {
            return NotesExplorer.AddSemiton((int)Note, 4);
        }

        public INote GetFifth()
        {
            return NotesExplorer.AddSemiton((int)Note, 7);
        }
    }
}
