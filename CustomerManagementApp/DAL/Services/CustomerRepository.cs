using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CustomerManagementApp.DAL.Interfaces;

namespace CustomerManagementApp.DAL.Services
{
    public class CustomerRepository : Interfaces.ICustomerRepository
    {
        private CustomerDbContext _context;

        public CustomerRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public Model.CustomerModel GetById(string id)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public string GetAll()
        {
           //write your code here
           throw new NotFiniteNumberException();
        }

        public string Add()
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public string Update()
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotFiniteNumberException();
        }
    }
}