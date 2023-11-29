using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Interface
{
    public interface ICustomersRepository
    {
        List<Customers> GetAll();
        bool? AddCustomer(Customers customer);
        bool RemoveCustomer(int tz);
        Customers GetCustomerByCode(int tz);
        bool UpdateCustomer(Customers customer);
    }
}
