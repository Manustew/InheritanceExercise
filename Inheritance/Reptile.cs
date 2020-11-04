using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal  
    {
        public bool IsAmphibious { get; set; }

        public bool HasLegs { get; set; }

        public string Environment { get; set; }

        public string Defense { get; set; }
    }
}
