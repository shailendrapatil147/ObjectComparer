using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerCollectionFixture
    {
        [TestMethod]
        public void Integer_list_values_are_similar_pass()
        {
            int[] first = new int[] { 10, 20, 30 };
            int[] second = new int[] { 10, 20, 30 };
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Integer_list_values_are_similar_fail()
        {
            int[] first = new int[] { 10, 20, 30 };
            int[] second = new int[] { 10, 20, 40 };
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_list_values_are_similar_pass()
        {
            string[] first = new string[] { "one", "two", "three" };
            string[] second = new string[] { "one", "two", "three" };
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_list_values_are_similar_fail()
        {
            string[] first = new string[] { "one", "two", "three" };
            string[] second = new string[] { "one", "two", "four" };
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }
    }
}
