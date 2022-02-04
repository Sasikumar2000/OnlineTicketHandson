using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineTIcketHandsOn.DatabaseConnection;

namespace OnlineTIcketHandsOn
{
    public partial class OnlineTicketUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        { 
            DbConnect obj = new DbConnect();
            OnlineTicketProperty Modelobj = new OnlineTicketProperty();
            Modelobj.BookingId = Convert.ToInt32( txtBookingId.Text);
            Modelobj.Source = txtSource.Text;
            Modelobj.Destination = txtDestination.Text;
            Modelobj.Date = txtDate.Text;
            Modelobj.Time = txtTime.Text;
            Modelobj.NumberOfPerson = txtNumberofperson.Text;
            Modelobj.SeatNumber = txtSeatnumber.Text;


            string msg = obj.InsertTicket(Modelobj);
          
            Response.Write($"<script>alert('{msg}')</script>");

            LoadData();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DbConnect obj = new DbConnect();
            OnlineTicketProperty Modelobj = new OnlineTicketProperty();
            Modelobj.BookingId = Convert.ToInt32(txtBookingId.Text);
            Modelobj.Source = txtSource.Text; 
            Modelobj.Destination = txtDestination.Text;
            Modelobj.Date = txtDate.Text;
            Modelobj.Time = txtTime.Text;
            Modelobj.NumberOfPerson = txtNumberofperson.Text;
            Modelobj.SeatNumber = txtSeatnumber.Text;
            string msg = obj.UpdateTicket(Modelobj);
            
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }
        protected void LoadData()
        {
            DbConnect obj = new DbConnect();
            DataTable dtResult = obj.SelectTicket();
            GVDisplay.DataSource = dtResult;
            GVDisplay.DataBind();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            DbConnect obj = new DbConnect();
            string msg = obj.DeleteTicket(Convert.ToInt32(txtBookingId.Text));
            
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtBookingId.Text = "";
            txtDate.Text = "";
            txtDestination.Text = "";
            txtNumberofperson.Text = "";
            txtSeatnumber.Text = "";
            txtSource.Text = "";
            txtTime.Text = "";
            
        }
    }
}