using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_03
{
    internal class Child : Parent
    {
        public int Z {  get; set; }

        public Child (int x, int y,int z) : base (x,y)
        {
            this.Z = z;
        }

        public override string ToString()
        {
            return $"{X} , {Y} , {Z}";
        }

        public new int Product()
        {
            return base.Product() *Z;
        }
    }
}
