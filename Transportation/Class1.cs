using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Models;

namespace Transportation
{
    static class Class1
    {
        static List<TransportatiionTable> listTest = new List<TransportatiionTable>();
        public static void SetData()
        {
            SetList();
            foreach(var index in listTest)
            {
                try
                {
                    TransportatiionModel context = new TransportatiionModel();
                    context.TransportatiionTable.Add(index);
                    context.SaveChanges();
                }
                catch
                {

                }
            }
        }
        private static void SetList()
        {
            listTest.Add(new TransportatiionTable() { StartState = "台北", EndState = "新竹", Price = 177 });
            listTest.Add(new TransportatiionTable() { StartState = "台北", EndState = "台中", Price = 375 });
            listTest.Add(new TransportatiionTable() { StartState = "台北", EndState = "嘉義", Price = 598 });
            listTest.Add(new TransportatiionTable() { StartState = "台北", EndState = "台南", Price = 738 });
            listTest.Add(new TransportatiionTable() { StartState = "台北", EndState = "高雄", Price = 842 });

            listTest.Add(new TransportatiionTable() { StartState = "新竹", EndState = "台中", Price = 197 });
            listTest.Add(new TransportatiionTable() { StartState = "新竹", EndState = "嘉義", Price = 421 });
            listTest.Add(new TransportatiionTable() { StartState = "新竹", EndState = "台南", Price = 560 });
            listTest.Add(new TransportatiionTable() { StartState = "新竹", EndState = "高雄", Price = 755 });

            listTest.Add(new TransportatiionTable() { StartState = "台中", EndState = "嘉義", Price = 224 });
            listTest.Add(new TransportatiionTable() { StartState = "台中", EndState = "台南", Price = 363 });
            listTest.Add(new TransportatiionTable() { StartState = "台中", EndState = "高雄", Price = 469 });

            listTest.Add(new TransportatiionTable() { StartState = "嘉義", EndState = "台南", Price = 139 });
            listTest.Add(new TransportatiionTable() { StartState = "嘉義", EndState = "高雄", Price = 245 });

            listTest.Add(new TransportatiionTable() { StartState = "台南", EndState = "高雄", Price = 106 });
        }
    }
}
