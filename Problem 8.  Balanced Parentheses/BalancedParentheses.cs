using System;
using System.Collections.Generic;

namespace Problem_8.__Balanced_Parentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            string perent = Console.ReadLine().Trim();

            Queue<char> leftSide = new Queue<char>();
            Stack<char> rightSide = new Stack<char>();

            bool isItSemetric = false;


            for (int i = 0; i < perent.Length / 2; i++)
            {
                leftSide.Enqueue((char)perent[i]);
            }
            for (int i = perent.Length / 2; i < perent.Length; i++)
            {
                rightSide.Push((char)perent[i]);
            }

            for (int i = 0; i < perent.Length / 2; i++)
            {
                char left = leftSide.Dequeue();
                char right = rightSide.Pop();

                if (left == right - 2 || left == '(' && right == ')')
                {
                    isItSemetric = true;
                }
                else
                {
                    isItSemetric = false;
                    break;
                }
            }

            if (isItSemetric)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
