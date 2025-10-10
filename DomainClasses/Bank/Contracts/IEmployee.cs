using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Bank.Contracts
{
    public interface IEmployee
    {
        public string Name { get; set; }

        internal static string GetNameTitle()
        {
            return "Mr./Ms.";
        }

        //default interface methods
        //private
        //abstract
        public string GetNameInUpperCase() // can only be called from a interface object
        {
            return Name.ToUpper();
        }

    }

    public class Manager : IEmployee
    {
        public string Name { get; set; }

    }
    public class Clerk : IEmployee
    {
        public string Name { get; set; }

    }
}
