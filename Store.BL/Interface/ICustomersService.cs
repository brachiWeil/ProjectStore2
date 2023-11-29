using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL.Interface
{
    public interface ICustomersService
    {
        List<Customers> GetAll();
        bool? AddCustomer(Customers customer);
        bool RemoveCustomer(int tz);
        Customers GetCustomerByCode(int tz);
        bool UpdateCustomer(Customers customer);
    }
}
