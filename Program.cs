using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Bracket_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>
            {
                "((()))",
                "",
                "(){}[]",
                "({[]})",
                "{{]]",
                "[](",
                "{1}",
                "{}([])",
                "}{",
                "     ",
                "(){([])}",
                "()[]{})"
            };
            for(int test = 0; test < elements.Count; ++test)
            {
                Console.WriteLine($"Test №{test+1}: \"{elements[test]}\" result: {Test(elements[test])}");
            }
 
            Console.ReadLine();
        }

        static bool Test(string elements)
        {
            Stack<char> stack = new Stack<char>(elements.Length);

            for (int step = 0; step < elements.Length; ++step)
            {
                switch(elements[step])
                {
                    case ')' when stack.top == -1:
                    case '}' when stack.top == -1:
                    case ']' when stack.top == -1:
                        return false;

                    case '(':
                    case '{':
                    case '[':
                        stack.Push(elements[step]);
                        break;

                    case ')' when stack.Top == '(':
                    case '}' when stack.Top == '{':
                    case ']' when stack.Top == '[':
                        stack.Pop();
                        break;

                    case ')' when stack.Top != '(':
                    case '}' when stack.Top != '{':
                    case ']' when stack.Top != '[':
                        return stack.StackEmpty;
                }
            }

            return stack.StackEmpty;
        }
    }
}
