using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.OfficeBuildings.Classes
{
    internal class SmallOrMediumCompany : ACompany
    {
        public int MinimumAreaRequired { get; set; }
    }
}
