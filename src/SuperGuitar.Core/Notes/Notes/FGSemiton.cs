using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes.Notes
{
    internal class FGSemiton : NoteBase, INote
    {
        public override string PortugueseName => "Fá sustenido / Sol bemol";
        public override MusicalNotes Note => MusicalNotes.FSharp;
        public override bool IsSemiton => true;
    }
}
