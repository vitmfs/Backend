using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Universe
{
    public class Universe
    {
        private static Universe _instance;

        private static readonly object _lock = new object();

        private Universe()
        {
            
        }

        public static Universe Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {

                        _instance = new Universe();

                    }
                }
                return _instance;
            }
        }
    }
}
