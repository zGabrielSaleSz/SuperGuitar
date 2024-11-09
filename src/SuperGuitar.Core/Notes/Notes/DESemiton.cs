using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes.Notes
{
    internal class DESemiton : NoteBase, INote
    {
        public override string PortugueseName => "Ré sustenido / Mi bemol";
        public override MusicalNotes Note => MusicalNotes.DSharp;
        public override bool IsSemiton => true;
    }
}
