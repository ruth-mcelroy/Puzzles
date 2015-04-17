using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLab6
{
    public class Test
    {
        public delegate string EncodeDelegate(string sentence);

        static void Main()
        {
            string test = "AB CDE";
            Console.WriteLine(test);
            test = Cipher.EncodeCaeser(test);
            Console.WriteLine(test);
            test = Cipher.UnencodeCaeser(test);
            Console.WriteLine(test);

            test = "AB CDE";
            Console.WriteLine(test);
            test = Cipher.EncodeReverse(test);
            Console.WriteLine(test);

            EncodeDelegate Encode;

            Encode = Cipher.EncodeCaeser;
            test = "AB CDE";
            Console.WriteLine(Encode(test));

        }
    }
}
