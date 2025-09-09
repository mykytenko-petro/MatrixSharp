using System.Reflection;

using MatrixSharp.Core;


class Tests
{
    public static void Main()
    {
        Matrix A = new(
            [
                [3, 1],
                [4, 6],
                [5, 7],
            ]
        );

        string? directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        if (directoryPath != null)
        {
            A.ToTxtFile(Path.Combine(directoryPath, "Array.txt"));
        }
    }
}