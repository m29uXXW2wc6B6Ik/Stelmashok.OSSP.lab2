/// <summary>
/// The UnitTestProject namespace.
/// </summary>
namespace UnitTestProject
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Stelmashok.OSSP.Lab2;

    /// <summary>
    /// Class UnitTest1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the Types. Get info about Types in package.
        /// </summary>
        [TestMethod]
        public void TestTypes()
        {
            var computerType = typeof(Computer);
            var types = computerType.Assembly.GetTypes();
            string typeInfo = Environment.NewLine;
            foreach (var type in types)
            {
                typeInfo += "*** " + type.Name + Environment.NewLine;
            }
            Assert.Fail(typeInfo);
        }

        /// <summary>
        /// Tests the collection. Get
        /// </summary>
        [TestMethod]
        public void TestCollection()
        {
            var aCollection = new List<object>();

            string aInfo = Environment.NewLine + "Abstract collection:" + Environment.NewLine;

            var iCollection = new List<object>();

            string iInfo = Environment.NewLine + "Interface collection:" + Environment.NewLine;

            var collection = new List<object> { new Phone(), new SmartPhone(), new Computer() };

            foreach (var item in collection)
            {
                var baseType = item.GetType().BaseType;
                if (baseType != null && baseType == typeof(APhone))
                {
                    aCollection.Add(item);
                    aInfo += item.GetType().Name + Environment.NewLine;
                }
                foreach (var value in item.GetType().GetInterfaces())
                {
                    if (value.Name == typeof(IInternet).Name)
                    {
                        iCollection.Add(item);
                        iInfo += item.GetType().Name + Environment.NewLine;
                        break;
                    }
                }
            }
            string allInfo = aInfo + iInfo;
            Assert.Fail(allInfo);
            //Assert.IsTrue(true,allInfo);
            //Assert.Inconclusive(allInfo);
        }

        /// <summary>
        /// Tests the attributes. Get Information from attributes.
        /// </summary>
        [TestMethod]
        public void TestAttributes()
        {
            string[] AttributeNames = new[] {"HomePhone", "Device", "Mobile"};
            string allInfo = Environment.NewLine;

            var types = typeof(Phone).Assembly.GetTypes();
            foreach (var type in types)
            {
                var secondNameAttribute =
                    (SecondNameAttribute) type.GetCustomAttribute(typeof (SecondNameAttribute));
                foreach (var attributeName in AttributeNames)
                {
                    if (secondNameAttribute != null && secondNameAttribute.Name == attributeName)
                    {
                        var obj = Activator.CreateInstance(type);
                        allInfo += "Type: " + obj.GetType().ToString() + Environment.NewLine
                            + "public properties:" + Environment.NewLine;
                        foreach (var propertie in obj.GetType().GetProperties())
                        {
                            allInfo += propertie.Name + Environment.NewLine;
                        }
                    }
                }
            }
            Assert.Fail(allInfo);
        }
    }
}
