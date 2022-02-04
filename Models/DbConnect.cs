using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace OnlineTIcketHandsOn.DatabaseConnection
{
    public class DbConnect
    {
        string sqlConnectionstr = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";
        public string InsertTicket(OnlineTicketProperty onlineticket)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCommandOj = new SqlCommand("insert into SkOnlineTicket values(" + "'" + onlineticket.BookingId + "','" + onlineticket.Source + "','" + onlineticket.Destination + "','" + onlineticket.Date + "','" + onlineticket.Time + "','" + onlineticket.NumberOfPerson + "','" + onlineticket.SeatNumber + "')", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandOj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Ticketdetails saved successfully";
        }
        public DataTable SelectTicket()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCommandOj = new SqlCommand("select * from SkOnlineTicket", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandOj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public string UpdateTicket(OnlineTicketProperty onlineticket)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCommandOj = new SqlCommand("update SkOnlineTicket set SOURCE= '" + onlineticket.Source + "',DESTINATION='" + onlineticket.Destination + "',DATE='" + onlineticket.Date + "',TIME='" + onlineticket.Time + "',NUMBEROFPERSON='" + onlineticket.NumberOfPerson + "',SEATNUMBER='" + onlineticket.SeatNumber + "'where BOOKINGID= '" + onlineticket.BookingId + "'", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandOj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Ticket details updated successfully";

        }
        public string DeleteTicket(int BookingId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCommandOj = new SqlCommand("delete from  SkOnlineTicket where BOOKINGID='" + BookingId + "'", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandOj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Ticket details deleted successfully";
        }
        public DataTable EditTicketById(int BookingId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCommandOj = new SqlCommand("select * from  SkOnlineTicket where BOOKINGID='" + BookingId + "'", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandOj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }
}