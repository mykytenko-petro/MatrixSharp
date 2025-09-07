namespace MatrixSharp.Exceptions
{
    public class WrongMatrixShape(double[][] body, double wrongRowIndex) : Exception(Report(body, wrongRowIndex))
    {
        private static string Report(double[][] body, double wrongRowIndex)
        {
            string report = "\n";

            for (int i = 0; i < body.Length; i++)
            {
                report += '|';

                for (int j = 0; j < body[i].Length; j++)
                {
                    report += " " + body[i][j];
                }

                report += " |";

                if (i == wrongRowIndex)
                {
                    report += " <--- unmaching quantity of columns";
                }

                report += "\n";
            }

            return report;
        }
    }

    public class UnmachedMatrixShape() : Exception("shape of matrixes must be exact same") {}
}