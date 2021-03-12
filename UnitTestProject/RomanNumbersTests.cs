using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskDataWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks.Tests
{
    [TestClass()]
    public class RomanNumbersTests
    {
        [TestMethod()]
        public void ToIntTest()
        {
            var data = new Dictionary<string, int> {
                { "MMIX", 2009 },
                {"XX",20 },
                {"XXCI", 101},
                { "MCMLXXXVI",1986},
                { "MCMXCV",1995},
                { "CDLXXXV",485} };

            foreach (var item in data)
            {
                var number = TestTaskDataWorks.RomanNumbers.ToInt(item.Key);
                Assert.AreEqual(item.Value, number);
            }
        }

        [TestMethod()]
        public void ParenthesesTest()
        {
            var data = new Dictionary<string, bool> {
                { "(()())",true},
                { "()()()(()())",true},
                { "()()((()())())",true},
                { "(()()",false},
                { "())(())",false} };
            foreach (var item in data)
            {
                var isRight = TestTaskDataWorks.ParenthesesChecker.Check(item.Key);
                Assert.AreEqual(item.Value, isRight);
            }
        }

        [TestMethod()]
        public void DoubleLinkedListTest()
        {
            var list = new TestTaskDataWorks.DoubleLinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddLast(6);
            list.AddLast(7);
            var current = list.First;
            for (int i = 4; i < 8; i++)
            {
                Assert.AreEqual(i, current.Value);
                current = current.Next;
            }
        }
    }
}