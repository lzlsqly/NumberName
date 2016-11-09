using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberNameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNameClass.Tests
{
    [TestClass()]
    public class NumberClassTests
    {
        [TestMethod()]
        public void 当输入的整数大于等于0小于20的测试()
        {
            Assert.AreEqual(NumberClass.NumberName(0), "zero");
            Assert.AreEqual(NumberClass.NumberName(1), "one");
            Assert.AreEqual(NumberClass.NumberName(2), "two");
            Assert.AreEqual(NumberClass.NumberName(3), "three");
            Assert.AreEqual(NumberClass.NumberName(4), "four");
            Assert.AreEqual(NumberClass.NumberName(5), "five");
            Assert.AreEqual(NumberClass.NumberName(6), "six");
            Assert.AreEqual(NumberClass.NumberName(7), "seven");
            Assert.AreEqual(NumberClass.NumberName(8), "eight");
            Assert.AreEqual(NumberClass.NumberName(9), "nine");
            Assert.AreEqual(NumberClass.NumberName(10), "ten");
            Assert.AreEqual(NumberClass.NumberName(11), "eleven");
            Assert.AreEqual(NumberClass.NumberName(12), "twelve");
            Assert.AreEqual(NumberClass.NumberName(13), "thirteen");
            Assert.AreEqual(NumberClass.NumberName(14), "fourteen");
            Assert.AreEqual(NumberClass.NumberName(15), "fifteen");
            Assert.AreEqual(NumberClass.NumberName(16), "sixteen");
            Assert.AreEqual(NumberClass.NumberName(17), "seveteen");
            Assert.AreEqual(NumberClass.NumberName(18), "eighteen");
            Assert.AreEqual(NumberClass.NumberName(19), "nineteen");
        }
        [TestMethod()]
        
        public void 当输入整数小于100大于20测试()
        {
            Assert.AreEqual(NumberClass.NumberName(23), "twenty three");
            Assert.AreEqual(NumberClass.NumberName(34), "thirty four");
            Assert.AreEqual(NumberClass.NumberName(45), "forty five");
            Assert.AreEqual(NumberClass.NumberName(55), "fifty five");
            Assert.AreEqual(NumberClass.NumberName(66), "sixty six");
            Assert.AreEqual(NumberClass.NumberName(76), "seventy six");
            Assert.AreEqual(NumberClass.NumberName(87), "eighty seven");
            Assert.AreEqual(NumberClass.NumberName(93), "ninety three");
            Assert.AreEqual(NumberClass.NumberName(99), "ninety nine");
            Assert.AreEqual(NumberClass.NumberName(20), "twenty");
            Assert.AreEqual(NumberClass.NumberName(30), "thirty");
            Assert.AreEqual(NumberClass.NumberName(40), "forty");
            Assert.AreEqual(NumberClass.NumberName(50), "fifty");
            Assert.AreEqual(NumberClass.NumberName(60), "sixty");
            Assert.AreEqual(NumberClass.NumberName(70), "seventy");
            Assert.AreEqual(NumberClass.NumberName(80), "eighty");
            Assert.AreEqual(NumberClass.NumberName(90), "ninety");
        }

        [TestMethod()]

        public void 当输入整数小于1000大于20测试()
        {
            Assert.AreEqual(NumberClass.NumberName(100), "one hundred");
            Assert.AreEqual(NumberClass.NumberName(110), "one hundred and ten");
            Assert.AreEqual(NumberClass.NumberName(223), "two hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(114), "one hundred and fourteen");
            Assert.AreEqual(NumberClass.NumberName(345), "three hundred and forty five");
            Assert.AreEqual(NumberClass.NumberName(455), "four hundred and fifty five");
            Assert.AreEqual(NumberClass.NumberName(766), "seven hundred and sixty six");
            Assert.AreEqual(NumberClass.NumberName(676), "six hundred and seventy six");
            Assert.AreEqual(NumberClass.NumberName(987), "nine hundred and eighty seven");
            Assert.AreEqual(NumberClass.NumberName(893), "eight hundred and ninety three");
            Assert.AreEqual(NumberClass.NumberName(599), "five hundred and ninety nine");
            Assert.AreEqual(NumberClass.NumberName(509), "five hundred and nine");
        }

        [TestMethod()]

        public void 当输入整数小于100000大于等于1000测试()
        {
            Assert.AreEqual(NumberClass.NumberName(1000), "one thousand");
            Assert.AreEqual(NumberClass.NumberName(1001), "one thousand and one");
            Assert.AreEqual(NumberClass.NumberName(1021), "one thousand and twenty one");
            Assert.AreEqual(NumberClass.NumberName(1101), "one thousand and one hundred and one");
            Assert.AreEqual(NumberClass.NumberName(1232), "one thousand and two hundred and thirty two");
            Assert.AreEqual(NumberClass.NumberName(20000), "twenty thousand");
            Assert.AreEqual(NumberClass.NumberName(23000), "twenty three thousand");
            Assert.AreEqual(NumberClass.NumberName(23100), "twenty three thousand and one hundred");
            Assert.AreEqual(NumberClass.NumberName(23020), "twenty three thousand and twenty");
            Assert.AreEqual(NumberClass.NumberName(23120), "twenty three thousand and one hundred and twenty");
            Assert.AreEqual(NumberClass.NumberName(23123), "twenty three thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(235000), "two hundred and thirty five thousand");
            Assert.AreEqual(NumberClass.NumberName(235003), "two hundred and thirty five thousand and three");
            Assert.AreEqual(NumberClass.NumberName(653723), "six hundred and fifty three thousand and seven hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(200123), "two hundred thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(201123), "two hundred and one thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(201023), "two hundred and one thousand and twenty three");
            Assert.AreEqual(NumberClass.NumberName(201020), "two hundred and one thousand and twenty");
            Assert.AreEqual(NumberClass.NumberName(201003), "two hundred and one thousand and three");
        }
        [TestMethod()]

        public void 当输入整数小于1000000大于等于1000测试()
        {
            Assert.AreEqual(NumberClass.NumberName(6235000), "six million and two hundred and thirty five thousand");
            Assert.AreEqual(NumberClass.NumberName(6235123), "six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(236235123), "two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(6235000), "six million and two hundred and thirty five thousand");
            Assert.AreEqual(NumberClass.NumberName(6235123), "six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(1236235123), "one billion and two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(21236235123), "twenty one billion and two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(321236235123), "three hundred and twenty one billion and two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(1321236235123), "one trillion and three hundred and twenty one billion and two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(21321236235123), "twenty one trillion and three hundred and twenty one billion and two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");
            Assert.AreEqual(NumberClass.NumberName(321321236235123), "three hundred and twenty one trillion and three hundred and twenty one billion and two hundred and thirty six million and two hundred and thirty five thousand and one hundred and twenty three");

        }
        
    }
}