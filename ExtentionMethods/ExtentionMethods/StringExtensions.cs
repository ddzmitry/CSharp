using System;
using System.ComponentModel;
using System.Linq;

namespace ExtentionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new InvalidEnumArgumentException("The Number of words should be positive!");
            }
            if (numberOfWords == 0)
            {
                return "";
            }
            //Split into word array
            var words = str.Split(' ');
            //return short version
            return words.Length <= numberOfWords ? str : string.Join(" ",words.Take(numberOfWords));
        }

    }
}