using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private List<Models.Train> _trains = new List<Models.Train>(); 
        private List<Models.Trip> _trips= new List<Models.Trip>();

        private static DataStore _instance;
        public static DataStore Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataStore();
            return _instance; 
            } 
        } 
        private DataStore()
        {

        }
        public List<Models.Train> GetAllTrains()
        {
            return _trains;
        }
        public void AddTrain(Models.Train train)
        {
            _trains.Add(train);
        }
        public List<Models.Trip> GetAllTrips()
        {
            return _trips;
        }
        public void AddTrip(Models.Trip newTrip)
        {
            _trips.Add(newTrip);
        }
    }      
}
