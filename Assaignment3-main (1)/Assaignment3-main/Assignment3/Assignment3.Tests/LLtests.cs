using Assignment3;

namespace LinkedListTests
{
    [TestFixture]
    public class Tests
    {
        public LinkedList TestList;
        [SetUp]
        public void Setup()
        {
            TestList = new LinkedList();
        }

        [TearDown]
        public void TearDown()
        {
            TestList.Clear();
        }

        [Test]
        public void IsEmpty_True_LinkedListIsEmpty()
        {
            Assert.IsTrue(TestList.IsEmpty());
        }

        [Test]
        public void IsEmpty_False_LinkedListIsNotEmpty()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            Assert.IsFalse(TestList.IsEmpty());
        }




        [Test]
        public void Add_GreaterThan0_NodeIsAdded()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            TestList.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 2);


            Assert.AreEqual("Ronald McDonald", TestList.GetValue(2).Name);
            Assert.AreEqual(4, TestList.Count());
        }

        [Test]
        public void Add_LessThanCount_ExceptionThrown()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => TestList.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), -2));
        }

        [Test]
        public void Add_GreaterThanCount_ExceptionThrown()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => TestList.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 10));
        }




        [Test]
        public void Replace_GreaterThan0_NodeisReplaced()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            TestList.Replace(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 1);

            Assert.AreEqual("Ronald McDonald", TestList.GetValue(1).Name);
        }

        [Test]
        public void Replace_LessThan0_ExceptionThrown()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => TestList.Replace(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), -2));
        }

        [Test]
        public void Replace_GreaterThanCount_ExceptionThrown()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => TestList.Replace(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 6));
        }




        [Test]
        public void RemoveFirst_OnlyOneNode_HeadNotEmpty_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            TestList.RemoveFirst();

            Assert.IsTrue(TestList.IsEmpty());
        }

        [Test]
        public void RemoveFirst_MoreThanOneNode_HeadNotEmpty_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));

            TestList.RemoveFirst();

            Assert.AreEqual("Joe Schmoe", TestList.GetValue(0).Name);
        }

        [Test]
        public void RemoveFirst_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() => TestList.RemoveFirst());
        }




        [Test]
        public void RemoveLast_OnlyOneNode_HeadNotEmpty_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            TestList.RemoveLast();

            Assert.IsTrue(TestList.IsEmpty());
        }

        [Test]
        public void RemoveLast_MoreThanOneNode_HeadNotEmpty_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.RemoveLast();

            Assert.IsTrue(TestList.Head.Next == null);
        }

        [Test]
        public void RemoveLast_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() => TestList.RemoveLast());
        }



        [Test]
        public void Remove_HeadNotEmpty_GreaterThan0_OnlyOneNode_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            TestList.Remove(0);

            Assert.IsTrue(TestList.IsEmpty());
        }

        [Test]
        public void Remove_HeadNotEmpty_LessThanCount_OnlyOneNode_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            Assert.Throws<IndexOutOfRangeException>(() => TestList.Remove(-1));
        }

        [Test]
        public void Remove_HeadNotEmpty_GreaterThanCount_OnlyOneNode_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            Assert.Throws<IndexOutOfRangeException>(() => TestList.Remove(5));
        }

        [Test]
        public void Remove_HeadNotEmpty_GreaterThan0_MoreThanOneNode_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            TestList.Remove(1);

            Assert.AreEqual("Colonel Sanders", TestList.GetValue(1).Name);
            Assert.AreEqual(2, TestList.Count());
        }

        [Test]
        public void Remove_HeadNotEmpty_LessThan0_MoreThanOneNode_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            TestList.Remove(2);

            Assert.Throws<IndexOutOfRangeException>(() => TestList.Remove(-1));
        }

        [Test]
        public void Remove_HeadNotEmpty_GreaterThanCount_MoreThanOneNode_NodeRemoved()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            TestList.Remove(2);

            Assert.Throws<IndexOutOfRangeException>(() => TestList.Remove(5));
        }

        [Test]
        public void Remove_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<IndexOutOfRangeException>(() => TestList.Remove(1));
        }





        [Test]
        public void GetValue_HeadIsNotEmpty_GreaterThan0_ValueReturned()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

            Assert.AreEqual("Joe Schmoe", TestList.GetValue(1).Name);
        }

        [Test]
        public void GetValue_HeadIsNotEmpty_LessThan0_ExceptionThrown()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

            Assert.Throws<IndexOutOfRangeException>(() => TestList.GetValue(-1));
        }

        [Test]
        public void GetValue_HeadIsNotEmpty_GreaterThanCount_ExceptionThrown()
        {
            TestList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            TestList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            TestList.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

            Assert.Throws<IndexOutOfRangeException>(() => TestList.GetValue(5));
        }

        [Test]
        public void GetValue_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<IndexOutOfRangeException>(() => TestList.GetValue(1));
        }

    }
}
