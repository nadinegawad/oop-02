using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_03
{
    internal class Parent
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} , {Y}";
        }

        //methods

        public int Product()
        {
            return X * Y; 
        }
    }
}
