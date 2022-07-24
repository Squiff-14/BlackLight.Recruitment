using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackLight.Recruitment.UnitTests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void ReverseWordsInString()
        {
            string input = "In West Philadelphia born and raised on the playground is where I spent most of my days";
            string expected = "days my of most spent I where is playground the on raised and born Philadelphia West In";

            string result = Algorithms.ReverseWordsInString(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseWordsInStringWithoutUsingAnyLinqMethods()
        {
            string input = "In West Philadelphia born and raised on the playground is where I spent most of my days";
            string expected = "days my of most spent I where is playground the on raised and born Philadelphia West In";

            string result = Algorithms.ReverseWordsInStringWithoutUsingAnyLinqMethods(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortWithoutUsingBuiltInSortMethods()
        {
            int[] input = new[] { 5, 87, -23, 42, 99, 10543, 12934, 82, 45, 92, 42, 82 };
            int[] expected = new[] { -23, 5, 42, 42, 45, 82, 82, 87, 92, 99, 10543, 12934 };

            int[] result = Algorithms.SortWithoutUsingBuiltInSortMethods(input);

            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; ++i)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
