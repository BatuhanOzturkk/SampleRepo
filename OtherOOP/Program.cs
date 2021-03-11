using System;

namespace OtherOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer realCustomer = new RealCustomer();
            realCustomer.RealCustomerName = "Batuhan";
            realCustomer.RealCustomerTcNo = "1111111111";
            realCustomer.CustomerNo = "2222";
            realCustomer.CustomerId = 1;

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.CustomerId = 2;
            corporateCustomer.CustomerNo = "22";
            corporateCustomer.CorporateCustomerTaxNo = "22222";
            corporateCustomer.CorporateCustomerCompanyName = "xx";

            Customer realCustomer2 = new RealCustomer();
            Customer corporateCustomer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(realCustomer);
            customerManager.Add(corporateCustomer);


        }
    }
}
