
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetOdev
{
    public partial class Form1 : Form
    {

        SqlConnection cnn;

        public Form1()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglantim"].ConnectionString);

            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //SelectedValue databasedeki id okur.
            int id = (int)lstCategory.SelectedValue;
            //seçili item i verir.
            object item = lstCategory.SelectedItem;

            cnn.Open();

            SqlCommand cmd = new SqlCommand("delete  from categories where CategoryID=@CategoryID", cnn);

            cmd.Parameters.AddWithValue("@CategoryID", id);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Kayıt Silindi");
                //silince listboxtan da kaldırırız.
                clist.Remove((Category)item);
                //combobox veri kaynağını boşa çektik
                lstCategory.DataSource = null;
                //veri kaynağı güncel liste
                lstCategory.DataSource = clist;
                lstCategory.ValueMember = "CategoryID";
                lstCategory.DisplayMember = "CategoryName";
            }

            cnn.Close();
        }

        public class Category
        {
            public int CategoryId { get; set; } //id ye göre sorgu
            public string CategoryName { get; set; } // comboboxta göstericem ve seçileni textboxta göstericem
            public string Description { get; set; } // seçilen textboxtada göstericem


        }

        List<Category> clist;

        private void Form1_Load(object sender, EventArgs e)
        {

            //cnn.Open(); //Pooling => false ise açmalıyız

            SqlCommand cmd = new SqlCommand("select * from categories", cnn);

            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                clist = new List<Category>();

                while (rd.Read())
                {

                    clist.Add(new Category
                    {
                        CategoryId = (int)rd["CategoryID"],
                        CategoryName = rd["CategoryName"].ToString(),
                        Description = rd["Description"].ToString()
                    });
                }

                //veri kaynağın clist
                lstCategory.DataSource = clist;
                //valuememberda ise database id tutulur. işlem yaparken silme güncelleme pk olan idlerden işlem yapıyoruz. hem indexten dolayı hızlı hemde unique 
                lstCategory.ValueMember = "CategoryID";
                //görüntülenecek olan displaymemberdan gelir
                lstCategory.DisplayMember = "CategoryName";

                rd.Close();
                //cnn.Close(); pooling => false  
            }
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Category c = lstCategory.SelectedItem as Category;

            Category selectedItem = lstCategory.SelectedItem as Category;

            if (selectedItem != null)
            {
                textBox1.Text = selectedItem.CategoryName;
                textBox2.Text = selectedItem.Description;
            }

            //SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglantim"].ConnectionString);

            //if (cnn.State == ConnectionState.Closed)
            //    cnn.Open();


            //SqlCommand cmd = new SqlCommand("select * from categories where categoryId=@categoryId",cnn);
            //cmd.Parameters.AddWithValue("@categoryId", c.CategoryId);

            //SqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    textBox1.Text = rd.GetString(1); //rd["CategoryName"]
            //    textBox2.Text = rd.GetValue(2).ToString(); //rd["Description"] // null olarak geçilebilen değerler varsa genelde getvalue ile okuyabiliriz.
            //}

            //rd.Close();

            //if (rd.IsClosed)
            //    cnn.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category selectedItem = lstCategory.SelectedItem as Category;

            cnn.Open();

            SqlCommand cmd = new SqlCommand("update categories set CategoryName=@CategoryName,Description=@Description where categoryId=@categoryId", cnn);
            cmd.Parameters.AddWithValue("@categoryId", selectedItem.CategoryId);
            cmd.Parameters.AddWithValue("@CategoryName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Description", textBox2.Text);

            int r = cmd.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                lstCategory.DataSource = null;

                for (int i = 0; i < clist.Count; i++)
                {
                    if (clist[i].CategoryId == selectedItem.CategoryId)
                    {
                        clist[i].CategoryName = textBox1.Text;
                        clist[i].Description = textBox2.Text;
                        break;
                    }
                }

                //listbox güncellenen clist oldu.
                lstCategory.DataSource = clist;
                lstCategory.DisplayMember = "CategoryName";
                lstCategory.ValueMember = "CategoryID";

                //cnn.Close(); => pooling => false  
            }



        }
    }
}
