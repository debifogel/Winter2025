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
    public class StreetService: IStreetService
    {
        private readonly IRepository<Street> _streetRepository;
        public StreetService(IRepository<Street>_repository)
        {
            this._streetRepository=_repository;
        }

        public bool Delete(int id)
        {
          bool result= _streetRepository.Delete(id);
            return result;
        }

        public List<Street> GetAll(string? name, string? city)
        {
            return (List<Street>)_streetRepository.GetAll(name,city,null,null);
        }

        public Street GetById(int id)
        {
           return _streetRepository.Get(id);
        }

        public void Post(NameAndCity busfrombody)
        {
            _streetRepository.Add(new Street(busfrombody.Name, busfrombody.City));
        }

        public bool UpDate(int id, Street street)
        {

            bool result = _streetRepository.UpDate(id, street);
            return result;
        }
        public bool AddStation(Station station,int id)
        {
            Street street = _streetRepository.Get(id);
            if (street != null)
            {
                street.ListOfStation.Add(station);
                return true;
            }
            return false;
        }

    }
}
