using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Human
    {
        private string _name;//instance felt
        private int _height;
        private int _weight;

        public string Name //property
        {
            get { return _name;  }
            set
            {
                _name = value;
            }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value;  }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int BMI
        {
            get { return (_weight) / (_height * _height); }
        }


        public Human() //constructor
        {
            _name = "No name";
            _weight = 1;
            _height = 1;
        }


        public Human(string name, int height, int weight)//constructor
        {
            _name = name;
            _height = height;
            _weight = weight;
        }

    }
}
