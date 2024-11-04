namespace Project__winter_2025.classes
{
    //להוסיף  enum ושמות ליעד ומוצא
    public class Bus
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string d { get; set; }
        public string c { get; set; }
        public LinkedList<Dictionary<DescribeBusWuthStation, Station>> Listofstation { get; set; }
        public string Company { get; set; }
        public TimeOfBus Timings { get; set; }

        

    }
}
