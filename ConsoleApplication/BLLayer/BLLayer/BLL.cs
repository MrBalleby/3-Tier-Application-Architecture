using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_Layer;

namespace BL_Layer
{
    class Bll
    {
        public Dal dal = new Dal();

        //Custtable
        public void AddNewCustomer(string firstname, string surname, int age, string mail, int phone, int customerGroupId, int AddressId)
        {
            dal.AddCostumerDB(firstname, surname, age, mail, phone, customerGroupId, AddressId);
        }

        public void UpdateCustomer(int id, string firstname, string surname, int age, string mail, int phone, int customerGroupId, int AddressId)
        {
            dal.UpdateCustomerDB(id, firstname, surname, age, mail, phone, customerGroupId, AddressId);
        }

        public void DeleteCustomer(int id)
        {
            dal.DeleteCustomerAddressDB(id);
        }

        public object GetCustomer()
        {
            return dal.GetCustomerDB();
        }

        //CustAddresstable
        public void AddCustomerAddress(string street, int number, string city, int zip)
        {
            dal.AddCostumerAddressDB(street, number, city, zip);
        }

        public void UpdateCustomerAddress(int id, string street, int number, string city, int zip)
        {
            dal.UpdateCostumerAddressDB(id, street, number, city, zip);
        }

        public void DeleteCustomerAddress(int id)
        {
            dal.DeleteCustomerAddressDB(id);
        }

        public object GetCustomerAddress()
        {
            return dal.GetCostumerAddressDB();
        }

        //CustAddresstable
        public void AddCustomerAddress(string street, int number, string city, int zip)
        {
            dal.AddCostumerAddressDB(street, number, city, zip);
        }

        public void UpdateCustomerAddress(int id, string street, int number, string city, int zip)
        {
            dal.UpdateCostumerAddressDB(id, street, number, city, zip);
        }

        public void DeleteCustomerAddress(int id)
        {
            dal.DeleteCustomerAddressDB(id);
        }

        public object GetCustomerAddress()
        {
            return dal.GetCostumerAddressDB();
        }

    }
}
