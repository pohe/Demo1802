using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Boat
    {
        private string _name;
        private int _hk;
        private int _feet;
        private string _location;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public int Hk
        {
            get { return _hk; }
            set
            {
                _hk = value;
            }
        }

        public int Feet
        {
            get { return _feet; }
            set
            {
                _feet = value;
            }
        }

        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
            }
        }

        public Boat(string name, int hk, int feet, string location)
        {
            _name = name;
            _hk = hk;
            _feet = feet;
            _location = location;
        }

        public Boat()
        {
            
        }

        public void TestAverage(int average)
        {
            if (_hk >= average)
            {
                Console.WriteLine("Din motor er kraftigere end gennemsnittet");
            }
            else
            {
                Console.WriteLine("Du har en svag motor");
            }
        }


    }
}
