using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms
{
    public static class Calculator
    {
        public static double Calculate(string expression)
        {
            var operands = Regex
                .Split(expression, "(\\(|\\)|\\d+|\\w+|\\S)")
                .Where(ch => ch != "" && ch != " ");
            
            var values = new Stack<double>();
            var operations = new Stack<string>();

            foreach (var s in operands)
            {
                if (s is "+" or "-" or "*" or "/" or "sqrt")
                {
                    operations.Push(s);
                } 
                else if (s == ")")
                {
                    var op = operations.Pop();
                    var v = values.Pop();

                    switch (op)
                    {
                        case "+":
                            v = values.Pop() + v;
                            break;
                        case "-":
                            v = values.Pop() - v;
                            break;
                        case "*":
                            v = values.Pop() * v;
                            break;
                        case "/":
                            v = values.Pop() / v;
                            break;
                        case "sqrt":
                            v = Math.Sqrt(v);
                            break;
                    }
                    
                    values.Push(v);
                }
                else if (double.TryParse(s, out _))
                {
                    values.Push(double.Parse(s));
                }
            }
            
            
            return values.Pop();
        }
    }
}