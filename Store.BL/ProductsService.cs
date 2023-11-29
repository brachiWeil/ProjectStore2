using Store.BL.Interface;
using Store.Dal;
using Store.Dal.Interface;
using Store.model;
using Store.Model;


//
//מקבל מהקונטרולר הפעלת פונקציה ולפעמים גם נתונים  ומעביר לרפוזיטורי , מקבל בחזרה את הנתונים מהריפוזיטורי

namespace Store.BL
{
    public class ProductsService: IProductsService
    {
        readonly IProductsRepository _Repository;
        public ProductsService(IProductsRepository Repository)
        {
            _Repository = Repository;
        }
        
        public bool? AddProduct(Products p)
        {
            Products productTExists = _Repository.GetProductByCode(p.Barkode);
            if (productTExists != null)
                return null;
            return _Repository.AddProduct(p);
           
        }
        public List<Products> GetAll()
        {
            return _Repository.GetAll();
        }


        public Products GetProductByCode(string barkode)
        {
            return _Repository.GetProductByCode(barkode);
        }
        public bool RemoveProduct(string barkode)
        {
            return _Repository.RemoveProduct(barkode);
        }
        public bool UpdateProduct(Products product)
        {
            return _Repository.UpdateProduct(product);
        }
    }
}