using SuperGuitar.Core.Enum;
using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.Notes.Notes
{
    public class B : NoteBase, INote
    {
        public override string PortugueseName => "Si";
        public override MusicalNotes Note => MusicalNotes.B;
    }
}
