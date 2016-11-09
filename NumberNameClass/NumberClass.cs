using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNameClass
{
    public static class NumberClass
    {
        public static string NumberName(long number)
        {
            string result = "";
            string[] numberName = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seveteen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            long[] rate = new long[]{ 1000000000, 1000000, 1000, 100, 10 };
            string[] ratename = new[] {"hundred", "thousand", "million", "billion", "trillion"};
            if (number<=20)
            {
                result = numberName[number];
                return result;
            }
            
            if (number > 20 && number<100)
            {
                result = numberName[number/10 + 18];
                if (number%10 > 0)
                {
                    result = result + " " + numberName[number%10];
                }
               return result;
            }

            if (number >= 100 && number < 1000)
            {
                result = numberName[number / 100] + " " + ratename[0];
                if (number % 100 > 20)
                {
                    result = result + " and " + numberName[number % 100 / 10 + 18];
                    result = result + " " + numberName[number % 10];
                }
                if(number %100 <=20 && number % 100 > 0)
                {
                    result = result + " and " + numberName[number % 100];
                }
                return result;
            }

            if (number >= 1000 && number < 1000000)
            {
                
                if (number/1000 >=100)
                {
                    result = numberName[number /1000/100] + " " + ratename[0];                    
                }
                if(number/1000 % 100 > 20)
                {
                    if (number/1000 >= 100)
                        result = result + " and ";
                    result = result + numberName[number / 1000 % 100 / 10 + 18];
                    result = result + " " + numberName[number / 1000 % 100 % 10];
                }
                if(number / 1000 % 100 <=20 && number /1000 % 100>0 )
                {
                    if (number / 1000 >= 100)
                        result = result + " and ";
                    result = result + numberName[number / 1000 %100];
                }

                result = result + " " + ratename[1];

                if (number % 1000 >=100)
                {
                    result = result + " and " + numberName[number % 1000 /100] + " " + ratename[0];
                }
                if (number % 1000 % 100 > 20)
                {
                    result = result + " and " + numberName[number % 1000 % 100 / 10 + 18];
                    result = result + " " + numberName[number % 1000 % 10];
                }
                if(number % 1000 % 100 <= 20 && number % 1000 % 100>0)
                {
                    result = result + " and " + numberName[number % 1000 % 100];
                }
            }
            return result;
        }
    }
}
