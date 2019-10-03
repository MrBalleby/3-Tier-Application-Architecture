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

        public void AddCostumerDB(string firstname, string surname, string age, string mail, string phone, int customerGroupId, int AddressId)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.Customer (firstname,surname,age,mail,phone,customerGroupId,AddressId) VALUES ('" + firstname + "','" + surname + "','" + age + "','" + mail + "','" + phone + "','" + customerGroupId + "','" + AddressId + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomerDB(int id, string firstname, string surname, string age, string mail, string phone, int customerGroupId, int AddressId)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.Customer set id='" + id + "', firstname='" + firstname + "', surname='" + surname + "', age='" + age + "', mail='" + mail + "', phone='" + phone + "', customerGroupId='" + customerGroupId +"', AddressId='" + AddressId + "', Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomerDB(int id)
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
        public void AddCostumer_CustomergroupDB(int custId, string custName, string custMail, string groupName, int ticketId)
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

        public void AddCostumerAddressDB(string street, string number, string city, int zip)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into dbo.CostumerAddress (street,number,city,zip) VALUES ('" + street + "','" + number + "','" + city + "','" + zip + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCostumerAddressDB(int id, string street, string number, string city, int zip)
        {
            DataSet ds = new DataSet();
            string sql = "Update dbo.CostumerAddress set id='" + id + "', street='" + street + "', number='" + number + "', city='" + city + "', zip='" + zip + "', Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCostumerAddressDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.CostumerAddress Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object GetCostumerAddressDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * dbo.CostumerAddress order by id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

    }
}
