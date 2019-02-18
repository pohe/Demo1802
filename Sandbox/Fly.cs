using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Fly
    {
        private string _name;
        private int _number;
        private String _destination;
        private int _passengers;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }

        public object Number { get;  set; }

        public Fly(string name, string destination, int number, int passengers)
        {
            _name = name;
            _number = number;
            _destination = destination;
            _passengers = passengers;
        }


        public void IsPlaneFull()
        {
            if (_passengers > 20)
            {
                Console.WriteLine("flyet er fyldt");
            }
        }

    }
}
