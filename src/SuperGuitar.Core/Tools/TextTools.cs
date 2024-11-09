using System.Globalization;
using System.Text;

namespace SuperGuitar.Core.Tools
{
    public class TextTools
    {
        public static string CleanupNoteName(string noteName)
        {  
            if (string.IsNullOrWhiteSpace(noteName))
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            var normalizedChars = noteName.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in normalizedChars)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(letter);
                }
            }
            return sb.ToString().ToLower();
            
        }
    }
}
