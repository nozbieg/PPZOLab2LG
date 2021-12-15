using MatrixChecker;
using Xunit;

namespace MatrixCheckerTest
{
    public class MatrixCheckerTests
    {
        [Fact]
        public void MatrixProcessor_ComputeDeterminant3x3Test()
        {
            //Arange
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 0;
            matrix[1, 0] = -4;
            matrix[1, 1] = 1;
            matrix[1, 2] = 0;
            matrix[2, 0] = -1;
            matrix[2, 1] = 8;
            matrix[2, 2] = 0;

            int[,] matrix2 = new int[3, 3];
            matrix2[0, 0] = 2;
            matrix2[0, 1] = 4;
            matrix2[0, 2] = 5;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 51;
            matrix2[1, 2] = 6;
            matrix2[2, 0] = 8;
            matrix2[2, 1] = 9;
            matrix2[2, 2] = 23;
            var matrixPrecessor = new MatrixProcessor();
            //Act
            var determinant = matrixPrecessor.ComputeDeterminant(matrix, 3);
            var determinant2 = matrixPrecessor.ComputeDeterminant(matrix2, 3);

            //Assert
            Assert.Equal(0, determinant);
            Assert.Equal(60, determinant2);
        }

        [Fact]
        public void MatrixProcessor_ComputeDeterminant4x4Test()
        {
            //Arange
            int[,] matrix = new int[4, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[0, 3] = 3;
            matrix[1, 0] = -4;
            matrix[1, 1] = 1;
            matrix[1, 2] = 0;
            matrix[1, 3] = 0;
            matrix[2, 0] = -1;
            matrix[2, 1] = 0;
            matrix[2, 2] = 0;
            matrix[2, 3] = 0;
            matrix[3, 0] = -1;
            matrix[3, 1] = 0;
            matrix[3, 2] = 0;
            matrix[3, 3] = 0;

            int[,] matrix2 = new int[4, 4];
            matrix2[0, 0] = 15;
            matrix2[0, 1] = 22;
            matrix2[0, 2] = 33;
            matrix2[0, 3] = 34;
            matrix2[1, 0] = -45;
            matrix2[1, 1] = 16;
            matrix2[1, 2] = 55;
            matrix2[1, 3] = 0;
            matrix2[2, 0] = 23;
            matrix2[2, 1] = 67;
            matrix2[2, 2] = 20;
            matrix2[2, 3] = 540;
            matrix2[3, 0] = 531;
            matrix2[3, 1] = 10;
            matrix2[3, 2] = 0;
            matrix2[3, 3] = 0;


            var matrixPrecessor = new MatrixProcessor();
            //Act
            var determinant = matrixPrecessor.ComputeDeterminant(matrix, 4);
            var determinant2 = matrixPrecessor.ComputeDeterminant(matrix2, 4);


            //Assert
            Assert.Equal(0, determinant);
            Assert.Equal(-123067024, determinant2);
        }
    }
}