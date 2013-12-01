namespace Tester
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Problems;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class Tests
    {
        #region Fields & Constants

        // Some random strings for testing.
        private static readonly string Hello = "Hello";
        private static readonly string My = "my";
        private static readonly string Name = "name";
        private static readonly string Is = "is";
        private static readonly string Jduv = "jduv";

        // A list of doubles for testing.
        private static readonly double[] TestDoubles = { 1.0, -2.4, 3.154, -8.54, 100.3 };

        // A list of points for testing.
        public static readonly IList<Point> TestPoints = new List<Point>() { 
            Point.CreateRandomPositivePoint(), 
            Point.CreateRandomPositivePoint(),
            Point.CreateRandomPositivePoint(),
            Point.CreateRandomPositivePoint(),
            Point.CreateRandomPositivePoint()
        };

        #endregion

        #region Problem 1

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsDivisibleBy_NegativeA()
        {
            var target = new Problem1();
            target.IsDivisibleBy(-1, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsDivisibleBy_NegativeB()
        {
            var target = new Problem1();
            target.IsDivisibleBy(1, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsDivisibleBy_ZeroAsDenominator()
        {
            var target = new Problem1();
            target.IsDivisibleBy(1, 0);
        }

        [TestMethod]
        public void IsDivisibleBy_NumbersTest()
        {
            var target = new Problem1();
            Assert.IsTrue(target.IsDivisibleBy(6, 2));
            Assert.IsTrue(target.IsDivisibleBy(100, 5));
            Assert.IsTrue(target.IsDivisibleBy(999, 3));
            Assert.IsTrue(target.IsDivisibleBy(19371, 1));
            Assert.IsTrue(target.IsDivisibleBy(7, 1));
            Assert.IsTrue(target.IsDivisibleBy(0, 15));

            Assert.IsFalse(target.IsDivisibleBy(7, 9));
            Assert.IsFalse(target.IsDivisibleBy(1, 9));
            Assert.IsFalse(target.IsDivisibleBy(10, 100));
        }

        [TestMethod]
        public void Sum_PassValidNumber()
        {
            var target = new Problem1();
            Assert.AreEqual(15, target.Sum(5));
            Assert.AreEqual(1, target.Sum(1));

            // now for some fancy randomized testing.
            var random = new Random();

            // test three different random numbers between 1 and 10000.
            var x = random.Next(1, 10000);
            Assert.AreEqual((x * (x - 1)) / 2, target.Sum(x));
            x = random.Next(1, 10000);
            Assert.AreEqual((x * (x - 1)) / 2, target.Sum(x));
            x = random.Next(1, 10000);
            Assert.AreEqual((x * (x - 1)) / 2, target.Sum(x));
        }

        [TestMethod]
        public void Sum_PassZero()
        {
            var target = new Problem1();
            Assert.AreEqual(0, target.Sum(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sum_PassNegativeNumber()
        {
            var target = new Problem1();
            target.Sum(-3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindrome_NullArgument()
        {
            var target = new Problem1();
            target.IsPalindrome(null);
        }

        [TestMethod]
        public void IsPalindrome_NotAPalindrome()
        {
            var target = new Problem1();
            Assert.IsFalse(target.IsPalindrome("hello world"));
        }

        [TestMethod]
        public void IsPalindrome_EmptyStringIsAPalindrome()
        {
            var target = new Problem1();
            Assert.IsTrue(target.IsPalindrome(string.Empty));
        }

        [TestMethod]
        public void IsPalindrome_Palindromes()
        {
            var target = new Problem1();
            Assert.IsTrue(target.IsPalindrome("A man a plan a canal Panama"));
            Assert.IsTrue(target.IsPalindrome("Z"));
            Assert.IsTrue(target.IsPalindrome("A Toyotas a Toyota"));
            Assert.IsTrue(target.IsPalindrome("Go hang a salami Im a lasagna hog"));
            Assert.IsTrue(target.IsPalindrome("zzzxxyyayyxxzzz"));
        }

        #endregion

        #region Stacks & Queues

        [TestMethod]
        public void Stack_Strings()
        {
            var stack = new MyStack<string>();
            stack.Push(Hello);
            stack.Push(My);
            stack.Push(Name);
            stack.Push(Is);
            stack.Push(Jduv);

            Assert.AreEqual(5, stack.Count);

            // Every time we test Pop, we're removing an element from the stack.
            Assert.AreEqual(Jduv, stack.Pop());
            Assert.AreEqual(Is, stack.Pop());
            Assert.AreEqual(Name, stack.Pop());
            Assert.AreEqual(My, stack.Pop());
            Assert.AreEqual(Hello, stack.Pop());

            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Stack_Doubles()
        {
            var stack = new MyStack<double>();
            stack.Push(TestDoubles[0]);
            stack.Push(TestDoubles[1]);
            stack.Push(TestDoubles[2]);
            stack.Push(TestDoubles[3]);
            stack.Push(TestDoubles[4]);

            Assert.AreEqual(5, stack.Count);

            // Every time we test Pop, we're removing an element from the stack.
            Assert.AreEqual(TestDoubles[4], stack.Pop());
            Assert.AreEqual(TestDoubles[3], stack.Pop());
            Assert.AreEqual(TestDoubles[2], stack.Pop());
            Assert.AreEqual(TestDoubles[1], stack.Pop());
            Assert.AreEqual(TestDoubles[0], stack.Pop());

            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Stack_Points()
        {
            var stack = new MyStack<Point>();
            stack.Push(TestPoints[0]);
            stack.Push(TestPoints[1]);
            stack.Push(TestPoints[2]);
            stack.Push(TestPoints[3]);
            stack.Push(TestPoints[4]);

            Assert.AreEqual(5, stack.Count);

            // Every time we test Pop, we're removing an element from the stack.
            Assert.IsTrue(TestPoints[4].Equals(stack.Pop()));
            Assert.IsTrue(TestPoints[2].Equals(stack.Pop()));
            Assert.IsTrue(TestPoints[3].Equals(stack.Pop()));
            Assert.IsTrue(TestPoints[1].Equals(stack.Pop()));
            Assert.IsTrue(TestPoints[0].Equals(stack.Pop()));

            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Queue_Strings()
        {
            var queue = new MyQueue<string>();
            queue.Enqueue(Hello);
            queue.Enqueue(My);
            queue.Enqueue(Name);
            queue.Enqueue(Is);
            queue.Enqueue(Jduv);

            Assert.AreEqual(5, queue.Count);

            // Every time we test Pop, we're removing an element from the stack.
            Assert.AreEqual(Hello, queue.Dequeue());
            Assert.AreEqual(My, queue.Dequeue());
            Assert.AreEqual(Name, queue.Dequeue());
            Assert.AreEqual(Is, queue.Dequeue());
            Assert.AreEqual(Jduv, queue.Dequeue());

            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void Queue_Doubles()
        {
            var queue = new MyQueue<double>();
            queue.Enqueue(TestDoubles[0]);
            queue.Enqueue(TestDoubles[1]);
            queue.Enqueue(TestDoubles[2]);
            queue.Enqueue(TestDoubles[3]);
            queue.Enqueue(TestDoubles[4]);

            Assert.AreEqual(5, queue.Count);

            // Every time we test Pop, we're removing an element from the stack.
            Assert.AreEqual(TestDoubles[0], queue.Dequeue());
            Assert.AreEqual(TestDoubles[1], queue.Dequeue());
            Assert.AreEqual(TestDoubles[2], queue.Dequeue());
            Assert.AreEqual(TestDoubles[3], queue.Dequeue());
            Assert.AreEqual(TestDoubles[4], queue.Dequeue());

            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void Queue_Points()
        {
            var queue = new MyQueue<Point>();
            queue.Enqueue(TestPoints[0]);
            queue.Enqueue(TestPoints[1]);
            queue.Enqueue(TestPoints[2]);
            queue.Enqueue(TestPoints[3]);
            queue.Enqueue(TestPoints[4]);

            Assert.AreEqual(5, queue.Count);

            // Every time we test Pop, we're removing an element from the stack.
            Assert.IsTrue(TestPoints[0].Equals(queue.Dequeue()));
            Assert.IsTrue(TestPoints[1].Equals(queue.Dequeue()));
            Assert.IsTrue(TestPoints[2].Equals(queue.Dequeue()));
            Assert.IsTrue(TestPoints[3].Equals(queue.Dequeue()));
            Assert.IsTrue(TestPoints[4].Equals(queue.Dequeue()));

            Assert.AreEqual(0, queue.Count);
        }

        #endregion
    }
}
