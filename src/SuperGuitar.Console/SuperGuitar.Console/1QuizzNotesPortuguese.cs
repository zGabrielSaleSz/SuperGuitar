using SuperGuitar.Core.MusicTheory;
using System;

namespace SuperGuitar
{
    public static class _1QuizzNotes
    {
        public static void Initialize()
        {
            NotesStorage notesStorage = NotesStorage.GetInstance();

            Random random = new Random();
            
            string answer = "";
            while (answer != "exit")
            {
                int randomIndex = random.Next() % NotesStorage.MAX_NOTES;
                var nextQuestionNote = notesStorage.AllNotes[randomIndex];
                Console.WriteLine($"[ What's the portuguese of '{nextQuestionNote.FormalName}' ? ]");
                answer = Console.ReadLine();
                if (answer == null || answer.ToLower() != nextQuestionNote.PortugueseCleanName.ToLower())
                {
                    Console.WriteLine($"Wrong ! The portuguese name is {nextQuestionNote.PortugueseCleanName.ToLower()}\r\n\r\n");
                }
                else
                {
                    Console.WriteLine("You're right\r\n\r\n");
                }
            }
        }
    }
}
