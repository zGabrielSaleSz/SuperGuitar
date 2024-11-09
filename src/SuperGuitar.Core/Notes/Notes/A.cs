using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes.Notes 
{ 
    public class A : NoteBase, INote
    {
        public override MusicalNotes Note => MusicalNotes.A;
        public override string PortugueseName { get; } = "Lá";
    }
}
