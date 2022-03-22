using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        
        public string Color;
        public string Brand;
        private double _millage;
        public double Millage 
        { 
            get 
            {
                return _millage; 
            } 
            set
            {
                if(value > 0)
                _millage = value;
            }
        }
        public string ShowInfo()
        {
            return $"Reng: {this.Color} Marka: {this.Brand} Yurus: {this._millage}km";
        }
        public abstract void Drive(double km);
    }
}
