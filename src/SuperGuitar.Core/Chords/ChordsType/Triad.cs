using SuperGuitar.Core.Notes;

namespace SuperGuitar.Core.Chords.ChordsType
{
    public class Triad : ITriad
    {
        private readonly INote _root;

        public Triad(INote root) {
            _root = root;
        }


    }
}
