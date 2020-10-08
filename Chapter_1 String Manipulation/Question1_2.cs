using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CrackingTheCodingInterview_1_Arrays_and_Strings_Tests
{
    public class Question1_2
    {

        public static bool CheckPermutationWithDataStructure(string s1, string s2)
        {
            List<char> check = new List<char>();

            foreach (char c in s1)
                check.Add(c);


            foreach (char c in s2)
            {
                if (check.Contains(c) == false)
                    return false;
            }
            return true;
        }

        [Test]
        [TestCase(false, "abc", "abe")]
        [TestCase(true, "abbc", "bcba")]
        [TestCase(false, "horses", "schaer")]
        public void CheckPermutationWithDataStructure_TEST(bool expected, string s1, string s2)
        {
            Assert.AreEqual(CheckPermutationWithDataStructure(s1, s2), expected);
        }


    }
}
