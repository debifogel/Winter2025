using static System.Collections.Specialized.BitVector32;
using System.IO;
using Buses.Core.classes;
namespace Buses.Data.data
{
    public interface IData
    {
        public List<Bus> buses { get; set; }

        public List<Street> streets { get; set; }

        public List<Station> stations { get; set; }
    }
}
