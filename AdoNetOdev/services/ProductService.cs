using AdoNetOdev.interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetOdev.models;
using AdoNetOdev.types;

namespace AdoNetOdev.services
{
    public class ProductService:IProductService,IProductOrder,IProductSearch,IProductSearchByName
    {

        SqlConnection _conn;
        SqlCommand cmd;
        private OrderType _orderType = OrderType.Descending;
        private List<Product> _plist;
        private string _orderTypeString;

        public ProductService(string connectionString)
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            _conn.Open();
            _plist = new List<Product>();

        }


        private void CheckOrderType()
        {
            if (_orderType==OrderType.Descending)
            {
                _orderTypeString = "asc";
                _orderType = OrderType.Ascending;
            }
            else
            {
                _orderType = OrderType.Descending;
                _orderTypeString = "desc";
            }
        }

        

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product model)
        {
            throw new NotImplementedException();
        }

        public List<Product> OrderByName()
        {
            _plist.Clear();
            CheckOrderType();

            string query = "select ProductId,ProductName,UnitPrice,UnitsInStock from products order by productname " + _orderTypeString;
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = _conn;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id,name,price,stock);
                _plist.Add(p);
            }

            return _plist;
        }

        public List<Product> OrderByPrice()
        {
            _plist.Clear();
            CheckOrderType();

            string query = "select ProductId,ProductName,UnitPrice,UnitsInStock from products order by UnitPrice " + _orderTypeString;
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = _conn;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id, name, price, stock);
                _plist.Add(p);
            }

            return _plist;
        }

        public List<Product> OrderByStock()
        {
            _plist.Clear();
            CheckOrderType();

            string query = "select ProductId,ProductName,UnitPrice,UnitsInStock from products order by unitsinstock " + _orderTypeString;
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = _conn;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id, name, price, stock);
                _plist.Add(p);
            }

            return _plist;
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(short? minStock, short? maxStock)
        {
            _plist.Clear();
            string query = "SpSearchByStock";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.AddWithValue("@minStock", minStock);
            cmd.Parameters.AddWithValue("@maxStock", maxStock);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id, name, price, stock);
                _plist.Add(p);
            }
            return _plist;
        }

        public List<Product> Search(decimal? minPrice, decimal? maxPrice)
        {
            _plist.Clear();
            string query = "SpSearchByPrice";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.AddWithValue("@minPrice", minPrice);
            cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id, name, price, stock);
                _plist.Add(p);
            }
            return _plist;
        }

        public List<Product> Select()
        {
            string query = "select ProductID,ProductName,UnitPrice,UnitsInStock from Products  order by ProductName asc";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = _conn;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id, name, price, stock);
                _plist.Add(p);
            }

            return _plist;
        }

        public void Update(Product model)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(SearchByNameType criteria,string searchtext)
        {
            _plist.Clear();
            string query = "SpSearchByProductName";
            //store proc ismi
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //store proc tipinde
            cmd.Connection = _conn;

            int r = (int)criteria;

            //ve parametreler tanımlanır.
            cmd.Parameters.AddWithValue("@text", searchtext);
            cmd.Parameters.AddWithValue("@criteria", r);
          

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int? id = rd.GetInt32(0);
                short? stock = rd.GetInt16(3);
                decimal? price = rd.GetDecimal(2);
                string name = rd.GetString(1);
                Product p = new Product(id, name, price, stock);
                _plist.Add(p);
            }

            return _plist;
        }
    }
}
