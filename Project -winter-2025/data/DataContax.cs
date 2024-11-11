using Project__winter_2025;
using Project__winter_2025.data;
using WinterModel.classes;
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