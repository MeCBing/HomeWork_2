using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyKing
{
    class Program
    {
        static void Main(string[] args)
        {
            int total=0, n=0;
            Console.Write("請輸入猴子總數 :");
            int.TryParse(Console.ReadLine(), out total);
            Console.Write("請輸入N :");
            int.TryParse(Console.ReadLine(), out n);
            Monkey monkey = new FindKing();
            monkey.SetList(total);
            Console.WriteLine($"第 {monkey.Monkeyking(n)} 隻是猴王");
            Console.ReadLine();
        }
    }
}
