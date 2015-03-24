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
            string answer = "APhoneIInternetComputerPhoneProgramSecondNameAttributeSmartPhone";
            var computerType = typeof(Computer);
            var types = computerType.Assembly.GetTypes();
            string typeInfo = string.Empty;
            foreach (var type in types)
            {
                typeInfo += type.Name;
            }
            Assert.AreEqual(answer,typeInfo);
        }

        /// <summary>
        /// Tests the collection. Get
        /// </summary>
        [TestMethod]
        public void TestCollection()
        {
            string answer = "Abstract collection:ComputerInterface collection:SmartPhoneComputer";
            var aCollection = new List<object>();

            string aInfo ="Abstract collection:";

            var iCollection = new List<object>();

            string iInfo = "Interface collection:";

            var collection = new List<object> { new Phone(), new SmartPhone(), new Computer() };

            foreach (var item in collection)
            {
                var baseType = item.GetType().BaseType;
                if (baseType != null && typeof(APhone).IsSubclassOf(baseType))
                {
                    aCollection.Add(item);
                    aInfo += item.GetType().Name;
                }
                foreach (var value in item.GetType().GetInterfaces())
                {
                    if (value.Name == typeof(IInternet).Name)
                    {
                        iCollection.Add(item);
                        iInfo += item.GetType().Name;
                        break;
                    }
                }
            }
            string allInfo = aInfo + iInfo;
            Assert.AreEqual(answer,allInfo);
        }

        /// <summary>
        /// Tests the attributes. Get Information from attributes.
        /// </summary>
        [TestMethod]
        public void TestAttributes()
        {
            string answer =
                "Type: Stelmashok.OSSP.Lab2.Computerpublic properties:ValueType: Stelmashok.OSSP.Lab2.Phonepublic properties:NumberType: Stelmashok.OSSP.Lab2.SmartPhonepublic properties:ValueNumber";
            string[] AttributeNames = new[] {"HomePhone", "Device", "Mobile"};
            string allInfo = string.Empty;

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
                        allInfo += "Type: " + obj.GetType().ToString() 
                                   + "public properties:";
                        foreach (var propertie in obj.GetType().GetProperties())
                        {
                            allInfo += propertie.Name;
                        }
                    }
                }
            }
            Assert.AreEqual(answer,allInfo);
        }
    }
}
