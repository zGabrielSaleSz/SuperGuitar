using SuperGuitar.Core.Chords;
using SuperGuitar.Core.Enum;

namespace SuperGuitar.Core.Notes
{
    public interface INote
    {
        MusicalNotes Note { get; }
        string PortugueseName { get; }
        string PortugueseCleanName { get; }
        string FormalName { get; }

        bool IsSemiton { get; }

        INote GetMajorThird();
        INote GetFifth();

        //IChord GetMajorTriad();

        //INote GetNext(int count = 1);
    }
}
