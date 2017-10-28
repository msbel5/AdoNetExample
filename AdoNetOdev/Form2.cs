using AdoNetOdev.interfaces;
using AdoNetOdev.models;
using AdoNetOdev.services;
using AdoNetOdev.types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetOdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ProductService service = new ProductService("baglantim");

        private void Form2_Load(object sender, EventArgs e)
        {

            List<Product> plist = new List<Product>();
            plist = service.Select();

            FillData(plist);

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Int32 colIndex = Convert.ToInt32(e.Column.ToString());
            List<Product> dataSource = new List<Product>();

            if (colIndex == 0)
                dataSource = service.OrderByName();
            else if (colIndex == 1)
                dataSource = service.OrderByPrice();
            else if (colIndex == 2)
                dataSource = service.OrderByStock();
            else
                dataSource = service.OrderByName();

            FillData(dataSource);

        }


        public void FillData(List<Product> orderedItems)
        {
            listView1.Items.Clear();

            foreach (var item in orderedItems)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.ProductName;
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.Stock.ToString());
                li.Tag = item;

                listView1.Items.Add(li);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {

            List<Product> plist = new List<Product>();
           plist = service.Search(SearchByNameType.Contains
               ,txtName.Text);

            FillData(plist);
        }

        private void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            decimal? minPrice = decimal.Parse(txtMinPrice.Text);
            decimal? maxPrice = decimal.Parse(txtMaxPrice.Text);
            List<Product> plist = new List<Product>();
            plist = service.Search(minPrice, maxPrice);
            FillData(plist);
        }

        private void btnSearchByStock_Click(object sender, EventArgs e)
        {
            short? minPrice = short.Parse(txtMinStock.Text);
            short? maxPrice = short.Parse(txtMaxStock.Text);
            List<Product> plist = new List<Product>();
            plist = service.Search(minPrice, maxPrice);
            FillData(plist);
        }
    }
}
