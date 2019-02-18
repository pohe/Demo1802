using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Car
    {
        private string _brand;
        private string _model;
        private double _engineSize;
        private string v1;
        private string v2;
        private double v3;

        public Car()
        {
            _brand = "Mercedes";
            _model = "E-Klasse";
            _engineSize = 2.0;

        }

        public Car(string brand, string model, double engineSize)
        {
            _brand = brand;
            _model = model;
            _engineSize = engineSize;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public double engineSize
        {
            get { return _engineSize; }
            set { _engineSize = value; }
        }


        public void FedMotor()
        {
            if (_engineSize > 1)
            {
                Console.WriteLine("Fed motor");
            }
        }
    }

}
