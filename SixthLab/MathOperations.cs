class MathOperations
{
    
    public void Add(double num1, double num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}\n");
    }
    public void Subtract(double num1, double num2)
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}\n");
    }
    public void Divide(double num1, double num2)
    {
        if (num2 != 0)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}\n");
        }
        else { Console.WriteLine("Cannot divide by zero\n"); }
    }
    public void Multiply(double num1, double num2)
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}\n");
    }

    public void Add(List<double> num1, List<double> num2)
    {
        if (num1.Count > num2.Count || num2.Count > num1.Count)
        {
            Console.Write("\nArrays must have the same length");
        }
        else
        {
            for (int i = 0; i < num1.Count; i++)
            {
                Console.Write($"|{num1[i]} + {num2[i]} = {num1[i] + num2[i]}|");
            }
        }
        Console.WriteLine('\n');
    }
    public void Subtract(List<double> num1, List<double> num2)
    {
        if (num1.Count > num2.Count || num2.Count > num1.Count)
        {
            Console.WriteLine("Arrays must have the same length\n");
        }
        else
        {
            for (int i = 0; i < num1.Count; i++)
            {
                Console.Write($"|{num1[i]} - {num2[i]} = {num1[i] - num2[i]}|");
            }
        }
        Console.WriteLine('\n');
    }
    public void Divide(List<double> num1, List<double> num2)
    {
        if (num1.Count > num2.Count || num2.Count > num1.Count)
        {
            Console.WriteLine("Arrays must have the same length\n");
        }
        else
        {
            for (int i = 0; i < num1.Count; i++)
            {
                if (num2[i] != 0) { Console.Write($"|{num1[i]} / {num2[i]} = {num1[i] / num2[i]}|"); }
                else { Console.WriteLine("Cannot divide by zero\n"); }
            }
        }
        Console.WriteLine('\n');
    }
    public void Multiply(List<double> num1, List<double> num2)
    {
        if (num1.Count > num2.Count || num2.Count > num1.Count)
        {
            Console.WriteLine("Arrays must have the same length\n");
        }
        else
        {
            for (int i = 0; i < num1.Count; i++)
            {
                Console.Write($"|{num1[i]} * {num2[i]} = {num1[i] * num2[i]}|");
            }
        }
        Console.WriteLine('\n');
    }
    
    public void Add(List<List<int>> matrix1, List<List<int>> matrix2)
    {
        Console.WriteLine("\n");
        if (matrix1.Count != matrix2.Count || matrix1[0].Count != matrix2[0].Count)
        {
            Console.WriteLine("Matrices must have the same dimensions for addition.");
        }
        else
        {
            for (int i = 0; i < matrix1.Count; i++)
            {
                for (int j = 0; j < matrix1[0].Count; j++)
                {
                    Console.Write($"|{matrix1[i][j]} + {matrix2[i][j]} = {matrix1[i][j] + matrix2[i][j]}|");
                }
                Console.WriteLine();
            }
        }
    }
    public void Subtract(List<List<int>> matrix1, List<List<int>> matrix2)
    {
        Console.WriteLine("\n");
        if (matrix1.Count != matrix2.Count || matrix1[0].Count != matrix2[0].Count)
        {
            Console.WriteLine("Matrices must have the same dimensions for substraction.");
        }
        else
        {
            for (int i = 0; i < matrix1.Count; i++)
            {
                for (int j = 0; j < matrix1[0].Count; j++)
                {
                    Console.Write($"|{matrix1[i][j]} - {matrix2[i][j]} = {matrix1[i][j] - matrix2[i][j]}|");
                }
                Console.WriteLine();
            }
        }
    }
    public void Divide(List<List<int>> matrix1, List<List<int>> matrix2)
    {
        Console.WriteLine("\n");
        if (matrix1.Count != matrix2.Count || matrix1[0].Count != matrix2[0].Count)
        {
            Console.WriteLine("Matrices must have the same dimensions for division.");
        }
        else
        {
            for (int i = 0; i < matrix1.Count; i++)
            {
                for (int j = 0; j < matrix1[0].Count; j++)
                {
                    if (matrix2[i][j] != 0) { Console.Write($"|{matrix1[i][j]} + {matrix2[i][j]} = {matrix1[i][j] + matrix2[i][j]}|"); }
                    else { Console.WriteLine("Cannot divide by zero\n"); }
                }
                Console.WriteLine();
            }
        }
    }
    public void Multiply(List<List<int>> matrix1, List<List<int>> matrix2)
    {
        Console.WriteLine("\n");
        if (matrix1.Count != matrix2.Count || matrix1[0].Count != matrix2[0].Count)
        {
            Console.WriteLine("Matrices must have the same dimensions for multiplication.");
        }
        else
        {
            for (int i = 0; i < matrix1.Count; i++)
            {
                for (int j = 0; j < matrix1[0].Count; j++)
                {
                    Console.Write($"|{matrix1[i][j]} * {matrix2[i][j]} = {matrix1[i][j] * matrix2[i][j]}|");
                }
                Console.WriteLine();
            }
        }
    }

    public void Add(List<List<List<int>>> tensor1, List<List<List<int>>> tensor2)
    {
        Console.WriteLine("\n");

        if (!AreTensorsCompatibleForAddition(tensor1, tensor2))
        {
            Console.WriteLine("Tensors must have the same dimensions for addition.");
        }
        else
        {
            for (int i = 0; i < tensor1.Count; i++)
            {
                Console.WriteLine($"Layer {i + 1}:");

                for (int j = 0; j < tensor1[i].Count; j++)
                {
                    for (int k = 0; k < tensor1[i][j].Count; k++)
                    {
                        Console.Write($"|{tensor1[i][j][k]} + {tensor2[i][j][k]} = {tensor1[i][j][k] + tensor2[i][j][k]}|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    public void Subtract(List<List<List<int>>> tensor1, List<List<List<int>>> tensor2)
    {
        Console.WriteLine("\n");

        if (!AreTensorsCompatibleForAddition(tensor1, tensor2))
        {
            Console.WriteLine("Tensors must have the same dimensions for addition.");
        }
        else
        {
            for (int i = 0; i < tensor1.Count; i++)
            {
                Console.WriteLine($"Layer {i + 1}:");

                for (int j = 0; j < tensor1[i].Count; j++)
                {
                    for (int k = 0; k < tensor1[i][j].Count; k++)
                    {
                        Console.Write($"|{tensor1[i][j][k]} - {tensor2[i][j][k]} = {tensor1[i][j][k] - tensor2[i][j][k]}|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    public void Divide(List<List<List<int>>> tensor1, List<List<List<int>>> tensor2)
    {
        Console.WriteLine("\n");

        if (!AreTensorsCompatibleForAddition(tensor1, tensor2))
        {
            Console.WriteLine("Tensors must have the same dimensions for addition.");
        }
        else
        {
            for (int i = 0; i < tensor1.Count; i++)
            {
                Console.WriteLine($"Layer {i + 1}:");

                for (int j = 0; j < tensor1[i].Count; j++)
                {
                    for (int k = 0; k < tensor1[i][j].Count; k++)
                    {
                        if (tensor1[i][j][k] != 0) { Console.Write($"|{tensor1[i][j][k]} + {tensor2[i][j][k]} = {tensor1[i][j][k] + tensor2[i][j][k]}|"); }
                        else { Console.WriteLine("Cannot divide by zero\n"); }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    public void Multiply(List<List<List<int>>> tensor1, List<List<List<int>>> tensor2)
    {
        Console.WriteLine("\n");

        if (!AreTensorsCompatibleForAddition(tensor1, tensor2))
        {
            Console.WriteLine("Tensors must have the same dimensions for addition.");
        }
        else
        {
            for (int i = 0; i < tensor1.Count; i++)
            {
                Console.WriteLine($"Layer {i + 1}:");

                for (int j = 0; j < tensor1[i].Count; j++)
                {
                    for (int k = 0; k < tensor1[i][j].Count; k++)
                    {
                        Console.Write($"|{tensor1[i][j][k]} * {tensor2[i][j][k]} = {tensor1[i][j][k] * tensor2[i][j][k]}|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    private bool AreTensorsCompatibleForAddition(List<List<List<int>>> tensor1, List<List<List<int>>> tensor2)
    {
        if (tensor1.Count != tensor2.Count)
        {
            return false;
        }

        for (int i = 0; i < tensor1.Count; i++)
        {
            if (tensor1[i].Count != tensor2[i].Count || tensor1[i][0].Count != tensor2[i][0].Count)
            {
                return false;
            }
        }

        return true;
    }
}

