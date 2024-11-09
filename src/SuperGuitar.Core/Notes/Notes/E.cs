using SuperGuitar.Core.Enum;
using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.Notes.Notes
{
    public class E : NoteBase, INote
    {
        public override string PortugueseName => "Mi";
        public override MusicalNotes Note => MusicalNotes.E;
    }
}
