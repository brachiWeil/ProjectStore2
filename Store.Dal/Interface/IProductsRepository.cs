using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Interface
{
    public interface IProductsRepository
    {
        bool? AddProduct(Products product);
        bool RemoveProduct(string barkode);
        List<Products> GetAll();
        Products GetProductByCode(string barkode);
        bool UpdateProduct(Products product);

    }
}
