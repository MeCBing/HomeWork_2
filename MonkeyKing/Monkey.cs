using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyKing
{
    public interface IMonkey
    {
        int Monkeyking(int n);
    }
    public abstract class Monkey : IMonkey
    {
        public List<int> list = new List<int>();
        public void SetList(int total)
        {
            for(int i=1;i<total+1;i++)
            {
                list.Add(i);
            }
        }
        public abstract int Monkeyking(int n);
    }
    public class FindKing : Monkey
    {
        public override int Monkeyking(int n)
        {
            int now = 0;
            while (true)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        list.Remove(list[now]);
                        if(now == 0)
                        {
                            now = list.Count - 1;
                        }
                        else
                        {
                            now = now - 1;
                        }
                    }
                    if(now==list.Count-1)
                    {
                        now = 0;
                    }
                    else
                    {
                        now = now + 1;
                    }
                }
                foreach (var index in list)
                {
                    Console.Write($" {index.ToString()} ");
                }
                Console.WriteLine();
                if (list.Count == 1)
                {
                    return list[0];
                }
                
            }
        }
    }
}
