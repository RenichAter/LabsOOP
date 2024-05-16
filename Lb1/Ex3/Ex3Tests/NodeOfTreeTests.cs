using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Tests
{
    [TestClass()]
    public class NodeOfTreeTests
    {
        [TestMethod()]
        public void TreeTest()
        {
            NodeOfTree<double> first = new NodeOfTree<double>(1);
            NodeOfTree<double> sekonda = new NodeOfTree<double>(21);
            NodeOfTree<double> sekondb = new NodeOfTree<double>(22);
            NodeOfTree<double> thirtb = new NodeOfTree<double>(322);
            first.AddChild(sekonda);
            first.AddChild(sekondb);
            sekondb.AddChild(thirtb);
            var fromConsole = new System.IO.StringWriter();
            Console.SetOut(fromConsole);
            first.PrintValues();
            var result = fromConsole.ToString().Trim();
            Assert.AreEqual("1\r\n21\r\n22\r\n322", result);
        }
    }
}