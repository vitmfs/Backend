using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Classes
{
    public abstract class ACompany
    {
        public string   Name { get; set; }
        public string   VAT { get; set; }
        public string   NameOfPersonInCharge { get; set; }
        public Color    CompanyColor { get; set; }
    }

    public enum Color
    {
        Orange,
        Blue
    }
}
