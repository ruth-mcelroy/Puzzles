using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLab6
{
    public static class Cipher
    {

       public static string EncodeCaeser(String sentence)
        {
            string code = "";
           
           for(int i = 0; i< sentence.Length; i++)
           {
                if (sentence[i].Equals(' '))
                {
                    code += " ";
                    i++;
                }
               int unicodeValue = Convert.ToInt32(sentence[i]);
               unicodeValue++;
               code += Convert.ToChar(unicodeValue);  
           }
           return code;
        }


        public static string UnencodeCaeser(String sentence)
       {
           string code = "";

           for (int i = 0; i < sentence.Length; i++)
           {
               if (sentence[i].Equals(' '))
               {
                   code += " ";
                   i++;
               }
               int unicodeValue = Convert.ToInt32(sentence[i]);
               unicodeValue--;
               code += Convert.ToChar(unicodeValue);
           }
           return code;
       }


        public static string EncodeReverse(String sentence)
        {
            string answer = "";
            char[] newSentence = new char[sentence.Length];

            int i = 0;
            int j = sentence.Length -1;
            while (i < j)
            {
                newSentence[i] = sentence[j];
                newSentence[j] = sentence[i];
                i++;
                j--;
            }
            foreach( char c in newSentence)
            {
                answer += c;
            }
            return answer;
        }

    }
}
