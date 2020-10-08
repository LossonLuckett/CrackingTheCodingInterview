using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CrackingTheCodingInterview_1_Arrays_and_Strings_Tests.Chapter_2_Linked_Lists
{
    public class Question2_1
    {

        public static LinkedList<int> removeDups(LinkedList<int> N)
        {

            if (N.Count == 0)
                return null;

            LinkedListNode<int> traverse = N.First;
            List<int> uniqueChar = new List<int>();

            while (traverse.Next != null)
            {
                if (uniqueChar.Contains(traverse.Value) == false)
                {
                    uniqueChar.Add(traverse.Value);
                }
                traverse = traverse.Next;

            }

            LinkedList<int> removedDuplicates = new LinkedList<int>();

            foreach (int i in uniqueChar)
            {
                removedDuplicates.AddLast(i);
            }

            return removedDuplicates;
        }

    }
}
