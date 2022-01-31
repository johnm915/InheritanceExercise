using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public double BeakSize { get; set; }

        public Bird()
        {

        } 
        

        public Bird(string name, int age, bool isalive, int legs,int wings, bool canfly, bool hasfeathers, double beaksize)
        {
            Name = Name;
            Age = age;
            IsAlive = isalive;
            Legs = legs;
            Wings = wings;
            CanFly = canfly;
            HasFeathers = hasfeathers;
            BeakSize = beaksize;
        }

    }
}
