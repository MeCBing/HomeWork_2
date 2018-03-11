using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Models;

namespace Transportation
{
    static class Class2
    {
        private static decimal Discount { get; set; }
        private static decimal Price { get; set; }
        public static List<TransportatiionTable> PrintfData()
        {
            TransportatiionModel context = new TransportatiionModel();
            var list = context.TransportatiionTable.ToList();
            return list;
        }

        public static List<string> SetCombox_1()
        {
            TransportatiionModel context = new TransportatiionModel();
            var listTest = context.TransportatiionTable.ToList();
            var data = listTest.GroupBy((x) => x.StartState);
            List<string> list = new List<string>();
            foreach (var d in data)
            {
                list.Add(d.Key);
            }
            return list;
        }
        public static List<string> SetCombox_2()
        {
            TransportatiionModel context = new TransportatiionModel();
            var listTest = context.TransportatiionTable.ToList();
            var data = listTest.GroupBy((x) => x.EndState);
            List<string> list = new List<string>();
            foreach (var d in data)
            {
                list.Add(d.Key);
            }
            return list;
        }

        public static string CheckPrintf(bool radio1,bool check1, bool check2, string combox1, string combox2)
        {
            CheckBoxCheck(radio1,check1, check2, combox1, combox2);
            return $"票價為 : {Math.Ceiling(Discount * Price)}";
        }

        public static void CheckBoxCheck(bool radio1, bool check1, bool check2, string combox1, string combox2)
        {
            Discount = 0;
            Price = 0;
            TransportatiionTable v;
            TransportatiionModel context = new TransportatiionModel();
            var listTest = context.TransportatiionTable.ToList();
            if (radio1)
            {
                v = listTest.FirstOrDefault((x) => x.StartState == combox1 && x.EndState == combox2);
            }
            else
            {
                v = listTest.FirstOrDefault((x) => x.EndState == combox1 && x.StartState == combox2);
            }
            if (check1 && check2)
            {
                Discount = 0.81M;
                Price = v.Price * 2;
            }
            else if (check1 || check2)
            {
                Discount = 0.9M;
                if (check1)
                {
                    Price = v.Price * 2;
                }
                else if (check2)
                {
                    Price = v.Price;
                }
            }
            else
            {
                Discount = 1;
                Price = v.Price;
            }
        }
    }
}
