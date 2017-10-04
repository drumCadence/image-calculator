using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.Collections.Generic;

namespace ImageCalculator.Tests
{
    [TestClass]
    public class ImageTests
    {
        //
        // TODO: ADD MORE UNIT TESTS, MANY MORE!
        //
        [TestMethod]
        public void Create_6x12_Matrix()
        {
            // Setup
            var expectedRows = 6;
            var expectedCols = 12;
            var M = Matrix<double>.Build;

            // Execute
            var m = M.Random(6, 12);

            // Expectations
            Assert.IsNotNull(M);
            Assert.AreEqual(expectedRows, m.RowCount);
            Assert.AreEqual(expectedCols, m.ColumnCount);
        }

        [TestMethod]
        public void Create_6x12_Tuple_Matrix()
        {
            // Setup
            //var expectedRows = 6;
            //var expectedCols = 12;
            var M = Matrix<double>.Build;
            Tuple<int, int, double>[] x = { Tuple.Create(0, 5, 10.0), Tuple.Create(0, 6, 10.0), Tuple.Create(1, 5, 10.0) };


            // Execute
            M.DenseOfIndexed(6, 12, x);
           

            // Expectations
            Assert.IsNotNull(M);
           // Assert.AreEqual(expectedRows, m.RowCount);
            //Assert.AreEqual(expectedCols, m.ColumnCount);
        }
    }
}
