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
            _trains.Add(new Models.Train());
            _trains.Add(new Models.Train());
            _trains.Add(new Models.Train());
            _trips.Add(new Models.Trip { Start = "Örebro", End = "Stockholm", dateTime = "19.00", theTripsTrain = _trains[1]});
            _trips.Add(new Models.Trip { Start = "Malmö", End = "Stockholm", dateTime = "12.00", theTripsTrain = _trains[2] });
            _trips.Add(new Models.Trip { Start = "Saturnus", End = "Prag", dateTime = "04.00", theTripsTrain = _trains[1] });
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
