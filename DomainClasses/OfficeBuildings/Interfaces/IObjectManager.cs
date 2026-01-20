using DomainClasses.OfficeBuildings.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Interfaces
{
    public interface ICRUDManager<T> where T : class
    {
        public void Create();
        public T Get();
        public T Update();
        public void Delete();

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
