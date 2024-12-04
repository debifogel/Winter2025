using Buses.Core.classes;
using Buses.Core.repsitory;
using Buses.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses.Service
{
    public class BusService : IBusService
    {
        private readonly IRepository<Bus> _busRepository;
       
        public BusService(IRepository<Bus> repository)
        {
            _busRepository = repository;
        }

        public bool DeleteActive(int id)
        {
            Bus b = _busRepository.Get(id);
            if (b != null)
            {
                b.IsActive = false;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            bool result = _busRepository.Delete(id);
            return result;
        }
        public List<Bus> GetAll(string? name, CompanyName? company, string? destination, string? source)
        {
           return (List<Bus>)_busRepository.GetAll(name,destination,source,company);
        }

        public Bus GetById(int id)
        {
           return _busRepository.Get(id);
                                        
        }

        public void Post(Busfrombody busfrombody)
        {
            Bus b = new Bus();

            b.BusName = busfrombody.BusName;
            b.Source = busfrombody.source;
            b.Destination = busfrombody.destination;
            b.Company = busfrombody.Company;
            b.IsActive = true;
            _busRepository.Add(b);

        }

        public bool UpDate(int id, Bus bus)
        {
            bool result = _busRepository.UpDate(id, bus);
            return result;
        }
        public bool AddStation(StationAndi station, int id)
        {
          Bus b=  _busRepository.Get(id);
            if(b!=null)
            {
                b.Listofstation.Add(station);
                station.BusStop.BusInStation.Add(b);
                return true;
            }
            return false;
        }
    }
}
