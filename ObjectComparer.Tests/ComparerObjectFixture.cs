using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Contracts.Contracts.Classes;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerObjectFixture
    {
        [TestMethod]
        public void Object_are_similar_pass()
        {
            Stundent stundent1 = new Stundent() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Stundent stundent2 = new Stundent() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Assert.IsTrue(Comparer.AreSimilar(stundent1, stundent2));
        }

        [TestMethod]
        public void Object_are_similar_fail()
        {
            Stundent stundent1 = new Stundent() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Stundent stundent2 = new Stundent() { Id = 1, Name = "second", Marks = new int[] { 80, 75, 80 } };
            Assert.IsFalse(Comparer.AreSimilar(stundent1, stundent2));
        }

        [TestMethod]
        public void Object_valued_are_similar_fail()
        {
            Stundent stundent1 = new Stundent() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Stundent stundent2 = new Stundent() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 80 } };
            Assert.IsFalse(Comparer.AreSimilar(stundent1, stundent2));
        }
    }
}
