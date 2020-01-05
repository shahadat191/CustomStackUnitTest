using NUnit.Framework;
using MyStack;
using System.Collections.Generic;
using System;

namespace stackTestN
{
    public class Tests
    {
        MyStack<int> stack;
        [SetUp]
        public void Setup()
        {
           stack = new MyStack<int>();
        }

        [Test]
        public void VerifyIsEmptyTrue()
        {
            var result = stack.IsEmpty();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void VerifyIsEmptyWithSize()
        {
            stack.Push(10);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(false, stack.IsEmpty());
                Assert.AreEqual(1, stack.Count);
            });
        }

        [Test]
        public void VerifyPushForMultipleObject()
        {
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(3, stack.Count);
        }

        [Test]
        public void VerifyPopAndSize()
        {
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            Assert.AreEqual(2, stack.Count);
        }
        [Test]
        public void VerifyIsEmptyFalseWithSize()
        {
            stack.Push(10);
            stack.Pop();
            Assert.Multiple(() =>
            {
                Assert.IsTrue(stack.IsEmpty());
                Assert.AreEqual(0, stack.Count);
            });
        }

        [Test]
        public void VerifyEquality()
        {
            stack.Push(10);
            int top = stack.Pop();

            Assert.IsTrue(10 == top);
        }

        [Test]
        public void VerifyMultipleItemsEquality()
        {

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(30, stack.Pop());
                Assert.AreEqual(20, stack.Pop());
                Assert.AreEqual(10, stack.Pop());
            });
        }

        [Test]
        public void CheckForUnderflow()
        {
            Assert.That(stack.Pop(), Throws.InvalidOperationException);
           
        }



    }
}