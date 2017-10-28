using AdoNetOdev.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetOdev.interfaces
{
    public enum SearchByNameType
    {
        Contains,
        StartsWith,
        EndsWith
    }

    interface IProductSearchByName
    {
        List<Product> Search(SearchByNameType criteria,string searchtext);
    }
}
