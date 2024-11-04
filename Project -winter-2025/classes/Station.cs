namespace Project__winter_2025.classes
{
    public class Station
    {//איך אפשר קוד על פי אזור
        static int Count = 1;
        public int Id { get;  }
        public string StationName { get; set; }
        public string City { get; set; }
        public List<Bus> BusInStation { get; set; }

        
        public Station(string stationName,string city)
        {
            Id = Count++;
            BusInStation = new List<Bus>();
            StationName = stationName;
            City=city;
        }
    }
}
