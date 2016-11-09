using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNameClass
{
    public static class NumberClass
    {
        private  static  string[] numberName = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seveteen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private static long[] rate = new long[] { 100, 1000, 1000000, 1000000000 };
        private static string[] ratename = new[] { "hundred", "thousand", "million", "billion" };

        public static string NumberName(long number)
        {
            string result = "";
            for (int i = 0; i < rate.Length; i++)
            {
                if (number == rate[i])
                    return "one " + ratename[i];
            }
            //1-999
            if (number < 1000)
            {
                result = IntegerRemainder(number);
            }
            //1000-999999
            if (number >= 1000)
            {
                for (int i = rate.Length - 1; i > 0; i--)
                {
                    if (number/rate[i] > 0)
                    {
                        result = result + IntegerMultiples(number) ;
                        number = number%rate[i];
                        if(number>999)
                             result= result+" and "; ;
                        if (number == 0)
                            return result;
                    }
                }
                result = result + " and " + IntegerRemainder(number);
            }
            
            return result;
        }

        private static string IntegerMultiples(long number)
        {
            string result = "";
            for (int i = rate.Length-1; i > 0; i--)
            {
                if (number/rate[i] > 0)
                {
                    if (number/rate[i] >= 100)
                    {
                        result = numberName[number/rate[i]/100] + " " + ratename[0];
                    }
                    if (number/rate[i]%100 > 20)
                    {
                        if (number/rate[i] >= 100)
                            result = result + " and ";
                        result = result + numberName[number/rate[i]%100/10 + 18];
                        result = result + " " + numberName[number/rate[i]%100%10];
                    }
                    if (number/rate[i]%100 <= 20 && number/rate[i]%100 > 0)
                    {
                        if (number/rate[i] >= 100)
                            result = result + " and ";
                        result = result + numberName[number/rate[i]%100];
                    }
                    result = result + " " + ratename[i];

                    break;
                }
            }
            return result;
        } 

        private static string IntegerRemainder(long number)
        {
            string result = "";

            if (number <= 20)
            {
                result = numberName[number];
            }
            if (number > 20 && number < 100)
            {
                result = numberName[number / 10 + 18];
                if (number % 10 > 0)
                {
                    result = result + " " + numberName[number % 10];
                }
            }
            if (number >= 100)
            {
                result = numberName[number/100] + " " + ratename[0];
                if (number%100 > 20)
                {
                    result = result + " and " + numberName[number%100/10 + 18];
                    result = result + " " + numberName[number%10];
                }
                if (number%100 <= 20 && number%100 > 0)
                {
                    result = result + " and " + numberName[number%100];
                }
            }
            return result;
        }
    }
}
