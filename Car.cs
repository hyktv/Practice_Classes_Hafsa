using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes_Hafsa
{
    internal class Car
    {
        //fields
        string _make;
        string _model;
        int _year;
        int _mileage;
        string _color;

        //properties
        public string Make
        {
            get => _make; set => _make = value; 
        }

        public string Model
        {
            get => _model; set => _model = value;
        }

        public string Color
        {
            get => _color; set => _color = value;
        }

        public int Year
        {
            get => _year; set => _year = value;
        }

        public int Mileage
        {
            get => _mileage; set => _mileage = value;
        }





    }//class


}//namespace
