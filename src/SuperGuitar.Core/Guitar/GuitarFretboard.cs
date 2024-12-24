using SuperGuitar.Core.Notes;
using SuperGuitar.Core.Notes.Notes;
using SuperGuitar.Core.Tools;
using System.Collections.Concurrent;

namespace SuperGuitar.Core.Guitar
{
    public class GuitarFretboard
    {
        public readonly GuitarString[] Strings = new GuitarString[6];
        private IDictionary<string, int> _indexByNote = new Dictionary<string, int>(6); 

        private static GuitarFretboard _instance = null;
        private GuitarFretboard()
        {
            _indexByNote.Add(new E().FormalName, 0);
            _indexByNote.Add(new A().FormalName, 1);
            _indexByNote.Add(new D().FormalName, 2);
            _indexByNote.Add(new G().FormalName, 3);
            _indexByNote.Add(new B().FormalName, 4);
            _indexByNote.Add(new E().FormalName.ToLower(), 5);

            Strings[0] = new GuitarString(new E());
            Strings[1] = new GuitarString(new A());
            Strings[2] = new GuitarString(new D());
            Strings[3] = new GuitarString(new G());
            Strings[4] = new GuitarString(new B());
            Strings[5] = new GuitarString(new E());
        }
        public static GuitarFretboard GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GuitarFretboard();
            }
            return _instance;
        }

        /// <summary>
        /// The "String" Note + the fretboard number, use "E" for the first string and "e" for the last string,
        /// for example: E5, A1, D13, B12, e12
        /// </summary>
        /// <param name="fretboardNoteName">For example: E5, A1, D13, B12, e12</param>
        /// <returns></returns>
        public INote GetNote(string fretboardNoteName)
        {
            Ensure.MinLength(fretboardNoteName, 2);
            int fretboardNumber;
            string stringNote = fretboardNoteName[0].ToString();
            if (!_indexByNote.TryGetValue(stringNote, out int stringIndex)) {
                throw new Exception($"Invalid string name {stringNote} on parameter {fretboardNoteName}");
            }
            Ensure.IsInteger(fretboardNoteName.Substring(1), out fretboardNumber);
            return Strings[stringIndex].Notes[fretboardNumber];
        }

     
    }
}
