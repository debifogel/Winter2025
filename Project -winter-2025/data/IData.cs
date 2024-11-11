using static System.Collections.Specialized.BitVector32;
using System.IO;
using Project__winter_2025;
using WinterModel.classes;
namespace Project__winter_2025.data
{
    public interface IData
    {
        public List<Bus> buses { get; set; }

        public List<Street> streets { get; set; }

        public List<Station> stations { get; set; }
    }
}
