using DomainClasses.OfficeBuildings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Classes
{
    internal class ReservationManager : IReservationManager
    {
        public List<Reservation> Reservations { get; set; }

        public ReservationManager()
        {
            Reservations = new List<Reservation>();
        }
        public void Create()
        {
            
        }
        public Reservation Get()
        {
            throw new NotImplementedException();
        }

        public Reservation Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        
    }
}
