using SuperGuitar.Core.MusicTheory;
using SuperGuitar.Core.Notes;
using SuperGuitar.Core.Tools;

namespace SuperGuitar.Core.Guitar
{
    public class GuitarString
    {
        public INote[] Notes = new INote[MAX_FRETS];
        private const int MAX_FRETS = 30;
        private readonly INote _baseNote;
        private readonly int _fretsSize;

        public GuitarString(INote baseNote, int size = 24)
        {
            Ensure.NotNull(baseNote);
            Ensure.MaxValue(MAX_FRETS, size);
            _baseNote = baseNote;
            _fretsSize = size;

            Notes[0] = _baseNote;
            for (int i = 1; i < MAX_FRETS; i++)
            {
                Notes[i] = NotesExplorer.AddSemiton(Notes[i-1], 1);
            }
        }
    }
}
