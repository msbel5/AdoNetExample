using AdoNetOdev.models;
using AdoNetOdev.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetOdev.interfaces
{
    public interface IProductOrder
    {
        List<Product> OrderByPrice();
        List<Product> OrderByName();
        List<Product> OrderByStock();
    }
}
