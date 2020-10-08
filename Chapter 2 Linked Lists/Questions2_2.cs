using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.Chapter_2_Linked_Lists
{
    public class Questions2_2
    {


        public LinkedListNode<int> KthFromLast(LinkedList<int> N, int index)
        {

            LinkedListNode<int> traversal = N.First;
            LinkedListNode<int> targetIndex = null;
            int target = N.Count - index;

            for (int i = 0; i < N.Count; i++)
            {
                if (i == target)
                    targetIndex.Value = traversal.Value;

                traversal = traversal.Next;
            }
            return targetIndex;
        }
    
      

        }
    }

