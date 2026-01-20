using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Interfaces
{
    internal interface IOfficeManager
    {
        public void CreateOffice();

        public void GetOffice();

        public void UpdateOffice();

        public void DeleteOffice();
    }
}
