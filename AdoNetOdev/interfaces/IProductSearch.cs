using AdoNetOdev.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetOdev.interfaces
{
    public interface IProductSearch
    {
        List<Product> Search(decimal? minPrice, decimal? maxPrice);
        List<Product> Search(short? minStock, short? maxStock);
    }
}
