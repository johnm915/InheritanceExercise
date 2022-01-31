using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool IsScaley { get; set; }
        public string Habtat { get; set; }
        public double Length { get; set; }
        public bool IsAlive { get; set; }

        public Reptile()
        {

        }

        public Reptile (string name, int age, bool isalive, int legs, bool iscoldblooded, bool isscaly, string habtat,double length)
        {
            Name = Name;
            Age = age;
            IsAlive = isalive;
            Legs = legs;
            IsColdBlooded = iscoldblooded;
            IsScaley = isscaly;
            Length = length;
            Habtat = habtat;
        }



    }
}
