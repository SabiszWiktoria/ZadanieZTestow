using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania
{

    public class TwoToOne
    {

        public static string Longest(string s1, string s2)
        {
            string d = SortDistinctChars(s1);
            string d2 = SortDistinctChars(s2);
            if (d.Length > d2.Length)
            {
                return d;
            }
            return d2;
        }

        public static string SortDistinctChars(string str)
        {
            int length = str.Length;

            List<char> result = new List<char>(str.ToCharArray());
            
            result.Sort();
            for (int i = length-1 ; i > 0; i--)
            {
                if (result[i] == result[i - 1])
                {
                    result.Remove(result[i-1]);
                }
                
            }

            return string.Join( "", result);
        }
    }
}
