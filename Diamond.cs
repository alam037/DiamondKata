using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamondKata
{
    public class Diamond
    {
        private const char _firstAlphabetChar = 'A';

        public List<string> Generate(char maxChar)
        {

            List<string> _rows = new List<string>();
            if (IsValidAlphabet(maxChar))
            {

                char upperChar = char.ToUpper(maxChar);

                var maxDiamondRows = (upperChar - _firstAlphabetChar + 1) * 2 - 1;

                //Half of diamond
                for (char currentChar = _firstAlphabetChar; currentChar <= upperChar; currentChar++)
                {
                    string row = GenerateRow(currentChar, upperChar, maxDiamondRows);
                    _rows.Add(row);
                }
                List<string> _bottomRows = Enumerable.Reverse(_rows).ToList();

                _rows.AddRange(_bottomRows.Skip(1));
            }
            return _rows;
        }

        private bool IsValidAlphabet(char c)
        {
            if (Char.IsDigit(c))
            {
                throw new Exception("Number is not allowed!");
            }
            else if (!Char.IsLetterOrDigit(c))
            {
                throw new Exception("Special Character is not allowed!");
            }
             return true;
        }

        private string GenerateRow(char currentChar, char maxChar, int maxDiamondRows)
        {
            var externalPadding = maxChar - currentChar;
            var sb = new StringBuilder();

            sb.Append(new string(' ', externalPadding));

            sb.Append(currentChar);

            if (currentChar != _firstAlphabetChar)
            {
                var internalPadding = maxDiamondRows - externalPadding * 2 - 2;
                sb.Append(new string(' ', internalPadding));
                sb.Append(currentChar);
            }

            sb.Append(new string(' ', externalPadding));
            return sb.ToString();
        }
    }
}