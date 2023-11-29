using Store.Dal.Interface;
using Store.model;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//, מקבל מהסרביס הפעלת פונקציה ולפעמים גם נתונים  ניגש למופע של הקונטקסט שהוא מכיל
//עושה את הפעולה על הנתונים ומחזיר (לסרויס) את הנתונים שבקשו ממנו

namespace Store.Dal
{
    public class ProductsRepository: IProductsRepository
    {
        readonly StoreContext _productContext;
        public ProductsRepository(StoreContext productContext)
        {
            _productContext = productContext;   
        }



        public bool? AddProduct(Products product)
        {
            try
            {
                _productContext.Add(product);
                _productContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Products> GetAll()
        {
            return _productContext.Products.ToList();
        }
        public Products GetProductByCode(string barkode)
        {
            return _productContext.Products.Where(t => t.Barkode == barkode).FirstOrDefault();
        }

        public bool RemoveProduct(string barkode)
        {
            try
            {
                Products p = _productContext.Products.Where(t => t.Barkode == barkode).FirstOrDefault();
                if (p != null)
                {
                    _productContext.Remove(p);
                    _productContext.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateProduct(Products product)
        {
            try
            {
                Products p = _productContext.Products.Where((t) => t.Barkode == product.Barkode).FirstOrDefault();
                if (p != null)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.MaxSize = product.MaxSize;
                    p.MinSize = product.MinSize;
                    p.QtyInventory = product.QtyInventory;
                    _productContext.Update(p);
                    _productContext.SaveChanges();


                }
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
