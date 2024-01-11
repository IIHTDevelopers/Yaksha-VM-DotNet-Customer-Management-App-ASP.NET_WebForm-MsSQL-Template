using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CustomerManagementApp.DAL.Interfaces;
using CustomerManagementApp.Model;

namespace CustomerManagementApp.DAL.Services
{
    public class CustomerService : Interfaces.ICustomerService
    {
        private Interfaces.ICustomerRepository _repository;

        public CustomerService(Interfaces.ICustomerRepository repository)
        {
            _repository = repository;
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

        public CustomerModel GetById(string id)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }
    }
}