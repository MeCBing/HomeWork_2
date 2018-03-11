using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using Sales_Performance.Models;

namespace Sales_Performance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Run();
        }
        public void SetGridView()
        {
            MyData myData = new NameData();
            var nameTables = myData.SetNameData();
            foreach(var items in nameTables)
            {
                try
                {
                    TestModel context = new TestModel();
                    context.NameTable.Add(items);
                    int a = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


            MyData myData1 = new ProductData();
            var productTables = myData1.SetProductData();
            foreach (var items in productTables)
            {
                try
                {
                    TestModel context1 = new TestModel();
                    context1.ProductTable.Add(items);
                    context1.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }
        public void PrintfData()
        {
            var context = new TestModel();
            var list = context.NameTable.ToList();
            dataGridView1.DataSource = list;

            var context1 = new TestModel();
            var list1 = context1.ProductTable.ToList();
            dataGridView2.DataSource = list1;
        }

        public void Run()
        {
            SetGridView();
            PrintfData();
            FindSales();
            FindProduct();
        }

        public void FindSales()
        {
            var context = new TestModel();
            var list = context.NameTable.ToList();
            var bastsales = list.FirstOrDefault((x) => x.Total_sales == list.Max((y) => y.Total_sales));
            label3.Text = label3.Text + bastsales.Name;
        }
        public void FindProduct()
        {
            var context1 = new TestModel();
            var list1 = context1.ProductTable.ToList();
            var bastProduct = list1.FirstOrDefault((x) => x.Total_sales == list1.Max((y) => y.Total_sales));
            label4.Text = label4.Text + bastProduct.Product;
        }
    }
}
