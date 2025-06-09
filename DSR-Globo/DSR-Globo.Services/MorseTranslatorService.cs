using DSR_Globo.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSR_Globo.Services
{
    public class MorseTranslatorService: IMorseTranslatorService
    {
        private static readonly Dictionary<string, char> MorseMap = new Dictionary<string, char>()
        {
            { ".-", 'A' },   { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' },
            { ".", 'E' },    { "..-.", 'F' }, { "--.", 'G' },  { "....", 'H' },
            { "..", 'I' },   { ".---", 'J' }, { "-.-", 'K' },  { ".-..", 'L' },
            { "--", 'M' },   { "-.", 'N' },   { "---", 'O' },  { ".--.", 'P' },
            { "--.-", 'Q' }, { ".-.", 'R' },  { "...", 'S' },  { "-", 'T' },
            { "..-", 'U' },  { "...-", 'V' }, { ".--", 'W' },  { "-..-", 'X' },
            { "-.--", 'Y' }, { "--..", 'Z' }, { "/", ' ' }
        };

        public string Translate(string morseCode)
        {
            var words = morseCode.Trim().Split(' ');
            var sb = new StringBuilder();

            foreach (var symbol in words)
            {
                if (MorseMap.TryGetValue(symbol, out var letter))
                {
                    sb.Append(letter);
                }
                else
                {
                    sb.Append('?'); // símbolo desconhecido
                }
            }

            return sb.ToString();
        }
    }
}
