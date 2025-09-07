using MatrixSharp.Exceptions;


namespace MatrixSharp.Core
{
    public class Matrix
    {
        public double[][] Body { get; private set; }

        public double Row { get; private set; }
        public double Column { get; private set; }

        public Matrix(double[][] body)
        {
            this.Body = body;

            for (int i = 0; i < this.Body.Length; i++)
            {
                this.Row += 1;

                if (i != 0 && this.Body[i].Length != this.Column)
                {
                    throw new WrongMatrixShape(body, i);
                }

                this.Column = 0;
                for (int j = 0; j < this.Body[i].Length; j++)
                {
                    this.Column += 1;
                }
            }
        }

        public static Matrix operator +(Matrix A, Matrix B) {
            double[][] body = [];

            if (A.Row != B.Row || A.Column != B.Column)
            {
                throw new UnmachedMatrixShape();
            }

            for (int i = 0; i < A.Row; i++)
            {
                double[] row = [];

                for (int j = 0; j < A.Column; j++)
                {
                    double sum = A.Body[i][j] + B.Body[i][j];

                    row = row.Append(sum).ToArray();
                }

                body = body.Append(row).ToArray();
            }

            return new Matrix(body);
        }

        public static Matrix operator -(Matrix A, Matrix B) {
            double[][] body = [];

            if (A.Row != B.Row || A.Column != B.Column)
            {
                throw new UnmachedMatrixShape();
            }

            for (int i = 0; i < A.Row; i++)
            {
                double[] row = [];

                for (int j = 0; j < A.Column; j++)
                {
                    double dif = A.Body[i][j] - B.Body[i][j];

                    row = row.Append(dif).ToArray();
                }

                body = body.Append(row).ToArray();
            }

            return new Matrix(body);
        }

        public override string ToString()
        {
            string report = "";

            for (int i = 0; i < this.Body.Length; i++)
            {
                report += '|';

                for (int j = 0; j < this.Body[i].Length; j++)
                {
                    report += " " + this.Body[i][j];
                }

                report += " |\n";
            }

            return report;
        }
    }
}
