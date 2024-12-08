﻿using Buses.Core.classes;
using Buses.Core.repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses.Core.Services
{
    public interface IStreetService
    {
        List<Street> GetAll(string? name,string? city);
        Street GetById(int id);

        public bool Delete(int id);
        public void Post(NameAndCity busfrombody);
        public bool UpDate(int id, Street street);
        public bool AddStation(Station station,int id);
    }
}
