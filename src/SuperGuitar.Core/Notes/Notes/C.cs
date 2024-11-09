using SuperGuitar.Core.Enum;
using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.Notes.Notes
{
    public class C : NoteBase, INote
    {
        public override string PortugueseName => "Dó";
        public override MusicalNotes Note => MusicalNotes.C;
    }
}
