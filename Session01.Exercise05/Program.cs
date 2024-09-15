using MathLib;

namespace CalculatorApp {
    
    class Program{
        
        static void Main(string[] args){

            Calculator calc = new Calculator();

            int sum1 = calc.Add(10, 20);
            Console.WriteLine($"The sum of 10 and 20 is: {sum1}");

            int[] numbers = {1, 2, 3, 4, 5};
            int sum2 = calc.Add(numbers);
            Console.WriteLine($"The sum of numbers array is: {sum2}");

            calc.DisplayMax();
        }
    }
}