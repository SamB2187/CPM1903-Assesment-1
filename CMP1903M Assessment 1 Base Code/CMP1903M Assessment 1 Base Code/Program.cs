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
        static void Main()
        {

            Report report = new Report();
            //This will give the user the decision on what they want to ananlyse
            report.decision();
            //This will give anylsed information back to the user
            report.report();

        }
        
        
    
    }
}
