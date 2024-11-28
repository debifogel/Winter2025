
using Buses.Core.classes;
using Buses.Data.data;

public class DataContext:IData
{
    public List<Bus> buses  { get; set; }

    public List<Street> streets { get; set; }

    public List<Station> stations { get; set; }
    public DataContext() {
        buses = new List<Bus>();
        streets = new List<Street>();
        stations = new List<Station>();
    }

}