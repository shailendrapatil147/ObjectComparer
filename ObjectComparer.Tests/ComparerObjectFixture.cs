using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Contracts.Contracts.Classes;
using System.Collections.Generic;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerObjectFixture
    {
        [TestMethod]
        public void Object_are_similar_pass()
        {
            Student stundent1 = new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Student stundent2 = new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Assert.IsTrue(Comparer.AreSimilar(stundent1, stundent2));
        }

        [TestMethod]
        public void Object_are_similar_fail()
        {
            Student stundent1 = new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Student stundent2 = new Student() { Id = 1, Name = "second", Marks = new int[] { 80, 75, 80 } };
            Assert.IsFalse(Comparer.AreSimilar(stundent1, stundent2));
        }

        [TestMethod]
        public void Object_valued_are_similar_fail()
        {
            Student stundent1 = new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } };
            Student stundent2 = new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 80 } };
            Assert.IsFalse(Comparer.AreSimilar(stundent1, stundent2));
        }


        [TestMethod]
        public void Object_list_are_similar_pass()
        {
            List<Student> students1 = new List<Student>(){ new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } },
                new Student() { Id = 2, Name = "second", Marks = new int[] { 80, 85, 60 } }};

            List<Student> students2 = new List<Student>(){ new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } },
                new Student() { Id = 2, Name = "second", Marks = new int[] { 80, 85, 60 } }};

            Assert.IsTrue(Comparer.AreSimilar(students1, students2));
        }


        [TestMethod]
        public void Object_list_are_similar_fail()
        {
            List<Student> students1 = new List<Student>(){ new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } },
                new Student() { Id = 2, Name = "second", Marks = new int[] { 80, 85 } }};

            List<Student> students2 = new List<Student>(){ new Student() { Id = 1, Name = "first", Marks = new int[] { 80, 75, 70 } },
                new Student() { Id = 2, Name = "second", Marks = new int[] { 80, 85, 60 } }};

            Assert.IsFalse(Comparer.AreSimilar(students1, students2));
        }
    }
}
