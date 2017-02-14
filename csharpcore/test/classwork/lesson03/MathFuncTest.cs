using csharpcore.main.classwork.lesson03;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcore.test.classwork.lesson03
{
    class MathFuncTest
    {
        [TestFixture]
        class MathFuncTests
        {

            [Test]
            public void MultiplyTest()
            {
                int a = 2;
                int b = 2;
                int expected = 4;
                Assert.AreEqual(expected, MathFunc.Multiply(a, b));
            }


            [Test]
            public void MultiplyTest2()
            {
                int a = 0;
                int b = 3;
                int expected = 1;
                Assert.AreNotEqual(expected, MathFunc.Multiply(a, b));
            }
            [Test]
            public void DivideTest()
            {
                int a1 = 3;
                int b1 = 2;
                double expected = 1.5d;
                Assert.AreEqual(expected, MathFunc.Divide(a1, b1));
            }

            [Test]
            public void MinusTest()
            {
                int a = 5;
                int b = 1;
                int expected = 4;
                Assert.AreEqual(expected, MathFunc.Minus(a, b));
            }

            [Test]
            public void AddTest()
            {
                int a = 1;
                int b = 2;
                int expected = 3;
                Assert.AreEqual(expected, MathFunc.Add(a, b));
            }


            [Test]
            public void DivideTest1()
            {
                //int a = 1;
                //int b = 2;
                //int expected = 0.5d;
                //Program mathFunc = new Program();
                Assert.AreEqual(4.4999d, MathFunc.Divide(9, 2), 0.001);
            }

            [Test]
            public void DivideTest2()
            {

                Assert.AreEqual(3, MathFunc.Divide(6, 2), 0);
            }

            [Test]
            public void PowTest()
            {

                Assert.AreEqual(81, Math.Pow(9, 2), 0);
            }

            [Test]
            public void MaxTest()
            {

                Assert.AreEqual(10, Math.Max(10, 5), 0);
            }

            [Test]
            public void MinTest()
            {

                Assert.AreEqual(5, Math.Min(10, 5), 0);
            }

            [Test]
            public void Multiply1Test()
            {

                Assert.AreEqual(0, MathFunc.Multiply(10, 0), 0);
            }

            [Test]
            public void SqrtTest()
            {

                Assert.AreEqual(5, Math.Sqrt(25), 0);
            }

            [Test]
            public void AbsTest()
            {

                Assert.AreEqual(1, Math.Abs(-1), 0);
            }

            [Test]
            public void AbsTest1()
            {

                Assert.AreEqual(0, Math.Abs(0), 0);
            }

            [Test]
            public void AbsTest2()
            {

                Assert.AreEqual(4, Math.Abs(4), 0);
            }

            [Test]
            public void AddTest1()
            {

                Assert.AreEqual(-5, MathFunc.Add(-4, -1), 0);
            }

            [Test]
            public void DivideTest3()
            {

                Assert.AreEqual(4, MathFunc.Divide(-4, -1), 0);
            }

            [Test]
            public void DivideTest4()
            {

                Assert.AreEqual(0, MathFunc.Divide(0, -1), 0);
            }

            [Test]
            public void DivideTest5()
            {

                Assert.AreEqual(0.333d, MathFunc.Divide(1, 3), 0.01);
            }

            [Test]
            public void CosTest()
            {

                Assert.AreNotEqual(0.000000d, Math.Cos(90.000000));
            }
        }
    }
}
