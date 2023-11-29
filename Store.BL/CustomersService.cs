using Store.BL.Interface;
using Store.Dal.Interface;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL
{
    public class CustomersService : ICustomersService
    {
        readonly ICustomersRepository _CustomersRepository;
        public CustomersService(ICustomersRepository CustomersRepository)
        {
            _CustomersRepository = CustomersRepository;
        }
        public List<Customers> GetAll()
        {
            return _CustomersRepository.GetAll();
        }
        public bool? AddCustomer(Customers customer)
        {
            Customers productTExists = _CustomersRepository.GetCustomerByCode(customer.TZ);
            if (productTExists != null)
                return null;
            return _CustomersRepository.AddCustomer(customer);

        }

        public Customers GetCustomerByCode(int tz)
        {
            return _CustomersRepository.GetCustomerByCode(tz);
        }
        public bool RemoveCustomer(int tz)
        {
            return _CustomersRepository.RemoveCustomer(tz);
        }
        public bool UpdateCustomer(Customers customer)
        {
            return _CustomersRepository.UpdateCustomer(customer);
        }
    }
}
