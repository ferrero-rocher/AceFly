//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AceFly.Models
{
    using System;
    
    public partial class PRC_SearchFlights_Result
    {
        public string Schedule_Id { get; set; }
        public string Plane_Name { get; set; }
        public Nullable<System.DateTime> Travel_Date { get; set; }
        public string Day { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public Nullable<System.TimeSpan> Arrival_Time { get; set; }
        public Nullable<System.TimeSpan> Departure_Time { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<double> Price_B { get; set; }
        public Nullable<double> Price_E { get; set; }
        public Nullable<int> RemainingSeats { get; set; }
    }
}
