using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Car : Vehicle
    {
        private int _fuelCapasity;
        public int FuelCapasity
        {
            get 
            { 
                return 
                    _fuelCapasity; 
            }
            set
            {
                if(value > 0)
                _fuelCapasity = value;
            }
        }
        private double _currentFuel;
        public double CurrentFuel
        {
            get 
            {
                return _currentFuel; 
            }
            set
            {
                if(value > 0)
                _currentFuel = value;
            }
        }
        private int _fuelConsumption;
        public int FuelConsumption //Kodu yazanan sonra 1km e gore verildiyini gordum :D ama mentiq eynidi
        {
            get
            {
                return _fuelConsumption;
            }
            set
            {
                if( value > 0)
                _fuelConsumption = value;
            }
        }
        public override void Drive(double km)
        {
            double UsedFuel = (km * FuelConsumption)/100;
            if (CurrentFuel>UsedFuel)
            {
                Millage += km;
                CurrentFuel -= UsedFuel;
                Console.WriteLine($"Yurus: {this.Millage}km || Yanacaq miqdari: {this.CurrentFuel}L");
            }
            else
            {
                Console.WriteLine($"Istenilen mesafeni getmek ucun en az {UsedFuel}L yanacaq lazmdir");
            }
           
        }
    }
}
