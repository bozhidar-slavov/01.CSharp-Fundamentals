using System;

class Expression
{
    static void Main()
    {
        string expression = Console.ReadLine();

        decimal result = 0;
        decimal currentBracketResult = 0;

        char currentOperator = '+';
        char currentBracketOperator = '+';

        bool inBracket = false;

        foreach (char symbol in expression)
        {
            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }

            if (symbol == ')')
            {
                inBracket = false;
                switch (currentOperator)
                {
                    case '+': result += currentBracketResult; break;
                    case '-': result -= currentBracketResult; break;
                    case '*': result *= currentBracketResult; break;
                    case '/': result /= currentBracketResult; break;
                }

                currentBracketResult = 0;
                currentBracketOperator = '+';
            }

            if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')   
            {
                if (inBracket)
                {
                    currentBracketOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
            }

            if (Char.IsDigit(symbol))
            {
                int currentNumber = symbol - '0';       //converting symbol ascii code to number

                if (inBracket)
                {
                    switch (currentBracketOperator)
                    {
                        case '+': currentBracketResult += currentNumber; break;
                        case '-': currentBracketResult -= currentNumber; break;
                        case '*': currentBracketResult *= currentNumber; break;
                        case '/': currentBracketResult /= currentNumber; break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currentNumber; break;
                        case '-': result -= currentNumber; break;
                        case '*': result *= currentNumber; break;
                        case '/': result /= currentNumber; break;
                    }
                }
            }
        }

        Console.WriteLine("{0:F2}", result);
    }
}