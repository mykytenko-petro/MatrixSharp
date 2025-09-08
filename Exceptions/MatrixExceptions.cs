namespace MatrixSharp.Exceptions
{
    public class WrongMatrixShape : Exception
    {
        public WrongMatrixShape() : base("Empty matrices are not allowed") { }

        public WrongMatrixShape(double[][] body, int wrongRowIndex)
            : base(Report(body, wrongRowIndex))
        { }

        private static string Report(double[][] body, int wrongRowIndex)
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
                    report += " <--- unmatched number of columns";
                }

                report += "\n";
            }

            return report;
        }
    }

    public class UnmatchedMatrixShape : Exception
    {
        public UnmatchedMatrixShape()
            : base("Shape of matrices must be exactly the same")
        { }
    }
    
    public class WrongMultiplyingMatrixShape : Exception
    {
        public WrongMultiplyingMatrixShape()
            : base("The first matrix\'s columns must match the second matrix\'s rows for multiplication")
        { }
    }
}
