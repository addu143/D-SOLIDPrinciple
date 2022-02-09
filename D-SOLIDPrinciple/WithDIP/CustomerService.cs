using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDIP
{
    public class CustomerService
    {
        private readonly IRepository _repositoryLayer;
        public CustomerService(IRepository repositoryLayer) 
        { 
            _repositoryLayer = repositoryLayer;
        }
        public void Save(Object obj)
        {
            _repositoryLayer.SaveCustomer(obj);
        }

    }
}
