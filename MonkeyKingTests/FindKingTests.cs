using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeyKing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyKing.Tests
{
    [TestClass()]
    public class FindKingTests
    {
        [TestMethod()]
        public void MonkeykingTest()
        {
            Monkey monkey = new FindKing();
            monkey.SetList(100);
            int a = monkey.Monkeyking(3);
            
        }
    }
}