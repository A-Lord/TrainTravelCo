using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TrainTravelCo.Managers
{
    public class TripManager
    {

        Data.DataStore trainData = Data.DataStore.Instance;

        public List<Models.Trip> GetAllTrips()
        {
            return trainData.GetAllTrips();
        }
        public void AddTrip(Models.Trip newTrip)
        {
            trainData.AddTrip(newTrip);
        }
        public void CreateTrip(string start,string destination,string departureTime,int trainId)
        {
            try
            {
                var theTrain = trainData.GetAllTrains().Find(x => x.Id.Equals(trainId));
                var newTrip = new Models.Trip
                {
                    Start = start,
                    End = destination,
                    dateTime = departureTime,
                    theTripsTrain = theTrain
                    
                };
                trainData.AddTrip(newTrip);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
