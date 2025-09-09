using MatrixSharp.Exceptions;


namespace MatrixSharp.Core
{
    public class Matrix
    {
        public double[][] Body { get; private set; }

        public int Row { get; private set; }
        public int Column { get; private set; }

        public Matrix(double[][] body)
        {
            if (body == null || body.Length == 0)
                throw new WrongMatrixShape();

            Row = body.Length;
            Column = body[0].Length;

            for (int i = 0; i < Row; i++)
            {
                if (body[i].Length != Column)
                    throw new WrongMatrixShape(body, i);
            }

            Body = body;
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.Row != B.Row || A.Column != B.Column)
            {
                throw new UnmatchedMatrixShape();
            }

            double[][] body = [];

            for (int i = 0; i < A.Row; i++)
            {
                double[] row = [];
                for (int j = 0; j < A.Column; j++)
                    row = row.Append(A.Body[i][j] + B.Body[i][j]).ToArray();

                body = body.Append(row).ToArray();
            }

            return new Matrix(body);
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            if (A.Row != B.Row || A.Column != B.Column)
            {
                throw new UnmatchedMatrixShape();
            }

            double[][] body = [];

            for (int i = 0; i < A.Row; i++)
            {
                double[] row = [];
                for (int j = 0; j < A.Column; j++)
                    row = row.Append(A.Body[i][j] - B.Body[i][j]).ToArray();

                body = body.Append(row).ToArray();
            }

            return new Matrix(body);
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            double[][] body = [];

            if (A.Column != B.Row)
            {
                throw new WrongMultiplyingMatrixShape();
            }

            for (int i = 0; i < A.Row; i++)
            {
                double[] row = [];
                for (int j = 0; j < B.Column; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < A.Column; k++)
                    {
                        sum += A.Body[i][k] * B.Body[k][j];
                    }
                    row = row.Append(sum).ToArray();
                }
                body = body.Append(row).ToArray();
            }

            return new Matrix(body);
        }

        public override string ToString()
        {
            string report = "";
            for (int i = 0; i < Body.Length; i++)
            {
                report += "|";
                for (int j = 0; j < Body[i].Length; j++)
                    report += " " + Body[i][j];
                report += " |\n";
            }
            return report;
        }

        public void ToTxtFile(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, ToString());

                Console.WriteLine("file saved on this path: " + filePath);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
