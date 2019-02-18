using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Warrior
    {
//Instansfelter
        private string _name;
        private int _life = 100;
        private int _height;
        private int _strength;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Life
        {
            get
            {
                return _life;
            }
            //set { _life = value;  }
            /*Life = _life;*/ //nem, men dårlig kode
        }
        //osv med de andre værdier - height, strength

        //constructor
        public Warrior(string name, int life, int height, int strength)
        {
            name = _name;
            life = _life;
            height = _height;
            _strength = strength;
        }

        public void IsSuperWarrior()
        {
            bool issuper = _strength > 100;
            if (issuper)
            {
                Console.WriteLine($"Du er en super kriger {_name}");
                _name = "Super " + _name;
            }
        }
    }

}
