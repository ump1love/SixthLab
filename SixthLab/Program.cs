class Program
{


    public static void Main()
    {
        MathOperations math = new MathOperations();


        List<List<int>> firstMatrix = new List<List<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 10, 3 }
        };

        List<List<int>> secondMatrix = new List<List<int>>
        {
            new List<int> { 3, 4 },
            new List<int> { 5, 6 }
        };

        List<List<List<int>>> firstTensor = new List<List<List<int>>>
        {
            new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 3, 4 }
            },
            new List<List<int>>
            {
                new List<int> { 5, 6 },
                new List<int> { 7, 8 }
            }
        };

        List<List<List<int>>> secondTensor = new List<List<List<int>>>
        {
            new List<List<int>>
            {
                new List<int> { 9, 10 },
                new List<int> { 11, 12 }
            },
            new List<List<int>>
            {
                new List<int> { 13, 14 },
                new List<int> { 15, 16 }
            }
        };


        math.Add(1, 2);
        math.Subtract(3,4);
        math.Divide(5, 0);
        math.Divide(6, 1);
        math.Multiply(7, 2);
        Line();

        math.Add(new List<double> { 1, 2, 10 }, new List<double> { 3, 4 });
        math.Add(new List<double> { 1, 2 }, new List<double> { 3, 4 });
        math.Subtract(new List<double> { 1, 2 }, new List<double> { 3, 4 });
        math.Divide(new List<double> { 1, 2 }, new List<double> { 3, 4 });
        math.Divide(new List<double> { 1, 2 }, new List<double> { 0, 4 });
        math.Multiply(new List<double> { 1, 2 }, new List<double> { 3, 4 });
        Line();

        math.Add(firstMatrix, secondMatrix);
        math.Subtract(firstMatrix, secondMatrix);
        math.Divide(firstMatrix, secondMatrix);
        math.Multiply(firstMatrix, secondMatrix);
        Line();

        math.Add(firstTensor, secondTensor);
        math.Subtract(firstTensor, secondTensor);
        math.Divide(firstTensor, secondTensor);
        math.Multiply(firstTensor, secondTensor);
        Line();

    }
    private static void Line()
    {
        for (int i = 0; i < 50; i++) { Console.Write('-'); }
        Console.WriteLine();
    }
}