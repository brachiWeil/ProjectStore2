using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL.Interface
{
    public interface IProductsService
    {
        bool? AddProduct(Products p);
        bool RemoveProduct(string barkode);
        Products GetProductByCode(string barkode);
        List<Products> GetAll();
        bool UpdateProduct(Products product);

    }
}
