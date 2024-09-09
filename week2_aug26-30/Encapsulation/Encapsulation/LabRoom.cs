using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class LabRoom
    {
        //only allow 10-30 computers
        private uint _computers = 20;
        public uint Computers
        {
            get => _computers;
            set
            {
                if (value >= 10 && value <= 30)
                {
                    _computers = value;
                }
            }
        }

        public bool Windows { get; } = true;

        public static bool DrinksAllowed { get; set; }

        public LabRoom(bool isWindows)
        {
            Windows = isWindows;
        }

<<<<<<< HEAD
        //static constructor (any class can have one)
        static LabRoom(){
            //initialize any static fields/properties
            DrinksAllowed = true;
=======
        static LabRoom()
        {
            //initialize all static properties/fields

            DrinksAllowed = false;
            
            //NO! can only access static members
            //Windows = false;
>>>>>>> refs/remotes/origin/main
        }
    }
}
