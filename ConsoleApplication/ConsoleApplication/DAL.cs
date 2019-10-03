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


        public void AddCustomerDB(string custname, string custaddr, string custcountry, string custcity, string custincode)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Customer (customer_name,customer_address,customer_country,customer_city,customer_pincode) VALUES ('" + custname + "','" + custaddr + "','" + custcountry + "','" + custcity + "','" + custincode + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomerDB(int custid, string custname, string custaddr, string custcountry, string custcity, string custincode)
        {
            DataSet ds = new DataSet();
            string sql = "Update Customer set customer_name='" + custname + "',customer_address = '" + custaddr + "',customer_country= '" + custcountry + "',customer_city = '" + custcity + "',customer_pincode = '" + custincode + "' Where customer_id = '" + custid + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomerDB(int custid)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From Customer Where customer_id = '" + custid + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        public object GetCustomerDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * from Customer order by customer_id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }


        public void DeleteCostumerAddressDB(int id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From dbo.CostumerAddress Where id = '" + id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


    }
}