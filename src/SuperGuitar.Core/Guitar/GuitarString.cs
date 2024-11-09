using SuperGuitar.Core.Notes;
using SuperGuitar.Core.Tools;

namespace SuperGuitar.Core.Guitar
{
    public class GuitarString
    {
        private const int MAX_FRETS = 30;
        private readonly INote _baseNote;
        private readonly int _fretsSize;
        public INote[] _notes = new INote[MAX_FRETS];

        public GuitarString(INote baseNote, int size = 24)
        {
            Ensure.NotNull(baseNote);
            Ensure.MaxValue(MAX_FRETS, size);
            _baseNote = baseNote;
            _fretsSize = size;
        }

        private void Initialize()
        {

        }
    }
}
