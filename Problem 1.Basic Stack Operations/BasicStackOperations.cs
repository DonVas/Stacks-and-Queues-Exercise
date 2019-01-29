using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1.Basic_Stack_Operations
{
   public static class BasicStackOperations
   {
       public static void Main()
       {
           int[] tokens = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

           //number of stack elements
           int numberOfElements = tokens[0];
           // number of elements to be pop(out and remove)
           int elementsToPop = tokens[1];
           //find if exist elemnet
           int elementToFind = tokens[2];


           Stack<int> stack = new Stack<int>();
           int[] elemntstOfstack = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

           for (int i = 0; i < numberOfElements; i++)
           {
               stack.Push(elemntstOfstack[i]);
           }

           for (int i = 0; i < elementsToPop; i++)
           {
               stack.Pop();
           }

           if (stack.Count() == 0)
           {
               Console.WriteLine(0);
           }
           else if (stack.Contains(elementToFind))
           {
               Console.WriteLine("true");
           }
           else
           {
               int[] minVaues = stack.ToArray();
               int minIntValue = minVaues.Min();
               Console.WriteLine(minIntValue);
           }

       }
    }
}
