﻿namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {

        try {

            InputConverter inputConverter = new InputConverter();

            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine(result);
        } catch (Exception ex) {
            // in the real world we would log this message 
            Console.WriteLine(ex.Message);
        }

    }
}
