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

        Matrix B = new(
            [
                [3, 4],
                [2, 5],
            ]
        );

        Console.WriteLine(A);

        Console.WriteLine(B);

        Console.WriteLine(A * B);
    }
}