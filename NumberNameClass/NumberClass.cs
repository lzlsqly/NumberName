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
            string[] numberName = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seveteen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand", "million", "billion", "trillion" };
            long[] rate = new long[]{ 1000000000, 1000000, 1000, 100, 10 };

            if (number<=20)
            {
                result = numberName[number];
                return result;
            }
            
            if (number > 20 && number<100)
            {
                result = numberName[number/100 + number/10 + 18] ;
                if (number%10 > 0)
                {
                    result = result + " " + numberName[number%10];
                }
               return result;
            }

            if (number >= 100 && number < 1000)
            {
                result = numberName[number / 100] + " " + numberName[number/1000 + 18 + 10];

                if (number % 100 > 0)
                {
                    if (number % 100 > 20)
                    {
                        result = result + " and " + numberName[number % 100 / 10 + 18];
                        result = result + " " + numberName[number % 10];
                    }
                    else
                    {
                        result = result + " and " + numberName[number % 100];
                    }
                }
                return result;
            }

            if (number >= 1000 && number < 1000000)
            {
                if (number/1000 > 99)
                {
                    result = numberName[number /1000/100] + " " + numberName[number / 1000000 + 18 + 10];
                    if (number/1000 % 100 > 20)
                    {
                        result = result + " and " + numberName[number / 1000 % 100 / 10 + 18];
                        result = result + " " + numberName[number / 1000 % 10];
                    }
                    else
                    {
                        if(number / 1000 %10>0)
                            result = result + " and " + numberName[number / 1000 % 10];
                    }
                }
                else if(number / 1000 > 20)
                {
                    result = result+ numberName[number / 1000/100 + number / 1000/10 + 18];
                    result = result + " " + numberName[number/ 1000 % 10];
                }
                else
                {
                    result = numberName[number / 1000];
                }
                result = result + " " + numberName[number / 1000000 + 18 + 10 + 1];

                if (number % 1000 > 99)
                {
                    result = result + " and " + numberName[number % 1000 / 100] + " " + numberName[number / 1000000 + 18 + 10];
                   
                    if (number % 1000 % 100 > 20)
                    {
                        result = result + " and " + numberName[number % 1000 % 100 / 10 + 18];
                        result = result + " " + numberName[number % 1000 % 10];
                    }
                    else
                    {
                        result = result + " and " + numberName[number % 1000 / 100];
                    }
                }
                else if (number % 1000 > 20)
                {
                    result = result + " and " + numberName[number % 1000 % 100 / 10 + 18];
                    result = result + " " + numberName[number % 1000 % 10];
                }
                else
                {
                    if(number % 1000 >0)
                        result = result + " and " + numberName[number % 100];
                }
            }
            return result;
        }
    }
}
