namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1



        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public void ManualTextInput()
        {
            Console.WriteLine("Please enter the text you would like to be analysed.");
            var text = Console.ReadLine();
            var analyse = new Analyse();
            analyse.analyseText(text);
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public void fileTextInput()
        {
            Console.WriteLine("What is the name of the file?(P.S There should be an example txt files with the name of Example.txt, Example2.txt, Example3.txt you can test out)");
            string fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                var Text = System.IO.File.ReadAllText(fileName); //You will have to change this to where you place a text file
                var analyse = new Analyse();
                analyse.analyseText(Text);
            }
            else
            {
                Console.WriteLine("\nPath Not found\n");

            }


        }

    }
}
