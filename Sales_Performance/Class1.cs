using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales_Performance.Models;

namespace Sales_Performance
{
    public interface IData
    {
        List<NameTable> SetNameData();
        List<ProductTable> SetProductData();
    }
    public abstract class MyData : IData
    {
        public abstract List<NameTable> SetNameData();
        public abstract List<ProductTable> SetProductData();
    }
    public class NameData : MyData
    {
        public override List<NameTable> SetNameData()
        {
            var excelFile = new ExcelQueryFactory(@"C:\Build school\HomeWork_2\Sales_Performance\bin\Debug\Sales.xlsx");
            var excel = excelFile.Worksheet<Class2.Exl>("工作表1");
            List<NameTable> list = new List<NameTable>();
            foreach (var items in excel)
            {
                var restaurant = new NameTable
                {
                    Name = items.業務員,
                    Point_pen = int.Parse(items.原子筆),
                    Pencil = int.Parse(items.鉛筆),
                    Eraser = int.Parse(items.橡皮擦),
                    Ruler = int.Parse(items.直尺),
                    Liquid_paper = int.Parse(items.立可白),
                    Total_sales = 12 * int.Parse(items.原子筆)
                    + 16 * int.Parse(items.鉛筆)
                    + 10 * int.Parse(items.橡皮擦)
                    + 14 * int.Parse(items.直尺)
                    + 15 * int.Parse(items.立可白)
                };
                list.Add(restaurant);
            }
            return list;
        }

        public override List<ProductTable> SetProductData()
        {
            List<ProductTable> d = new List<ProductTable>();
            return d;
        }
    }
    public class ProductData : MyData
    {
        public override List<ProductTable> SetProductData()
        {
            var excelFile = new ExcelQueryFactory(@"C:\Build school\HomeWork_2\Sales_Performance\bin\Debug\Sales.xlsx");
            var excel = excelFile.Worksheet<Class3>("工作表2");
            List<ProductTable> list = new List<ProductTable>();
            List<int> ls = new List<int>()
            {
                33+77+43,
                32+33+55,
                56+68+43,
                45+45+67,
                33+23+65
            };
            int i = 0;
            foreach (var items in excel)
            {
                var restaurant = new ProductTable
                {
                    Product = items.產品,
                    Price = int.Parse(items.價格),
                    Total_sales = int.Parse(items.價格) * (ls[i])
                };
                list.Add(restaurant);
                i++;
            }
            return list;
        }
        public override List<NameTable> SetNameData()
        {
            List<NameTable> d = new List<NameTable>();
            return d;
        }
    }
}
