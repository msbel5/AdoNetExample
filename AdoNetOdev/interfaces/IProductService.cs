using AdoNetOdev.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetOdev.interfaces
{
    public interface IProductService
    {
        void Insert(Product model);
        void Delete(int Id);
        void Update(Product model);
        List<Product> Select();
        int Save();
    }
}
