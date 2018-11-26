using NUnit.Framework;
using System.Collections.Generic;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        private static int FirstSequance(int second, int first) 
        =>  second + first;

        private static int SecondSequance(int second, int first)
        => 6 * second - 8 * first;

        private static double ThirdSequance(double second, double first)
        => second +  first / second;  

        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            var list = new List<int>();

            foreach (var item in Generator<int>.Generate(1, 1, 10, FirstSequance))
            {
                list.Add(item);
            }

            CollectionAssert.AreEqual(expected, list);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            var list = new List<int>();

            foreach (var item in Generator<int>.Generate(1, 2, 10, SecondSequance))
            {
                list.Add(item);
            }

            CollectionAssert.AreEqual(expected, list);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            var list = new List<double>();

            foreach (var item in Generator<double>.Generate(1, 2, 10, ThirdSequance))
            {
                list.Add(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], list[i], 0.000001);
            }
        }
    }
}
