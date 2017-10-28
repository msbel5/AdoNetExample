using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetOdev.models
{
    public class Product
    {
        private string _name;
        private decimal? _price;
        private short? _stock;
        private int? _id;

        public Product(int? id,string name,decimal? price,short? stock)
        {
            _id = id;
            _name = name;
            _price = price;
            _stock = stock;
        }


        public int? Id {
            get { return _id; }

        } // ProductId

        public string  ProductName {
            get { return _name.ToUpper().Trim(); }
           
        }

        public decimal? Price {
            get {
                return (_price<0 ? 0:_price);
            }
           
        } //boş geçilebilir alan
        public short? Stock {
            get
            {
                _stock = (_stock < 0 ? 0:_stock);
                _stock = (_stock > 100 ? 100 : _stock);

                return _stock;
            }

        }  //boş geçilebilir.
         
    }
}
