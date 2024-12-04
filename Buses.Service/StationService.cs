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
    public class StationService : IStationService
    {
        private readonly IRepository<Station> _stationRepository;
        public StationService(IRepository<Station>repository)
        {
            _stationRepository = repository;
        }
        
        public bool DeleteActive(int id)
        {
            Station s= _stationRepository.Get(id);
            if (s != null)
            {
                s.IsActive = false;
                return true;
            }
            return false;

        }
        public bool Delete(int id)
        {
            bool result = _stationRepository.Delete(id);
            return result;
        }
        public List<Station> GetAll()
        {
          return  _stationRepository.GetAll(null,null,null,null);
        }

        public Station GetById(int id)
        {
           return _stationRepository.Get(id);
        }

        public void Post(NameAndCity busfrombody)
        {
            _stationRepository.Add(new Station(busfrombody.Name, busfrombody.City));
        }

        public bool UpDate(int id, Station bus)
        {
            bool result = _stationRepository.UpDate(id, bus);
            return result;
        }
        

    }
}
