using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {

        public string answer;
        //Handles the reporting of the analysis
        public void decision()
        {
            Console.WriteLine("Welcome to my analyse program. Would you like to analyse a downloaded file or enter some text manualy? Enter 'file' for the first option or 'manual' for the second option.");
            Console.WriteLine("");
            answer = Console.ReadLine();
        }
        public void report()
        {



            //This will make the manualTextInput method take place and have it be analysed by the Analyse class
            if (answer == "manual")
            {
                Input I1 = new Input();
                string TEXT = I1.manualTextInput();
                Analyse a1 = new Analyse();
                a1.analyseText(TEXT);
                Console.WriteLine("");
                Console.WriteLine("There are a total of " + (a1.sentences) + " sentences");
                Console.WriteLine("There are a total of " + (a1.consonants) + " consonants");
                Console.WriteLine("There are a total of " + (a1.vowels) + " vowels");
                Console.WriteLine("There are a total of " + (a1.UpperCaseLetters) + " upper case letters");
                Console.WriteLine("There are a total of " + (a1.LowerCaseLetters) + " lower case letters");
                Console.WriteLine("");
            }
            //This will make the manualTextInput method take place and have it be analysed by the Analyse class
            if (answer == "Manual")
            {
                Input I1 = new Input();
                string TEXT = I1.manualTextInput();
                Analyse a1 = new Analyse();

                a1.analyseText(TEXT);
                Console.WriteLine("");
                Console.WriteLine("There are a total of " + (a1.sentences) + " sentences");
                Console.WriteLine("There are a total of " + (a1.consonants) + " consonants");
                Console.WriteLine("There are a total of " + (a1.vowels) + " vowels");
                Console.WriteLine("There are a total of " + (a1.UpperCaseLetters) + " upper case letters");
                Console.WriteLine("There are a total of " + (a1.LowerCaseLetters) + " lower case letters");
                Console.WriteLine("");
            }
            //This will make the manualTextInput method take place and have it be analysed by the Analyse class
            if (answer == "file")
            {
                Input I1 = new Input();
                string TEXT = I1.fileTextInput("");

                Analyse a1 = new Analyse();
                if (I1.Possible == true)
                {
                    a1.analyseText(TEXT);
                    Console.WriteLine("");
                    Console.WriteLine("There are a total of " + (a1.sentences) + " sentences");
                    Console.WriteLine("There are a total of " + (a1.consonants) + " consonants");
                    Console.WriteLine("There are a total of " + (a1.vowels) + " vowels");
                    Console.WriteLine("There are a total of " + (a1.UpperCaseLetters) + " upper case letters");
                    Console.WriteLine("There are a total of " + (a1.LowerCaseLetters) + " lower case letters");
                    Console.WriteLine("");
                }
                if (I1.Possible == false)
                {
                    Console.WriteLine("");
                }

            }
            //This will make the manualTextInput method take place and have it be analysed by the Analyse class
            if (answer == "File")
            {
                Input I1 = new Input();
                string TEXT = I1.fileTextInput("");

                Analyse a1 = new Analyse();
                if (I1.Possible == true)
                {
                    a1.analyseText(TEXT);
                    Console.WriteLine("");
                    Console.WriteLine("There are a total of " + (a1.sentences) + " sentences");
                    Console.WriteLine("There are a total of " + (a1.consonants) + " consonants");
                    Console.WriteLine("There are a total of " + (a1.vowels) + " vowels");
                    Console.WriteLine("There are a total of " + (a1.UpperCaseLetters) + " upper case letters");
                    Console.WriteLine("There are a total of " + (a1.LowerCaseLetters) + " lower case letters");
                    Console.WriteLine("");
                }
                if (I1.Possible == false)
                {
                    Console.WriteLine("");
                }
            }
            else //Makes sure the user enters something for their decision
            {
                Console.WriteLine("");
                Console.WriteLine("No answer was detected. PLease restart program");
                Console.WriteLine("");
            }
        }


    }
}
