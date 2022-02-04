using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTIcketHandsOn.DatabaseConnection
{
    public class OnlineTicketProperty
    {
        public int BookingId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string NumberOfPerson { get; set; }
        public string SeatNumber { get; set; }

    }
}