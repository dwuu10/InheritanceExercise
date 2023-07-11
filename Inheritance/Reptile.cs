using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            eyes = 2;
            scales = true;
            coldBlooded = true;
        }
        public bool scales { get; set; }
        public bool longTongue { get; set; }
        public bool coldBlooded { get; set; }
        public string basking { get; set; }


    }
}
