using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes_Hafsa
{
    internal class House
    {
        //fields
        string _area;
        int _bedroom;
        int _bathroom;

        //properties
        public string Area
        {
            get => _area; set => _area = value; 
        }
        public int Bedroom
        {
            get => _bedroom; set => _bedroom = value;
        }
        public int Bathroom
        {
            get => _bathroom; set => _bathroom = value;
        }

    }//class


}//namespace
