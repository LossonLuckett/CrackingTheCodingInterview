using NUnit.Framework;
using System.Collections.Generic;


namespace CrackingTheCodingInterview_1_Arrays_and_Strings_Tests
{
    public class Question1_1
    {
        public static bool AllUniqueCharactersWithDataStructure(string s)
        {
            List<char> characters = new List<char>();

            foreach (char c in s)
            {
                if (characters.Contains(c))
                {
                    return false;
                }
                characters.Add(c);
            }
            return true;
        }


        [Test]
        [TestCase(true, "abc")]
        [TestCase(false, "abbc")]
        [TestCase(false, "horses")]
        public void AllUniqueCharactersWithDataStructure_TEST(bool expected, string s) 
        {
            Assert.AreEqual(AllUniqueCharactersWithDataStructure(s), expected);
        }






        public static bool AllUniqueCharactersWithoutDataStructure(string s)
        {
            int size = s.Length;
            for(int i = 0; i < size; i++)
            {
                for(int k = i + 1; k < size; k++)
                {
                    if (s[i] == s[k])
                        return false;
                }
            }
            return true;
        }

        [Test]
        [TestCase(true, "abc")]
        [TestCase(false, "abbc")]
        [TestCase(false, "horsee")]
        public void AllUniqueCharactersWithoutDataStructure_TEST(bool expected, string s)
        {
            Assert.AreEqual(AllUniqueCharactersWithoutDataStructure(s), expected);
        }
    }
}