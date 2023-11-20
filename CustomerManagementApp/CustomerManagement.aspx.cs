using CustomerManagementApp.DAL;
using CustomerManagementApp.Model;
using System;
using System.Web.UI;

namespace CustomerManagementApp
{
    public partial class CustomerManagement : Page
    {
        private readonly datalayer _dataLayer;
        private readonly CustomerManagementApp.DAL.Interfaces.ICustomerService _customerService;

        public CustomerManagement()
        {
            _dataLayer = new datalayer();
            _customerService = new DAL.Services.CustomerService(new DAL.Services.CustomerRepository(new CustomerManagementApp.DAL.CustomerDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        { //write your code here
            throw new NotFiniteNumberException();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }
    }
}
