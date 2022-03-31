using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        public bool Possible = false;
        //Handles the text input for Assessment 1
        string text = "nothing.";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        //The console will read the line of text the user entered and send it to be analysed
        public string manualTextInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter the text you would like to be analysed.");
            Console.WriteLine("");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        //This will get the .txt file and gather all of the string within it and send it to be analysed
        public string fileTextInput(string fileName)
        {
            Console.WriteLine("");
            Console.WriteLine("Please prvide a file path to your txt file?(P.S There should be an example txt files with the name of Example.txt, Example2.txt, Example3.txt you can test out)");
            Console.WriteLine("");
            fileName = Console.ReadLine();
            if(File.Exists(fileName))//This is to make sure the file exists on the device it is being ran on
            {
                text = File.ReadAllText(fileName);
                Possible = true;
            }
            else//This is to make sure the file exists on the device it is being ran on
            {
                //Console.WriteLine("");
                //Console.WriteLine("File was not detected.");
                //Console.WriteLine("");
                Possible = false;
                
 
            }
            
            return text;
        }

    }
}
