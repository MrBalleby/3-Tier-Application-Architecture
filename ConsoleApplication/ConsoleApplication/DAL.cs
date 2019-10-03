using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DA_Layer
{
    public class Dal : ICustumer, ICustumer_Customergroup, ICustomerAddress, ICustomerGroup, IEvents, IEvents_ConcertHall, IEvents_Customergroup, IEventTickets_TicketSold, IConcertHall
    {
        private string conn = ConfigurationManager.ConnectionStrings["CON"].ToString();

        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string firstname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string mail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? customerGroupId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AddressId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? custId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string custName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string custMail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string groupName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? ticketId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string city { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? zip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string grouptype { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string custtype { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICustomerGroup.ticketId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string eventName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? eventDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? totalOfPpl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ticketType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? groupId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string eventname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            cmd.ExecuteNonQuery();

        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sqlstring, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }


        //Func

        public void AddConcertHallDB(string Cname, string ticketType, int totalOfPpl, int AddressId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.ConcertHall (id, name, ticketType, totalOfPpl, AddressId) VALUES ('" + Cname + "','" + ticketType + "','" + totalOfPpl + "','" + AddressId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateConcertHallDB(int id, string Cname, string ticketType, int totalOfPpl, int AddressId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.ConcertHall set id='" + id + "',name = '" + Cname + "',ticketType= '" + ticketType + "',totalOfPpl = '" + totalOfPpl + "',AddressId = '" + AddressId + "' Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteConcertHallDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.ConcertHall Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object GetConcertHallDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.ConcertHall order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }



        public void AddEventTickets_TicketSoldDB(string eventname, DateTime eventDate, int groupId, int ticketId, string custtype, string ticketType)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.EventTickets_TicketSold (eventname, eventDate, groupId, ticketId, custtype, ticketType) VALUES ('" + eventname + "','" + eventDate + "','" + groupId + "','" + ticketId + "','" + custtype + "','" + ticketType + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateEventTickets_TicketSoldDB(int id, string eventname, DateTime eventDate, int groupId, int ticketId, string custtype, string ticketType)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.EventTickets_TicketSold set id='" + id + "',eventname = '" + eventname + "',eventDate= '" + eventDate + "',groupId = '" + groupId + "',ticketId = '" + ticketId + "',custtype = '" + custtype + "',ticketType = '" + ticketType + "' Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteEventTickets_TicketSoldDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.EventTickets_TicketSold Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetEventTickets_TicketSoldDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.EventTickets_TicketSold order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }



        public void AddEvents_CustomergroupDB(string eventName, string groupName, int groupId, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Events_Customergroup (eventName, groupName, groupId, ticketId) VALUES ('" + eventName + "','" + groupName + "','" + groupId + "','" + ticketId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateEvents_CustomergroupDB(int id, string eventName, string groupName, int groupId, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.Events_Customergroup set id='" + id + "',eventName = '" + eventName + "',groupName= '" + groupName + "',groupId = '" + groupId + "',ticketId = '" + ticketId + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteEvents_CustomergroupDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.Events_Customergroup Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetEvents_CustomergroupDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.Events_Customergroup order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }


        public void AddEvents_ConcertHallDB(string eventName, DateTime eventDate, int totalOfPpl, string ticketType)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Events_ConcertHall (eventName, eventDate, totalOfPpl, ticketType) VALUES ('" + eventName + "','" + eventDate + "','" + totalOfPpl + "','" + ticketType + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateEvents_ConcertHallDB(int id, string eventName, DateTime eventDate, int totalOfPpl, string ticketType)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.Events_ConcertHall set id='" + id + "',eventname = '" + eventName + "',eventDate= '" + eventDate + "',groupId = '" + totalOfPpl + "',ticketType = '" + ticketType + "' Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteEvents_ConcertHallDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.Events_ConcertHall Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetEvents_ConcertHallDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.Events_ConcertHall order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }



        public void AddEventsDB(string eventName, DateTime eventDate, string grouptype, string custtype)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Events_ (eventName, eventDate, grouptype, custtype) VALUES ('" + eventName + "','" + eventDate + "','" + grouptype + "','" + custtype + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateEventsDB(int id, string eventName, DateTime eventDate, string grouptype, string custtype)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.Events_ set id='" + id + "',eventName = '" + eventName + "',eventDate= '" + eventDate + "',grouptype = '" + grouptype + "',custtype = '" + custtype + "' Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteEventsDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.Events_ Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetEventsDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.Events_ order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }


        public void AddCustomerGroupDB(string Gname, string grouptype, string custtype, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.CustomerGroup (name, grouptype, custtype, ticketId) VALUES ('" + Gname + "','" + grouptype + "'','" + custtype + "','" + ticketId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomerGroupDB(int id, string Gname, string grouptype, string custtype, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.CustomerGroup set id='" + id + "',name = '" + Gname + "',grouptype= '" + grouptype + "',custtype = '" + custtype + "',ticketId = '" + ticketId + "' Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomerGroupDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.CustomerGroup Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetCustomerGroupDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.CustomerGroup order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

        public void AddCustumerDB(string firstname, string surname, int age, string mail, int phone, int customerGroupId, int AddressId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Customer (firstname,surname,age,mail,phone,customerGroupId,AddressId) VALUES ('" + firstname + "','" + surname + "','" + age + "','" + mail + "','" + phone + "','" + customerGroupId + "','" + AddressId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomerDB(int id, string firstname, string surname, int age, string mail, int phone, int customerGroupId, int AddressId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.Customer set id='" + id + "', firstname='" + firstname + "', surname='" + surname + "', age='" + age + "', mail='" + mail + "', phone='" + phone + "', customerGroupId='" + customerGroupId + "', AddressId='" + AddressId + "', Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomerAddressDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.Customer Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object GetCustomerDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.Customer order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
        public void AddCustumer_CustomergroupDB(int custId, string custName, string custMail, string groupName, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Customer_Customergroup (custId,custName,custMail,groupName,ticketId) VALUES ('" + custId + "','" + custName + "','" + custMail + "','" + groupName + "','" + ticketId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomer_CustomergroupDB(int id, int custId, string custName, string custMail, string groupName, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.Customer_Customergroup set id='" + id + "', custId='" + custId + "', custName='" + custName + "', custMail='" + custMail + "', groupName='" + groupName + "', Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomer_CustomergroupDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.Customer_Customergroup Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetCustomer_CustomergroupDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * dbo.Customer_Customergroup order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

        public void AddCustumerAddressDB(string street, int number, string city, int zip)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.CustumerAddress (street,number,city,zip) VALUES ('" + street + "','" + number + "','" + city + "','" + zip + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustumerAddressDB(int id, string street, int number, string city, int zip)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.CustumerAddress set id='" + id + "', street='" + street + "', number='" + number + "', city='" + city + "', zip='" + zip + "', Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustumerAddressDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.CustumerAddress Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object GetCustumerAddressDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * dbo.CustumerAddress order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

    }
}