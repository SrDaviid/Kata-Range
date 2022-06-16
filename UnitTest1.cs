using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KataRangeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIntegerRangeContainsPart1()
        {
            try
            {
                int[] ArregloIntegerRange = new int[4] { 2, 3, 4, 5 };
                int[] ArregloEsperado = new int[3] { 2, 3, 4 };

                bool contains = ArregloIntegerRange.Intersect(ArregloEsperado).Any();
                Assert.Fail();
            }
            catch(Exception error) {

            }
        }

        [TestMethod]
        public void TestIntegerRangeContainsPart2()
        {
            int[] ArregloIntegerRange = new int[4] { 2, 3, 4, 5 };
            int[] ArregloNoEsperado = new int[4] { -1, 1, 6, 10};

            bool contains = ArregloIntegerRange.Intersect(ArregloNoEsperado).Any();
            Assert.IsFalse(contains);
            


        }

        [TestMethod]
        public void TestGetAllPoints()
        {
            try
            {
                int[] GetAllPoints = new int[4] { 2, 3, 4, 5 };
                Assert.Fail();
            }
            catch(Exception error)
            {

            }
        }


        [TestMethod]
        public void TestContainsRange()
        {
            try
            {
                int[] NoContainsPart1 = new int[2] { 7, 10 };
                int[] NoContainsPart2 = new int[2] { 3, 10 };
                int[] NoContainsPart3 = new int[2] { 2, 10 };
                Assert.Fail();
            }
            catch(Exception error)
            { }

        }
    }
}
