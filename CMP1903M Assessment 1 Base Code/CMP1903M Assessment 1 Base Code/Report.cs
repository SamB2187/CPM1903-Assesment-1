using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {

        public void analyseText(List<int> check)
        {
        
            Console.WriteLine($"Sentences: {check[0]}\n" +
                  $"Vowels: {check[1]}\n" +
                  $"Consonants: {check[2]}\n" +
                  $"Uppercase Letters: {check[3]}\n" +
                  $"Lowercase Letters: {check[4]}\n");
                 

            Console.ReadLine();
        }

    }
}
