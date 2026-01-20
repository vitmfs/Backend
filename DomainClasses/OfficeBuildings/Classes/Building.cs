using DomainClasses.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Classes
{
    public class Building : BaseClass
    {
        public string               Name { get; set; } 
        public List<Office>         Offices { get; set; }
        public List<Reservation>    Reservations { get; set; }
        public SpatialDisposition   SpatialDisposition { get; set; }

        public Building()
        {
            Offices = new List<Office>();
            Reservations = new List<Reservation>();
        }
    }
}
