using DomainClasses.OfficeBuildings.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Interfaces
{
    internal interface IFloorManager : ICRUDManager<Floor>
    {
        public List<Office> Offices { get; set; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public Building Get()
        {
            throw new NotImplementedException();
        }

        public Building Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void InstallCompanyInOffice(ACompany company, Office office)
        {
            throw new NotImplementedException();
        }
    }
}
