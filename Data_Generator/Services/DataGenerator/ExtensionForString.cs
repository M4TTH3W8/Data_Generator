using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Generator.Services.DataGenerator
{
    public static class ExtensionsForString
    {
        private static Randomizer r = new Randomizer();

        public static string ClampLength(this string str, int? min = null, int? max = null)
        {
            if (max != null && str.Length > max)
            {
                return str.Substring(0, max.Value);
            }
            if (min != null && min > str.Length)
            {
                var missingChars = min - str.Length;
                //var fillerChars = r.Replace("".PadRight(missingChars.Value, '?'));
                return str;// + fillerChars;
            }
            return str;
        }
    }
}
