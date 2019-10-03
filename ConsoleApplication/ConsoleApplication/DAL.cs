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
    public class Dal : ICostumer, ICostumer_Customergroup, ICustomerAddress, ICustomerGroup, IEvents, IEvents_ConcertHall, IEvents_Customergroup, IEventTickets_TicketSold, IConcertHall
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



        public void AddEvents_CustomergroupDB(string eventName,string groupName, int groupId, int ticketId)
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



        public void AddEventsDB(string eventName, DateTime eventDate, int grouptype, string custtype)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Events_ (eventName, eventDate, grouptype, custtype) VALUES ('" + eventName + "','" + eventDate + "','" + grouptype + "','" + custtype + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateEventsDB(int id, string eventName, DateTime eventDate, int grouptype, string custtype)
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


        public void AddCustomerGrouDB(string Gname, int grouptype, string custtype, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.CustomerGrou (name, grouptype, custtype, ticketId) VALUES ('" + Gname + "','" + grouptype + "'','" + custtype + "','" + ticketId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomerGrouDB(int id, string Gname, int grouptype, string custtype, int ticketId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.CustomerGrou set id='" + id + "',name = '" + Gname + "',grouptype= '" + grouptype + "',custtype = '" + custtype + "',ticketId = '" + ticketId + "' Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomerGrouDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.CustomerGrou Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetCustomerGrouDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from dbo.CustomerGrou order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

    }
}
