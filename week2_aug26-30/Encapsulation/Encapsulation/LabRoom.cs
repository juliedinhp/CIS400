using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class LabRoom
    {
        public int Computers = 20;

        public bool Windows = true;

        // drinks policy across all lab rooms
        public static bool DrinksAllowed{get;set;}=true;
    }
}
