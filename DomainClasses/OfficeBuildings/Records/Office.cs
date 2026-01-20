using DomainClasses.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Records
{
    public record Office(string officeCode, bool occupied) : BaseModel;


    public record Company(string nif, string owner, string name, string color);

    

    public record Reservation(string personResponsible);

    public record Building(Office[] offices, Reservation[] reservations, string officeSize);

    public record Occupation(DateTime startDate, DateTime endDate);





}
