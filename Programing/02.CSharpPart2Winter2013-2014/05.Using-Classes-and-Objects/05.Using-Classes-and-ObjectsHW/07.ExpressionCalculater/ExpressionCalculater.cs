namespace _07.ExpressionCalculater
{
    using System;
    using System.Collections.Generic;

    class ExpressionCalculater
    {
        //07.* Write a program that calculates the value of given arithmetical expression. 
        //The expression can contain the following elements only:
        //Real numbers, e.g. 5, 18.33, 3.14159, 12.6
        //Arithmetic operators: +, -, *, / (standard priorities)
        //Mathematical functions: ln(x), sqrt(x), pow(x,y)
        //Brackets (for changing the default priorities)

        static Dictionary<char, int> operatorPriority = new Dictionary<char, int>() 
            { 
                { '+', 1 }, 
                { '-', 1 }, 
                { '*', 2 }, 
                { '/', 2 }
            };

        static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

        static char funcArgumentSeparetor = ',';

        static void Main()
        {
            //string expresion = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";
            string expresion = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
            

            var tokens = Tokenezer(expresion);
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            var tokensRPN = ConvertToRPN(tokens);

            double result = CalcExpresion(tokensRPN);

            Console.WriteLine("{0} = {1}", expresion, result);

        }

        static double CalcExpresion(Queue<string> tokensRPN)
        {
            Stack<double> progStack = new Stack<double>();

            while (tokensRPN.Count > 0)
            {
                string token = tokensRPN.Dequeue();

                if (IsNumber(token))
                {
                    progStack.Push(double.Parse(token));
                }
                else if (token == "+")
                {
                    if (progStack.Count < 2)
                    {
                        throw new FormatException("Not enough arguments for adding.");
                    }
                    double op1 = progStack.Pop(),
                        op2 = progStack.Pop();

                    progStack.Push(op2 + op1);
                }
                else if (token == "-")
                {
                    if (progStack.Count < 2)
                    {
                        throw new FormatException("Not enough arguments for subtracting.");
                    }

                    double op1 = progStack.Pop(),
                        op2 = progStack.Pop();

                    progStack.Push(op2 - op1);
                }
                else if (token == "*")
                {
                    if (progStack.Count < 2)
                    {
                        throw new FormatException("Not enough arguments for multiplying.");
                    }

                    progStack.Push(progStack.Pop() * progStack.Pop());
                }
                else if (token == "/")
                {
                    if (progStack.Count < 2)
                    {
                        throw new FormatException("Not enough arguments for dividing.");
                    }
                    double op1 = progStack.Pop(),
                        op2 = progStack.Pop();

                    progStack.Push(op2 / op1);
                }
                else if (token == "ln")
                {
                    if (progStack.Count == 0)
                    {
                        throw new FormatException("Not enough argumets for ln");
                    }

                    progStack.Push(Math.Log(progStack.Pop()));
                }
                else if (token == "pow")
                {
                    if (progStack.Count < 2)
                    {
                        throw new FormatException("Not enough arguments for pow.");
                    }
                    double op1 = progStack.Pop(),
                        op2 = progStack.Pop();
                    
                    progStack.Push(Math.Pow(op2, op1));
                }
                else if (token == "sqrt")
                {
                    if (progStack.Count == 0)
                    {
                        throw new FormatException("Not enough arguments for sqrt.");
                    }

                    progStack.Push(Math.Sqrt(progStack.Pop()));
                }
            }

            return progStack.Pop();
        }

        static Queue<string> ConvertToRPN(List<string> tokens)
        {
            Queue<string> output = new Queue<string>();
            Stack<string> operatorStack = new Stack<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                if (IsNumber(tokens[i]))
                {
                    output.Enqueue(tokens[i]);
                }
                else if (functions.Contains(tokens[i]))
                {
                    operatorStack.Push(tokens[i]);
                }
                else if (tokens[i] == funcArgumentSeparetor.ToString())
                {
                    try
                    {
                        while (operatorStack.Peek() != "(")
                        {
                            output.Enqueue(operatorStack.Pop());
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        throw new FormatException("The function separator is misplaced or parentheses are mismatched.");
                    }
                }
                else if (operatorPriority.ContainsKey(tokens[i][0]))
                {
                    while (operatorStack.Count > 0 && 
                        ((operatorPriority.ContainsKey(operatorStack.Peek()[0]) && 
                        operatorPriority[tokens[i][0]] <= operatorPriority[operatorStack.Peek()[0]]) || functions.Contains(operatorStack.Peek())))
                    {
                        output.Enqueue(operatorStack.Pop());
                    }

                    operatorStack.Push(tokens[i]);
                }
                else if (tokens[i] == "(")
                {
                    operatorStack.Push(tokens[i]);
                }
                else if (tokens[i] == ")")
                {
                    try
                    {
                        while (operatorStack.Peek() != "(")
                        {
                            output.Enqueue(operatorStack.Pop());
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        throw new FormatException("There are mismatched parenthese.");
                    }

                    operatorStack.Pop();
                }
            }
            while (operatorStack.Count > 0)
            {
                if (operatorStack.Peek() == "(" || operatorStack.Peek() == ")")
                {
                    throw new FormatException("There are mismatched parenthese.");
                }

                output.Enqueue(operatorStack.Pop());
            }

            return output;
        }

        private static bool IsNumber(string p)
        {
            double number = 0;
            return double.TryParse(p, out number);
        }

        static List<string> Tokenezer(string exp)
        {
            List<string> tokens = new List<string>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (Char.IsWhiteSpace(exp[i]))
                {
                    continue;
                }

                if (Char.IsLetter(exp[i])) // function
                {
                    string funcName = ProcessFuncName(exp, ref i);

                    tokens.Add(funcName);
                }
                else if (Char.IsDigit(exp[i]))
                {
                    string num = ProcessNumber(exp, ref i);

                    tokens.Add(num);
                }
                else if (exp[i] == '-')
                {
                    i++;
                    if (i < exp.Length && Char.IsDigit(exp[i]))
                    {
                        string num = '-' + ProcessNumber(exp, ref i);

                        tokens.Add(num);
                    }
                    else
                    {
                        tokens.Add("-");
                    }
                }
                else
                {
                    tokens.Add(exp[i] + "");
                }

            }

            return tokens;
        }

        private static string ProcessNumber(string exp, ref int i)
        {
            string num = String.Empty;

            while (i < exp.Length && (Char.IsDigit(exp[i]) || exp[i] == '.'))
            {
                num += exp[i];
                i++;
            }
            i--;
            return num;
        }

        private static string ProcessFuncName(string exp, ref int i)
        {
            string funcName = String.Empty;

            while (i < exp.Length && Char.IsLetter(exp[i]))
            {
                funcName += exp[i];
                i++;
            }
            i--;
            return funcName;
        }
    }
}
