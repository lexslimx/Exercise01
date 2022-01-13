using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public static class Exercise01
    {
        private static string[] belowTen = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private static string[] belowTwenty = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static string[] belowHundred = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public static string Towards(this long num)
        {
            if (num == 0) return "Zero";
            return Helper(num);
        }
        private static string Helper(long num)
        {
            if (num < 10) return belowTen[num];
            if (num < 20) return belowTwenty[num % 10];
            if (num < 100) return $"{belowHundred[num / 10]} {belowTen[num % 10]}".Trim();
            if (num < 1000) return $"{Helper(num / 100)} Hundred {Helper(num % 100)}".Trim();
            if (num < 1000000) return $"{Helper(num / 1000)} Thousand {Helper(num % 1000)}".Trim();
            if (num < 1000000000) return $"{Helper(num / 1000000)} Million {Helper(num % 1000000)}".Trim();
            if (num < 10000000000) return $"{Helper(num / 10000000)} Billion {Helper(num % 10000000)}".Trim();
            if (num < 100000000000) return $"{Helper(num / 100000000)} Trillion {Helper(num % 10000000)}".Trim();
            if (num < 1000000000000) return $"{Helper(num / 1000000000)} Billion {Helper(num % 1000000000)}".Trim();
            if (num < 10000000000000) return $"{Helper(num / 10000000000)} Quadrillion {Helper(num % 10000000000)}".Trim();            
            return $"{Helper(num / 100000000000)} Quintrillion {Helper(num % 100000000000)}".Trim();
        }
    }
}
