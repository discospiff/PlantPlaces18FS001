using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlantPlaces18FS001
{
    public class Vehicle
    {
        private string asset;
        private string distance_traveled;
        private string heading;
        private string latitude;
        private string loadts;
        private string longitude;
        private double odometer;
        private string reasons;
        private string speed;
        private string status;
        private string time;

        public string Asset { get => asset; set => asset = value; }
        public string Distance_traveled { get => distance_traveled; set => distance_traveled = value; }
        public string Heading { get => heading; set => heading = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public string Loadts { get => loadts; set => loadts = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public double Odometer { get => odometer; set => odometer = value; }
        public string Reasons { get => reasons; set => reasons = value; }
        public string Speed { get => speed; set => speed = value; }
        public string Status { get => status; set => status = value; }
        public string Time { get => time; set => time = value; }
    }
}