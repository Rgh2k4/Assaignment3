using Assignment3;

namespace LinkedListTests
{
    [TestFixture]
    public class Tests
    {
        SinglyLinkedList users = new SinglyLinkedList();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IsEmpty_True_LinkedListIsEmpty()
        {
            Assert.IsTrue(users.IsEmpty());
        }

        [Test]
        public void IsEmpty_False_LinkedListIsNotEmpty()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            Assert.IsFalse(users.IsEmpty());
        }




        [Test]
        public void Add_GreaterThan0_NodeIsAdded()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            users.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 2);


            Assert.AreEqual("Ronald McDonald", users.GetValue(2).Name);
            Assert.AreEqual(3, users.Count());
        }

        [Test]
        public void Add_LessThanCount_ExceptionThrown()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => users.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), -2));
        }

        [Test]
        public void Add_GreaterThanCount_ExceptionThrown()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => users.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 10));
        }




        [Test]
        public void Replace_GreaterThan0_NodeisReplaced()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            users.Replace(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 1);

            Assert.AreEqual("Ronald McDonald", users.GetValue(1).Name);
        }

        [Test]
        public void Replace_LessThan0_ExceptionThrown()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => users.Replace(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), -2));
        }

        [Test]
        public void Replace_GreaterThanCount_ExceptionThrown()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));


            Assert.Throws<IndexOutOfRangeException>(() => users.Replace(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"), 6));
        }




        [Test]
        public void RemoveFirst_OnlyOneNode_HeadNotEmpty_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            users.RemoveFirst();

            Assert.IsTrue(users.IsEmpty());
        }

        [Test]
        public void RemoveFirst_MoreThanOneNode_HeadNotEmpty_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));

            users.RemoveFirst();

            Assert.AreEqual("Joe Schmoe", users.GetValue(1).Name);
        }

        [Test]
        public void RemoveFirst_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() => users.RemoveFirst());
        }




        [Test]
        public void RemoveLast_OnlyOneNode_HeadNotEmpty_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            users.RemoveLast();

            Assert.IsTrue(users.IsEmpty());
        }

        [Test]
        public void RemoveLast_MoreThanOneNode_HeadNotEmpty_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.RemoveLast();

            Assert.IsTrue(users.Head.Next.Next == null);
        }

        [Test]
        public void RemoveLast_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<InvalidOperationException>(() => users.RemoveLast());
        }



        [Test]
        public void Remove_HeadNotEmpty_GreaterThan0_OnlyOneNode_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            users.Remove(1);

            Assert.IsTrue(users.IsEmpty());
        }

        [Test]
        public void Remove_HeadNotEmpty_LessThanCount_OnlyOneNode_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            Assert.Throws<IndexOutOfRangeException>(() => users.Remove(-1));
        }

        [Test]
        public void Remove_HeadNotEmpty_GreaterThanCount_OnlyOneNode_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));

            Assert.Throws<IndexOutOfRangeException>(() => users.Remove(5));
        }

        [Test]
        public void Remove_HeadNotEmpty_GreaterThan0_MoreThanOneNode_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.Remove(2);

            Assert.AreEqual("Colonel Sanders", users.GetValue(2).Name);
            Assert.AreEqual(3, users.Count());
        }

        [Test]
        public void Remove_HeadNotEmpty_LessThan0_MoreThanOneNode_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.Remove(2);

            Assert.Throws<IndexOutOfRangeException>(() => users.Remove(-1));
        }

        [Test]
        public void Remove_HeadNotEmpty_GreaterThanCount_MoreThanOneNode_NodeRemoved()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.Remove(2);

            Assert.Throws<IndexOutOfRangeException>(() => users.Remove(5));
        }

        [Test]
        public void Remove_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<IndexOutOfRangeException>(() => users.Remove(1));
        }





        [Test]
        public void GetValue_HeadIsNotEmpty_GreaterThan0_ValueReturned()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

            Assert.AreEqual("Joe Schmoe", users.GetValue(2).Name);
        }

        [Test]
        public void GetValue_HeadIsNotEmpty_LessThan0_ExceptionThrown()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(-1));
        }

        [Test]
        public void GetValue_HeadIsNotEmpty_GreaterThanCount_ExceptionThrown()
        {
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(5));
        }

        [Test]
        public void GetValue_HeadIsEmpty_ExceptionThrown()
        {
            Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(1));
        }

    }
}
