using DomainClasses.OfficeBuildings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Classes
{
    public class BuildingManager : IBuildingManager
    {
        public List<Floor> Floors { get; set; }

        public BuildingManager()
        {
            Floors = new List<Floor>();
        }

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

        public List<Building> GetAll()
        {
            return new List<Building>
            {
                new Building()
                {
                    Id = Guid.NewGuid(),
                    Name = "Building A",
                    Offices = new List<Office>(),
                    Reservations = new List<Reservation>(),
                    SpatialDisposition = new SpatialDisposition()
                },
                new Building()
                {
                    Id = Guid.NewGuid(),
                    Name = "Building B",
                    Offices = new List<Office>(),
                    Reservations = new List<Reservation>(),
                    SpatialDisposition = new SpatialDisposition()
                }

            };
        }



        public int RateOfOccupancy()
        {
            return 0;
        }

        public int RateOfReservations()
        {
            return 0;
        }

        public bool OwnerAlreadyHasCompany(Guid ownerId)
        {
            return false;
        }
    }
}
