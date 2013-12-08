using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtSubstring
{
    public static class SustringExtend
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index+length; i++)
            {
                result.Append(sb[i]);
            }
            return result;
        }

    }
}
