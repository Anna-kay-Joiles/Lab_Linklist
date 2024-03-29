//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Lab_Linklist;
//[TestClass]

//namespace Lab_Linklist
//[TestClass]
//public class LinkedListTests
//{
//    [TestMethod]
//    public void Test_AddFirst()
//    {
//        // Arrange
//        LinkedList list = new LinkedList();
//        string expectedValue = "Joe Blow";

//        // Act
//        list.AddFirst(expectedValue);

//        // Assert
//        Assert.AreEqual(expectedValue, list.GetValue(0));
//    }

//    [TestMethod]
//    public void Test_AddLast()
//    {
//        // Arrange
//        LinkedList list = new LinkedList();
//        string expectedValue = "Joe Schmoe";

//        // Act
//        list.AddLast(expectedValue);

//        // Assert
//        Assert.AreEqual(expectedValue, list.GetValue(0));
//    }

//    [TestMethod]
//    public void Test_RemoveFirst()
//    {
//        // Arrange
//        LinkedList list = new LinkedList();
//        list.AddFirst("Joe Blow");

//        // Act
//        list.RemoveFirst();

//        // Assert
//        Assert.AreEqual(0, list.Count);
//    }

//    [TestMethod]
//    public void Test_RemoveLast()
//    {
//        // Arrange
//        LinkedList list = new LinkedList();
//        list.AddLast("Joe Blow");

//        // Act
//        list.RemoveLast();

//        // Assert
//        Assert.AreEqual(0, list.Count);
//    }

//    [TestMethod]
//    public void Test_GetValue()
//    {
//        // Arrange
//        LinkedList list = new LinkedList();
//        list.AddFirst("Joe Blow");
//        list.AddLast("Joe Schmoe");
//        list.AddLast("John Smith");
//        string expectedValue = "Joe Schmoe";

//        // Act
//        string retrievedValue = list.GetValue(1);

//        // Assert
//        Assert.AreEqual(expectedValue, retrievedValue);
//    }
//}