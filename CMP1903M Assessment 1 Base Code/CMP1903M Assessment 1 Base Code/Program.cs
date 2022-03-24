//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my analyse program. Would you like to analyse a downloaded file or enter some text manualy? Enter 'file' for the first option" +
            " or 'manual' for the second option.");

            var answer = Console.ReadLine();
            var program = new Program();
            answer.ToLower();
            var input = new Input();
            switch (answer)
            {
                case "manual":
                    input.ManualTextInput();
                    break;

                case "file":
                    input.fileTextInput();
                    break;
                default:
                    Console.WriteLine("Error Occured");
                    break;
            }
        }

        //eg.   public void outputConsole(List<int>)

    }
}
