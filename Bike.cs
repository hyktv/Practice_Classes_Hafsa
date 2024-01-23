using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes_Hafsa
{
    internal class Bike
    {
        //fields
        string _brand;
        string _type;
        string _color;
        int _numOfWheels;

        //properties
        public string Brand
        {
            get => _brand; set => _brand = value; 
        }

        public string Type
        {
            get => _type; set => _type = value;
        }

        public string Color
        {
            get => _color; set => _color = value;
        }

        public int NumOfWheels
        {
            get => _numOfWheels; set => _numOfWheels = value;
        }


    }//class


}//namespace
