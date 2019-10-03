using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Layer
{
    interface IConcertHall
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ticketType { get; set; }
        public Nullable<int> totalOfPpl { get; set; }
        public int AddressId { get; set; }
    }
    interface ICostumer
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public Nullable<int> age { get; set; }
        public string mail { get; set; }
        public Nullable<int> phone { get; set; }
        public Nullable<int> customerGroupId { get; set; }
        public int AddressId { get; set; }
    }
    interface ICostumer_Customergroup
    {
        public int id { get; set; }
        public Nullable<int> custId { get; set; }
        public string custName { get; set; }
        public string custMail { get; set; }
        public string groupName { get; set; }
        public Nullable<int> ticketId { get; set; }
    }
    interface ICustomerAddress
    {
        public int id { get; set; }
        public string street { get; set; }
        public Nullable<int> number { get; set; }
        public string city { get; set; }
        public Nullable<int> zip { get; set; }
    }
    interface ICustomerGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public string grouptype { get; set; }
        public string custtype { get; set; }
        public int ticketId { get; set; }
    }
    interface IEvents
    {
        public int id { get; set; }
        public string eventName { get; set; }
        public Nullable<System.DateTime> eventDate { get; set; }
        public string grouptype { get; set; }
        public string custtype { get; set; }
    }
    interface IEvents_ConcertHall
    {
        public int id { get; set; }
        public string eventName { get; set; }
        public Nullable<System.DateTime> eventDate { get; set; }
        public Nullable<int> totalOfPpl { get; set; }
        public string ticketType { get; set; }
    }
    interface IEvents_Customergroup
    {
        public int id { get; set; }
        public string eventName { get; set; }
        public string groupName { get; set; }
        public Nullable<int> groupId { get; set; }
        public Nullable<int> ticketId { get; set; }
    }
    interface IEventTickets_TicketSold
    {
        public int id { get; set; }
        public string eventname { get; set; }
        public Nullable<System.DateTime> eventDate { get; set; }
        public Nullable<int> groupId { get; set; }
        public Nullable<int> ticketId { get; set; }
        public string custtype { get; set; }
        public string ticketType { get; set; }
    }
}

