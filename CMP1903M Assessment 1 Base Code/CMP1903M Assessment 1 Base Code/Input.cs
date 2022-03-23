﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing.";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Please enter the text you would like to be analysed.");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            Console.WriteLine("What is the name of the file?(P.S There should be an example txt files with the name of Example.txt, Example2.txt, Example3.txt you can test out)");
            fileName = Console.ReadLine();
            text = File.ReadAllText(fileName);
            return text;
        }

    }
}
