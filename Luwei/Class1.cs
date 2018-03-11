using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luwei
{
    static class Class1
    {
        private static List<Food> food;
        private static List<int> money;
        public static void SetTotal(string text1,string text2,string text3,string text4)
        {
            int[] total = new int[4];
            int.TryParse(text1, out total[0]);
            int.TryParse(text2, out total[1]);
            int.TryParse(text3, out total[2]);
            int.TryParse(text4, out total[3]);
            food = new List<Food>
            {
                new Food() {Name = "高麗菜", Price = 30, Total = total[0]},
                new Food() {Name = "豆干", Price = 15, Total = total[1]},
                new Food() {Name = "海帶", Price = 15, Total = total[2]},
                new Food() {Name = "肉片", Price = 40, Total = total[3]}
            };
            money = new List<int>
            {
                1000,
                500,
                100,
                50,
                10,
                5,
                1
            };
        }
        public static string Printf()
        {
            string s = string.Empty;
            int Howmuch = 0;
            foreach (var index in food)
            {
                int money = index.Price * index.Total;
                Howmuch = Howmuch + money;
            }
            s = Howmuch.ToString();
            s = s + FindMoney(Howmuch, 0);
            return s;
        }

        public static string FindMoney(int Howmuch, int i)
        {
            string s = $"\n\n{money[i]} 元 需要 : {Howmuch / money[i]}";
            Howmuch = Howmuch % money[i];
            i++;
            if (i != money.Count)
            {
                s = s + FindMoney(Howmuch, i);
            }
            return s;
        }
    }
}
