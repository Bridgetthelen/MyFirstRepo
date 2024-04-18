using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Hexagon : Polygon
    {
        //Attribute
        //Size of the hexagon (6 sides all same length)
        public float Size { get; set; }

        //Constructor
        public Hexagon(float size)
        {
            Size = size; //sets value of the attribute to the value of the argument into the constructor
            NumberOfSides = 6; //sets the value of the attribute, inherited from parent (polygon)
        } // end constructor
    }// end class
}// end namespace
