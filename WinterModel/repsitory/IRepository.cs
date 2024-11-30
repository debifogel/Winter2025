using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses.Core.repsitory
{
    public interface IRepository<T>
    {
        public void Add(T item);
        public void Update(T item);
        public void Delete(T item);
        public List<T> GetAll();
        public T Get(int id);

    }
}
