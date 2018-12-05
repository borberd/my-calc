using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calc
{
    class MyMathTest
    {
        [TestFixture]

        class Test_Add
        {
            [TestCase]
            public void TestAddPositives()

            {
                MyMath math = new MyMath();
                Assert.AreEqual(30, math.Add(10 , 20));
            }
            [TestCase]
            public void TestAddNegative()

            {
                MyMath math = new MyMath();
                Assert.Greater(55, math.Add(10, 20));
            }
            [TestCase]
            public void TestAddCore()
            {
                MyMath math = new MyMath();
                Assert.Greater(math.Add(30, 10), 30);


            }


        }
    }
}
