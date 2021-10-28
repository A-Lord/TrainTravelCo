using System;


namespace TrainTravelCo.Models
{
    public class Train
    {
        private int _regNr;

        public int RegNr { get; init; }
        public Guid Id {  get; init; }

        public int Seats {  get; set; }


        public Train()
        {
            RegNr = 0;
            Id = Guid.NewGuid();
            
        }



    }
}
