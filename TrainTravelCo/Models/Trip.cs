
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TrainTravelCo.Models
{
    public class Trip
    {
        public string Start {  get; set; }
        public string End {  get; set; }   
        public string dateTime {  get; set; }

        public Train theTripsTrain { get; set; }

        public List<Booking> BookingHistory {  get; set; } 

        public int TripId { get; }

        public Trip()
        {
            TripId = TripID.GetId();
        }

    }
}
