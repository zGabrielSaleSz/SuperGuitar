using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes.Notes
{
    public class CDSemiton : NoteBase, INote
    {
        public override string PortugueseName => "Dó sustenido / Ré bemol";
        public override MusicalNotes Note => MusicalNotes.CSharp;
        public override bool IsSemiton => true;
    }
}
