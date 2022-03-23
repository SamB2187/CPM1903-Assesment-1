using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {

        string answer;
        //Handles the reporting of the analysis
        public void decision()
        {
            Console.WriteLine("Welcome to my analyse program. Would you like to analyse a downloaded file or enter some text manualy? Enter 'file' for the first option or 'manual' for the second option.");

            answer = Console.ReadLine();
        }
        public void report()
        {



            if (answer == "manual")
            {
                Input I1 = new Input();
                string TEXT = I1.manualTextInput();
                Analyse a1 = new Analyse();
                a1.analyseText(TEXT);
                a1.analyseTextt();
            }
            if (answer == "Manual")
            {
                Input I1 = new Input();
                string TEXT = I1.manualTextInput();
                Analyse a1 = new Analyse();
                a1.analyseText(TEXT);
                a1.analyseTextt();
            }
            if (answer == "file")
            {
                Input I1 = new Input();
                string TEXT = I1.fileTextInput("");

                Analyse a1 = new Analyse();
                a1.analyseText(TEXT);
                a1.analyseTextt();
            }
            if (answer == "File")
            {
                Input I1 = new Input();
                string TEXT = I1.fileTextInput("");

                Analyse a1 = new Analyse();
                a1.analyseText(TEXT);
                a1.analyseTextt();
            }

        }
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

    }
}
