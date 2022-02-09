using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDIP
{
    public class CustomerService
    {
        private readonly DataAccessLayer dal;
        public CustomerService() 
        { 
            dal = new DataAccessLayer();
        }
        public void Save(Object obj)
        {
            dal.SaveCustomer(obj);
        }

    }
}
