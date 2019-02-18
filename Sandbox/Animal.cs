using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Animal
    {
        private string _name;
        private int _age;
        private bool _alive;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public Animal()
        {
            _name = "lion";
            _age = 2;
            _alive = true;

        }

        public void Old()
        {
            bool veryOld = _age > 20;
            Console.WriteLine($"Animal er gammel {veryOld}");
        }


    }
}
