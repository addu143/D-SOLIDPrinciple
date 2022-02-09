using System;

namespace WithDIP
{
    public class DataAccessLayer : IRepository
    {
        public void SaveCustomer(object obj)
        {
            Console.WriteLine("Successfully Saved");
        }
    }
}
