using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace Nunit_Assignment
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _listManager;
        private List<int> _list;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _list = new List<int>();
        }

        [Test]
        public void AddElement_WhenCalled_AddsElementToList()
        {
            _listManager.AddElement(_list, 5);
            Assert.Contains(5, _list);
        }

        [Test]
        public void RemoveElement_WhenElementExists_RemovesElement()
        {
            _list.Add(10);
            bool result = _listManager.RemoveElement(_list, 10);

            Assert.IsTrue(result);
            Assert.IsFalse(_list.Contains(10));
        }

        [Test]
        public void RemoveElement_WhenElementDoesNotExist_ReturnsFalse()
        {
            bool result = _listManager.RemoveElement(_list, 15);

            Assert.IsFalse(result);
        }

        [Test]
        public void GetSize_WhenCalled_ReturnsCorrectSize()
        {
            _listManager.AddElement(_list, 1);
            _listManager.AddElement(_list, 2);

            int size = _listManager.GetSize(_list);
            Assert.AreEqual(2, size);
        }

        [Test]
        public void Methods_WhenListIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _listManager.AddElement(null, 5));
            Assert.Throws<ArgumentNullException>(() => _listManager.RemoveElement(null, 5));
            Assert.Throws<ArgumentNullException>(() => _listManager.GetSize(null));
        }
    }
}
