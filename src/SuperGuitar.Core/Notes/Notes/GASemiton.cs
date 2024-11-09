using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes.Notes
{
    internal class GASemiton : NoteBase, INote
    {
        public override string PortugueseName => "Sol sustenido / Lá bemol";
        public override MusicalNotes Note => MusicalNotes.GSharp;
        public override bool IsSemiton => true;
    }
}
