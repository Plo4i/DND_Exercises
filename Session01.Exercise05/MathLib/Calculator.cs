namespace MathLib
{
    public class Calculator{
        public int Add(int a, int b){
            return a + b;
        }

        public int Add(params int[] numbers) {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public void DisplayMax(){
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(num1, num2);

            Console.WriteLine($"The max of {num1} and {num2} is {max}");
        }
    }
}