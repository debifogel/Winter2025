namespace Project__winter_2025.classes
{
    //להוסיף  enum ושמות ליעד ומוצא
    public class Bus
    {
        static int countBuses=0;
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Destination { get; set; }
        public string Source { get; set; }
        public LinkedList<Dictionary<DescribeBusWuthStation, Station>> Listofstation { get; set; }
        public string Company { get; set; }
        public TimeOfBus Timings { get; set; }

        public Bus()
        {
            Id = ++countBuses;
        }

       
    }
}
