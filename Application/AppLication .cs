using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IAppLication
    {
        void ADD();
    }
    public class NowNumber
    {
        public int Id { get; set; }
        public Int64 Now { get; set; }
    }

    public abstract class Number : IAppLication
    {
        public List<NowNumber> list = new List<NowNumber>();
        public abstract void ADD();
    }
    public class AppLication : Number
    {
        public override void ADD()
        {
            if(list.Count<2)
            {
                NowNumber number = new NowNumber()
                {
                    Id = list.Count,
                    Now = 1
                };
                list.Add(number);
            }
            else
            {
                var now_1 = list.FirstOrDefault((x)=> x.Id == list.Max((y)=>y.Id));
                var now_2 = list.FirstOrDefault((x) => x.Id == (now_1.Id - 1));
                Int64 now = now_1.Now + now_2.Now;
                NowNumber number = new NowNumber()
                {
                    Id = now_1.Id + 1,
                    Now = now
                };
                list.Add(number);
            }
            if(list.Max((x)=>x.Now) < 1836311903)
            {
                ADD();
            }
        }
    }
}
