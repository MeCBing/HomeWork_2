using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests
{
    [TestClass()]
    public class AppLicationTests
    {
        [TestMethod()]
        public void ADDTest()
        {
            Number number = new AppLication();
            number.ADD();
            foreach(var index in number.list)
            {
            }
        }
    }
}