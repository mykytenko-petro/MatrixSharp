using System.Reflection;

using MatrixSharp.Core;

class Tests
{
    public static void Main()
    {
        // Створюємо матрицю
        Matrix A = new(
        [
            [3, 1],
            [4, 6],
            [5, 7]
        ]);

        // Визначаємо шлях для збереження файлу
        string? directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        if (directoryPath != null)
        {
            string filePath = Path.Combine(directoryPath, "Array.txt");
            A.ToTxtFile(filePath);
        }

        // Тестування додавання
        Matrix B = new(
        [
            [1, 2],
            [3, 4],
            [5, 6]
        ]);

        try
        {
            Matrix C = A + B; 
            Console.WriteLine("A + B:");
            Console.WriteLine(C);
        }
        catch (Exception e)
        {
            Console.WriteLine("Addition failed: " + e.Message);
        }

        // Тестування множення
        Matrix D = new(
        [
            [1, 2, 3],
            [4, 5, 6]
        ]);

        try
        {
            Matrix E = A * D; 
            Console.WriteLine("A * D:");
            Console.WriteLine(E);
        }
        catch (Exception e)
        {
            Console.WriteLine("Multiplication failed: " + e.Message);
        }
    }
}
