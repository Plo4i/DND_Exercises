class Program {
    // Print even numbers
    static void PrintEvenNumbers(int x){
        for (int i = 0; i < x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Even number: {i}");
            }
        }
    }

    // Print uneven numbers
    static void PrintUnevenNumbers(int x){
        for (int i = 0; i < x; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"Uneven number: {i}");
            }
        }
    }

    // Print numbers devisible by y
    static void PrintNumbersDevisibleByY(int x, int y){
        for (int i = 1; i < x; i++)
        {
            if (i % y == 0)
            {
                Console.WriteLine($"Numbers devisible by y: {i}");
            }
        }
    }

    static void Main(string[] args){
        int x = 20;
        int y = 2;

        PrintEvenNumbers(x);
        PrintUnevenNumbers(x);
        PrintNumbersDevisibleByY(x, y);
    }
}