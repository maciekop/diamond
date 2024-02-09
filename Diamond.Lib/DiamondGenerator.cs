using System.Text;

namespace Diamond.Lib
{
    public class DiamondGenerator
    {
        private const char FillingChar = '_';

        public string[] Generate(char letter)
        {
            if (letter < 'A' || letter > 'Z')
            {
                throw new ArgumentException("Provided argument is not a capital letter");
            }

            int letterIndex = letter - 'A';
            int size = letterIndex * 2 + 1;

            string[] diamond = new string[size];

            for (int i = 0; i <= letterIndex; i++)
            {
                var currentLine = new StringBuilder(size);
                char currentLetter = (char)(i + 'A');

                //add preceding filling
                for (int j = 0; j < size / 2 - i; j++)
                {
                    currentLine.Append(FillingChar);
                }

                //add letter (first time)
                currentLine.Append(currentLetter);

                //add filling between letters
                if (currentLetter != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        currentLine.Append(FillingChar);
                    }
                    //add letter (second time)
                    currentLine.Append(currentLetter);
                }

                // add trailing filling
                for (int j = 0; j < size / 2 - i; j++)
                {
                    currentLine.Append(FillingChar);
                }

                var currentLineString = currentLine.ToString();

                // add top line
                diamond[i] = currentLineString;

                // add bottom line
                if (currentLetter != letter)
                {
                    diamond[size - i - 1] = currentLineString;

                }
            }

            return diamond;
        }
    }
}
