using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_Layer;

namespace BL_Layer
{
    public class Bll
    {
        public Dal dal = new Dal();
        public object x;

        //Custtable
        public void AddNewCustomer(string firstname, string surname, int age, string mail, int phone, int customerGroupId, int AddressId)
        {
            dal.AddCustomerDB(firstname, surname, age, mail, phone, customerGroupId, AddressId);
        }

        public void UpdateCustomer(int id, string firstname, string surname, int age, string mail, int phone, int customerGroupId, int AddressId)
        {
            dal.UpdateCustomerDB(id, firstname, surname, age, mail, phone, customerGroupId, AddressId);
        }

        public void DeleteCustomer(int id)
        {
            dal.DeleteCustomerDB(id);
        }

        public object GetCustomer()
        {
            return dal.GetCustomerDB();
        }

        //CustAddresstable
        public void AddCustomerAddress(string street, int number, string city, int zip)
        {
            dal.AddCustomerAddressDB(street, number, city, zip);
        }

        public void UpdateCustomerAddress(int id, string street, int number, string city, int zip)
        {
            dal.UpdateCustomerAddressDB(id, street, number, city, zip);
        }

        public void DeleteCustomerAddress(int id)
        {
            dal.DeleteCustomerAddressDB(id);
        }

        public object GetCustomerAddress()
        {
            return dal.GetCustomerAddressDB();
        }

        //CustGrouptable
        public void AddCustomerGroup(string Gname, string grouptype, string custtype, int ticketId)
        {
            dal.AddCustomerGroupDB(Gname, grouptype, custtype, ticketId);
        }

        public void UpdateCustomerGroup(int id, string Gname, string grouptype, string custtype, int ticketId)
        {
            dal.UpdateCustomerGroupDB(id, Gname, grouptype, custtype, ticketId);
        }

        public void DeleteCustomerGroup(int id)
        {
            dal.DeleteCustomerGroupDB(id);
        }

        public object GetCustomerGroup()
        {
            return dal.GetCustomerGroupDB();
        }

        //Cust_CustGrouptable
        public void AddCustomer_CustomerGroup(int custId, string custName, string custMail, string groupName, int ticketId)
        {
            dal.AddCustomer_CustomergroupDB(custId, custName, custMail, groupName, ticketId);
        }

        public void UpdateCustomer_CustomerGroup(int id, int custId, string custName, string custMail, string groupName, int ticketId)
        {
            dal.UpdateCustomer_CustomergroupDB(id, custId, custName, custMail, groupName, ticketId);
        }

        public void DeleteCustomer_CustomerGroup(int id)
        {
            dal.DeleteCustomer_CustomergroupDB(id);
        }

        public object GetCustomer_CustomerGroup()
        {
            return dal.GetCustomer_CustomergroupDB();
        }

        //EventTickets_TicketSold
        public void AddEventTickets_TicketSold(string eventname, DateTime eventDate, int groupId, int ticketId, string custtype, string ticketType)
        {
            dal.AddEventTickets_TicketSoldDB(eventname, eventDate, groupId, ticketId, custtype, ticketType);
        }

        public void UpdateEventTickets_TicketSold(int id, string eventname, DateTime eventDate, int groupId, int ticketId, string custtype, string ticketType)
        {
            dal.UpdateEventTickets_TicketSoldDB(id, eventname, eventDate, groupId, ticketId, custtype, ticketType);
        }

        public void DeleteEventTickets_TicketSold(int id)
        {
            dal.DeleteEventTickets_TicketSoldDB(id);
        }

        public object GetEventTickets_TicketSold()
        {
            return dal.GetEventTickets_TicketSoldDB();
        }


        //ConcertHalltable
        public void AddConcertHall(string Cname, string ticketType, int totalOfPpl, int AddressId)
        {
            dal.AddConcertHallDB(Cname, ticketType, totalOfPpl, AddressId);
        }

        public void UpdateConcertHall(int id, string Cname, string ticketType, int totalOfPpl, int AddressId)
        {
            dal.UpdateConcertHallDB(id, Cname, ticketType, totalOfPpl, AddressId);
        }

        public void DeleteConcertHall(int id)
        {
            dal.DeleteConcertHallDB(id);
        }

        public object GetConcertHall()
        {
            return dal.GetConcertHallDB();
        }

        //EventsTable
        public void AddEvents(string EventName, DateTime eventDate, string groupType, string custtype)
        {
            dal.AddEventsDB(EventName, eventDate, groupType, custtype);
        }

        public void UpdateEvents(int id, string EventName, DateTime eventDate, string groupType, string custtype)
        {
            dal.UpdateEventsDB(id, EventName, eventDate, groupType, custtype);
        }

        public void DeleteEvents(int id)
        {
            dal.DeleteEventsDB(id);
        }

        public object GetEvents()
        {
            return dal.GetEventsDB();
        }

        //Events_ConcertHalltable
        public void AddEvents_ConcertHall(string eventName, DateTime eventDate, int totalOfPpl, string ticketType)
        {
            dal.AddEvents_ConcertHallDB(eventName, eventDate, totalOfPpl, ticketType);
        }

        public void UpdateEvents_ConcertHall(int id, string eventName, DateTime eventDate, int totalOfPpl, string ticketType)
        {
            dal.UpdateEvents_ConcertHallDB(id, eventName, eventDate, totalOfPpl, ticketType);
        }

        public void DeleteEvents_ConcertHall(int id)
        {
            dal.DeleteEvents_ConcertHallDB(id);
        }

        public object GetEvents_ConcertHall()
        {
            return dal.GetEvents_ConcertHallDB();
        }

        //Event_Custgroup

        public void AddEvents_CustGroup(string eventName, string groupName, int groupId, int ticketId)
        {
            dal.AddEvents_CustomergroupDB(eventName, groupName, groupId, ticketId);
        }

        public void UpdateEvents_CustGroup(int id, string eventName, string groupName, int groupId, int ticketId)
        {
            dal.UpdateEvents_CustomergroupDB(id, eventName, groupName, groupId, ticketId);
        }

        public void DeleteEvents_CustGroup(int id)
        {
            dal.DeleteEvents_CustomergroupDB(id);
        }

        public object GetEvents_CustGroup()
        {
            return dal.GetEvents_CustomergroupDB();
        }
    }
}
