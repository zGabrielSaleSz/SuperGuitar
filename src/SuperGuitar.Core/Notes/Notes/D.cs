using SuperGuitar.Core.Enum;
using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.Notes.Notes
{
    public class D : NoteBase, INote
    {
        public override string PortugueseName => "Ré";
        public override MusicalNotes Note => MusicalNotes.D;
    }
}
