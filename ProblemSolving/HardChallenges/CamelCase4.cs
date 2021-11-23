using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CamelCase4
{
    static void CamelCase()
    { 

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            input = input.Replace("/r/n", "").Replace("/n", "");

            var charArr = input.ToCharArray();

            char command = charArr[0];

            char type = charArr[2];

            string sentence = "";

            for (int i = 4; i < charArr.Length; i++)
            {
                sentence += charArr[i];
            }

            // sentence is camel case
            if (command == 'S')
            {
                if (type == 'M') // if we are dealing with a method remove the braces;
                    sentence = sentence.Remove(sentence.Length - 2);

                // let's split the sentence on the capital letters and
                // put the sentence in lower case;

                string sentenceOutput = "";

                for (int i = 0; i < sentence.Count(); i++)
                {
                    if (char.IsLower(sentence[i]))
                        sentenceOutput += sentence[i];
                    if ((char.IsUpper(sentence[i]) && i == 0 && type == 'C'))
                        sentenceOutput += char.ToLower(sentence[i]);
                    else if (char.IsUpper(sentence[i]))
                    {
                        sentenceOutput += " ";
                        sentenceOutput += char.ToLower(sentence[i]);
                    }
                }
                Console.WriteLine(sentenceOutput);
            }
            else
            {
                string sentenceOutput = "";

                // sentence is space seperated we need to combine the
                // words into camel case
                for (int i = 0; i < sentence.Count(); i++)
                {
                    if (sentence[i] != ' ' && i == 0 && type == 'C')
                    {
                        sentenceOutput += char.ToUpper(sentence[i]);
                    }
                    else if (sentence[i] != ' ')
                    {
                        sentenceOutput += sentence[i];
                    }
                    else
                    {
                        sentenceOutput += char.ToUpper(sentence[i + 1]);
                        i++;
                    }
                }
                if (type == 'M')
                {
                    sentenceOutput += "()";
                }
                Console.WriteLine(sentenceOutput);
            }
        }
    }
}