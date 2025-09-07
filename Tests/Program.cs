// TODO: try to remake console app on unit test

using MatrixSharp.Core;

class Tests
{
    public static void Main()
    {
        Matrix A = new(
            [
                [1, 2],
                [4, 5],
                [7, 7]
            ]
        );

        Matrix B = new(
            [
                [1, 2],
                [4, 5],
                [7, 8]
            ]
        );

        Console.WriteLine(A - B);
    }
}