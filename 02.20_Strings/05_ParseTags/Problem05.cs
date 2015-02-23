using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ParseTags
{
    class Problem05
    {

        // Main -----------------------------
        static void Main()
        {
            //Console.Write("Enter text for parsing: ");
            //string text = Console.ReadLine();
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string leftText = string.Empty;
            string rightText = string.Empty;
            string textToUpper = string.Empty;

            StringBuilder resultText = new StringBuilder();

            int indexLeft = 0;
            int indexRight = 0;


            while (true)
            {
                indexLeft = text.IndexOf("<upcase>", indexLeft);
                if (indexLeft < 0 || indexRight < 0)
                {
                    resultText.Append(text);
                    break;
                }

                leftText = text.Substring(indexRight, indexLeft);
                resultText.Append(leftText);

                indexRight = text.IndexOf("</upcase>", indexLeft + 8);
                textToUpper = text.Substring(indexLeft + 8, indexRight - (indexLeft + 8));
                textToUpper = textToUpper.ToUpper();
                resultText.Append(textToUpper);
                text = text.Substring(indexRight + 9);
                indexRight = 0;
                indexLeft = 0;
            }
            Console.WriteLine(resultText);
        }
    }
}
