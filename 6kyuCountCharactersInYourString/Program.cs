using System;
using System.Collections.Generic;
using System.Linq;

namespace _6kyuCountCharactersInYourString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "aavvs";

            var answer = Kata.Count(str);
        }
    }
 public class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(x => x)
                        .ToDictionary(x => x.Key, x => x.Count());
        }
    }
}
