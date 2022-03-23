using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        int sentences = 0;
        int vowels = 0;
        int consonants = 0;
        int LowerCaseLetters = 0;
        int UpperCaseLetters = 0;
        //Handles the analysis of text

        //Method: analyseText

        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            foreach (char punc in input)
            {
                if (punc == '.')
                {
                    sentences++;
                }
                if (punc == '?')
                {
                    sentences++;
                }
                if (punc == '!')
                {
                    sentences++;
                }
            }
                int S = sentences;
            //2. Number of vowels
            foreach (char punc in input)
            {
                if (punc == 'a')
                {
                    vowels++;
                    LowerCaseLetters++;
                }
                if (punc == 'u')
                {
                    vowels++;
                    LowerCaseLetters++;
                }
                if (punc == 'o')
                {
                    vowels++;
                    LowerCaseLetters++;
                }
                if (punc == 'i')
                {
                    vowels++;
                    LowerCaseLetters++;
                }
                if (punc == 'e')
                {
                    vowels++;
                    LowerCaseLetters++;
                }
                if (punc == 'A')
                {
                    vowels++;
                    UpperCaseLetters++;
                }
                if (punc == 'U')
                {
                    vowels++;
                    UpperCaseLetters++;
                }
                if (punc == 'O')
                {
                    vowels++;
                    UpperCaseLetters++;
                }
                if (punc == 'I')
                {
                    vowels++;
                    UpperCaseLetters++;
                }
                if (punc == 'E')
                {
                    vowels++;
                    UpperCaseLetters++;
                }
            }
                int V = vowels;
            //3. Number of consonants
            foreach(char punc in input)
            {
                if (punc == 'b')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'c')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'd')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'f')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'f')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'g')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'h')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'i')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'j')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'k')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'l')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'm')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'n')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'p')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'q')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'r')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 's')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 't')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'v')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'w')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'x')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'y')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'z')
                {
                    LowerCaseLetters++;
                    consonants++;
                }

                if (punc == 'B')
                {
                    LowerCaseLetters++;
                    consonants++;
                }
                if (punc == 'C')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'D')
                {
                    UpperCaseLetters++;
                    consonants++;
                }

                if (punc == 'F')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'G')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'H')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'I')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'J')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'K')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'L')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'M')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'N')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'P')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'Q')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'R')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'S')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'T')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'V')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'W')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'X')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'Y')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
                if (punc == 'Z')
                {
                    UpperCaseLetters++;
                    consonants++;
                }
            }
            int C = consonants;
            //4. Number of upper case letters
            int UCL = UpperCaseLetters;
            //5. Number of lower case letters
            int LCL = LowerCaseLetters;
            List<int> values = new List<int>();
            values.Add(S);
            values.Add(V);
            values.Add(C);
            values.Add(UCL);
            values.Add(LCL);
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }


            return values;
        }
        public void analyseTextt()
        {
            Console.WriteLine("There are a total of " + (sentences) + " sentences");
            Console.WriteLine("There are a total of " + (consonants) + " consonants");
            Console.WriteLine("There are a total of " + (vowels) + " vowels");
            Console.WriteLine("There are a total of " + (UpperCaseLetters) + " upper case letters");
            Console.WriteLine("There are a total of " + (LowerCaseLetters) + " lower case letters");

        }
    }

}
