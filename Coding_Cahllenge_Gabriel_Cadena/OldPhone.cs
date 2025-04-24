using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Cahllenge_Gabriel_Cadena
{
    public static class OldPhone
    {
        private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
    {
        { '1', "" },
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " }
    };

        public static string OldPhonePad(string input)
        {
            StringBuilder output = new StringBuilder();
            StringBuilder currentSequence = new StringBuilder();

            foreach (char currentChar in input)
            {
                switch (currentChar)
                {
                    case '#':
                        if (currentSequence.Length > 0)
                            output.Append(ConvertSequence(currentSequence.ToString()));
                        return output.ToString();

                    case '*':
                        if (output.Length > 0)
                            output.Remove(output.Length - 1, 1);
                        currentSequence.Clear();
                        break;

                    case ' ':
                        if (currentSequence.Length > 0)
                        {
                            output.Append(ConvertSequence(currentSequence.ToString()));
                            currentSequence.Clear();
                        }
                        break;

                    default:
                        if (!char.IsDigit(currentChar))
                            continue;

                        if (currentSequence.Length == 0 || currentSequence[0] == currentChar)
                        {
                            currentSequence.Append(currentChar);
                        }
                        else
                        {
                            output.Append(ConvertSequence(currentSequence.ToString()));
                            currentSequence.Clear();
                            currentSequence.Append(currentChar);
                        }
                        break;
                }
            }

            return output.ToString();
        }

        private static char ConvertSequence(string sequence)
        {
            if (string.IsNullOrEmpty(sequence)) return '\0';
            char key = sequence[0];

            if (!keypad.ContainsKey(key)) return '?';

            string letters = keypad[key];
            if (letters.Length == 0) return key;

            int index = (sequence.Length - 1) % letters.Length;
            return letters[index];
        }
    }
}
