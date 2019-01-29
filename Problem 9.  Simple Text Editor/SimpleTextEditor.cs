using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_9.__Simple_Text_Editor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            StringBuilder text = new StringBuilder();

            int commandsCount = int.Parse(Console.ReadLine());
            Stack<string> backUp = new Stack<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "1":
                        backUp.Push(text.ToString());
                        text.Append(commands[1]);
                        break;
                    case "2":
                        backUp.Push(text.ToString());
                        int remove = int.Parse(commands[1]);
                        text.Remove(text.Length - remove, remove);
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;
                    case "4":
                        if (text.ToString() == backUp.Peek())
                        {
                            backUp.Pop();
                        }

                        text.Clear();
                        text.Append(backUp.Pop());
                        break;
                }
            }
        }
    }
}
