using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CrackingTheCodingInterview_1_Arrays_and_Strings_Tests
{
    public class Question1_4
    {
        public bool isPalindrome(string s)
        {

            //After thinking about the problem for a while it occured to me that we only need to know if we the instance count of the characters is 1) every character is even, or all even character instances and 1 character that has a count of 1.

            string noSpace = s.Replace( " ", String.Empty);
            List<char> check = new List<char>();
            foreach( char c in noSpace)
            {

                if (check.Contains(c))
                    check.Remove(c);
                else
                    check.Add(c);

            }

            if (check.Count <= 1)
                return true;
            else
                return false;
        }


        [Test]
        [TestCase(false, "abc")]
        [TestCase(true, "abba")]
        [TestCase(false, "horses")]
        [TestCase(true, "taco cat")]
        [TestCase(false, "pppasdflol")]
        public void IsPalindrome_TEST(bool expected, string s)
        {
            Assert.AreEqual(isPalindrome(s), expected);
        }

    }
}
