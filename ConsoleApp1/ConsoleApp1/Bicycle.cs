using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }

        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
    }
}
