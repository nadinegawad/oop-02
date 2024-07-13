﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_03
{
    internal class Car
    {


        public int Id { get; set; }
        public string? Model { get; set; }
        public double Speed { get; set; }
        public override string ToString()
        {
            return $"Id : {Id}\nModel : {Model}\nspeed : {Speed}";
        }
        //constructor
        public Car()
        {

        }
        public Car(int id, string? model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        public Car(int id, string? model) : this(id, model, 190)
        {
        }
        public Car(int id) : this(id, "BNW", 200)
        {
        }

    }
}
