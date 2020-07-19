using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerPremitiveFixture
    {
        [TestMethod]
        public void Bool_values_are_similar_pass()
        {
            bool first = true, second = true;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Bool_values_are_similar_fail()
        {
            bool first = true, second = false;
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Int_values_are_similar_pass()
        {
            int first = 10, second = 10;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Int_values_are_similar_fail()
        {
            int first = 10, second = 1;
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_values_are_similar_pass()
        {
            string first = "pass", second = "pass";
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_values_are_similar_fail()
        {
            string first = "pass", second = "fail";
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

    }
}
