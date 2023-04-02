using GraphsApp.Services.Validators;

namespace GraphsApp.Services.Managers
{
    /// <summary>
    /// Класс поддержки матриц с методами взаимодействия с ними.
    /// </summary>
    public static class MatrixManager
    {
        /// <summary>
        /// Возводит матрицу в степень.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="degree">Степень.</param>
        /// <returns>Матрица, возведённая в степень.</returns>
        public static int[,] Pow(int[,] matrix, int degree)
        {
            ValueValidator.AssertIsNotNull(matrix, nameof(matrix));
            ValueValidator.AssertMatrixOnLengthsAreEqual(matrix, nameof(matrix));
            int length = matrix.GetLength(0);
            int[,] result = matrix;
            for(int d = 1; d < degree; ++d)
            {
                int[,] temp = new int [length, length];
                for (int y = 0; y < length; ++y)
                {
                    for (int x = 0; x < length; ++x)
                    {
                        for(int n = 0; n < length; ++n)
                        {
                            temp[y, x] += result[y, n] * matrix[n, x];
                        }
                    }
                }
                result = temp;
            }
            return result;
        }
    }
}