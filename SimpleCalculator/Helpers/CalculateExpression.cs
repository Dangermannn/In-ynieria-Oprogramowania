using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SimpleCalculator.Helpers
{
    public static class CalculateExpression
    {
        public static string Calculate(string expression) => EvaluateRPN(ConvertToRPN(expression));
        public static string EvaluateRPN(string rnpExpression)
        {
            string[] tokens = rnpExpression.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            Stack<long> stack = new Stack<long>();
            long number = 0;

            foreach(var token in tokens)
            {
                if (long.TryParse(token, out number))
                    stack.Push(number);
                else
                {
                    switch(token)
                    {
                        case "+":
                            stack.Push(stack.Pop() + stack.Pop());
                            break;
                        case "-":
                            var num = stack.Pop();
                            stack.Push(stack.Pop() - num);
                            break;
                        case "*":
                            stack.Push(stack.Pop() * stack.Pop());
                            break;
                        case "/":
                            var num1 = stack.Pop();
                            var num2 = stack.Pop();
                            if (num1 == 0)
                                return "Cannot divide by 0";
                            stack.Push(num2 / num1);
                            break;
                        default:
                            throw new SyntaxErrorException("Syntax error");
                    }
                }
            }

            return stack.Pop().ToString();
        }

        public static string ConvertToRPN(string input)
        {
            Stack<char> stack = new Stack<char>();
            string str = input.Replace(" ", "");
            StringBuilder formula = new StringBuilder();
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    char x = str[i];
                    if (x == '(')
                        stack.Push(x);
                    else if (x == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                        {
                            formula.Append(' ');
                            formula.Append(stack.Pop());
                        }
                        stack.Pop();
                    }
                    else if (IsNumber(x))
                        formula.Append(x);
                    else if (IsOperator(x))
                    {
                        formula.Append(' ');
                        while (stack.Count > 0 && stack.Peek() != '(' && Priority(x) <= Priority(stack.Peek()))
                        {
                            formula.Append(stack.Pop());
                            formula.Append(' ');
                        }
                        stack.Push(x);
                        formula.Append(' ');
                    }
                }
                while (stack.Count > 0)
                {
                    formula.Append(' ');
                    formula.Append(stack.Pop());
                }
            }
            catch(Exception)
            {
                throw new SyntaxErrorException("Syntax error");
            }
            return formula.ToString().Trim().Replace("  ", " ");
        }

        private static bool IsOperator(char sign) =>
            sign == '*' || sign == '/' || sign == '+' || sign == '-';

        private static bool IsNumber(char sign) =>
            sign >= '0' && sign <= '9';

        private static int Priority(char c)
        {
            switch (c)
            {
                case '+':
                    return 1;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 2;
                default:
                    throw new ArgumentException("Invalid parameter");
            }
        }

    }

}
