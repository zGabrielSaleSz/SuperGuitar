using SuperGuitar.Core.MusicTheory;
using SuperGuitar.Core.Notes;
using SuperGuitar.Core.Notes.Notes;
using SuperGuitar.Core.Enum;

namespace SuperGuitarTests
{
    public class MajorTriadChordTest
    {
        [Fact]
        [Trait("Major triad chord", "C / Dó")]
        public void Do_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote c = new C();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.E);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.G);

            Assert.Equal(majorThirdExpected, c.GetMajorThird());
            Assert.Equal(perfectFifthExpected, c.GetFifth());
        }


        [Fact]
        [Trait("Major triad chord", "D / Ré")]
        public void Re_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote d = new D();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.FSharp);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.A);

            Assert.Equal(majorThirdExpected, d.GetMajorThird());
            Assert.Equal(perfectFifthExpected, d.GetFifth());
        }

        [Fact]
        [Trait("Major triad chord", "E / Mi")]
        public void Mi_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote mi = new E();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.GSharp);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.B);

            Assert.Equal(majorThirdExpected, mi.GetMajorThird());
            Assert.Equal(perfectFifthExpected, mi.GetFifth());
        }


        [Fact]
        [Trait("Major triad chord", "F / Fá")]
        public void Fa_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote f = new F();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.A);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.C);

            Assert.Equal(majorThirdExpected, f.GetMajorThird());
            Assert.Equal(perfectFifthExpected, f.GetFifth());
        }

        [Fact]
        [Trait("Major triad chord", "G / Sol")]
        public void Sol_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote g = new G();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.B);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.D);

            Assert.Equal(majorThirdExpected, g.GetMajorThird());
            Assert.Equal(perfectFifthExpected, g.GetFifth());
        }

        [Fact]
        [Trait("Major triad chord", "A / Lá")]
        public void La_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote a = new A();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.CSharp);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.E);

            Assert.Equal(majorThirdExpected, a.GetMajorThird());
            Assert.Equal(perfectFifthExpected, a.GetFifth());
        }

        [Fact]
        [Trait("Major triad chord", "B / Si")]
        public void Si_MajorTriadChord()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();
            INote b = new B();
            INote majorThirdExpected = notesStorage.Get(MusicalNotes.DSharp);
            INote perfectFifthExpected = notesStorage.Get(MusicalNotes.FSharp);

            Assert.Equal(majorThirdExpected, b.GetMajorThird());
            Assert.Equal(perfectFifthExpected, b.GetFifth());
        }
    }
}