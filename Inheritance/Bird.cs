using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {
            Legs = 2;
            eyes = 2;
            wings = true;
            hasFeathers = true;
        }

        public bool wings {  get; set; }
        public bool canFly { get; set; }
        public bool hasFeathers { get; set; }
        public string call { get; set; }


    }
}
