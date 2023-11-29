using Store.Dal.Interface;
using Store.model;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal
{
    public class CustomersRepository: ICustomersRepository
    {
        readonly StoreContext _customerContext;
        public CustomersRepository(StoreContext customerContext)
        {
            _customerContext = customerContext;
        }

        public List<Customers> GetAll()
        {
            return _customerContext.Customers.ToList();
        }


        public bool? AddCustomer(Customers customer)
        {
            try
            {
                _customerContext.Add(customer);
                _customerContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
        public Customers GetCustomerByCode(int tz)
        {
            return _customerContext.Customers.Where(t => t.TZ == tz).FirstOrDefault();
        }

        public bool RemoveCustomer(int tz)
        {
            try
            {
                Customers p = _customerContext.Customers.Where(t => t.TZ == tz).FirstOrDefault();
                if (p != null)
                {
                    _customerContext.Remove(p);
                    _customerContext.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                Customers c = _customerContext.Customers.Where((t) => t.TZ == customer.TZ).FirstOrDefault();
                if (c != null)
                {
                    c.FirstName = customer.FirstName;
                    c.LastName = customer.LastName;
                    c.Street = customer.Street;
                    c.City = customer.City;
                    c.ClubStatus = customer.ClubStatus;
                    c.Email = customer.Email;

                    _customerContext.Update(c);
                    _customerContext.SaveChanges();


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
