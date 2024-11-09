using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes.Notes
{
    public class ABSemiton : NoteBase, INote
    {
        public override string PortugueseName => "Lá sustenido / Si bemol";
        public override MusicalNotes Note => MusicalNotes.ASharp;
        public override bool IsSemiton => true;
    }
}
