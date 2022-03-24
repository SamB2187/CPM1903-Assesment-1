using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
       
        //Handles the analysis of text

        //Method: analyseText

        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public void analyseText(string input)
        {
            List<int> values = new List<int>();

            //List of integers to hold the first five measurements:
            //1. Number of sentences



            //1. Sentences
            int sentences = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string sentence = input[i].ToString();

                if (".?!".Contains(sentence))
                {
                    sentences++;
                }
                
            }
            values.Add(sentences);

            //2. Vowels
            int vowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                string vowel = input[i].ToString();
                if ("aeiouAEIOU".Contains(vowel))
                {
                    vowels++;
                }
                
            }
            values.Add(vowels);

            //3. Consonants
            int consonants = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                string vowel = input[i].ToString();
                if ("B,C,D,F,G,J,K,L,M,N,P,Q,S,T,V,X,Z,H,R,W,Y".Contains(vowel))
                {
                    consonants++;
                }
                
            }
            values.Add(consonants);

            //4. Upper Case Letters
            int UpperCaseLetters = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                string UCL = input[i].ToString();
                if ("A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z".Contains(UCL))
                {
                    UpperCaseLetters++;
                }
                
            }
            values.Add(UpperCaseLetters);

            //5. Lower Case letters
            int LowerCaseLetters = 0;
            for (int i = 0; i < input.Length; i++)
            {
               
                string LCL = input[i].ToString();
                if ("a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Contains(LCL))
                {
                    LowerCaseLetters++;
                }
                
            }
            values.Add(LowerCaseLetters);

            var report = new Report();
            report.analyseText(values);







        }

    }   
 
            
          

}
