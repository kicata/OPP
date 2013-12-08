using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace _01_ExtSubstring
{
    class testSustrExtend
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Portokal");
            StringBuilder result = sb.Substring(6, 2);
            Console.WriteLine(result.ToString());
        }
        string proba = String.Empty;
    }
}
