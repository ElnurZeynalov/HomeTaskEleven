using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisteme nece eded neqliyyat vasitesi daxil edeceksiniz ?");
            int VehicleQuantity = IntChecker("Sayi daxil edin: ");
            Car[] cars = new Car[VehicleQuantity];
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"\n=============={i + 1} Neqliyyat vasitesi==============\n");
                Console.Write("Neqliyyat vasitesinin rengini daxil edin: ");
                string color = Console.ReadLine();
                Console.Write("Neqliyyat vasitesinin markasini daxil edin: ");
                string brand = Console.ReadLine();
                double millage = DoubleChecker("Neqliyyat vasitesinin yurusunu daxil edin: ");
                int fuelCapasity = IntChecker("Max yanacaq miqdarini daxil edin: ");
                //int fuelConsumption = IntChecker("100km neqeder yanacaq istifade etdiyini daxil edin: ");
                //double currentFuel = DoubleChecker("Hal hazirdaki yanacaq miqdarini daxil edin: ");

                Car car = new Car()
                {
                    Color = color,
                    Brand = brand,
                    Millage = millage,
                    FuelCapasity = fuelCapasity,
                    //FuelConsumption = fuelConsumption,
                    //CurrentFuel = currentFuel,

                };
                cars[i] = car;
            }
            Console.WriteLine("\n=======Menu=======\n");
            Console.WriteLine("1. Masinlari yurusune gore filtirle\n2. Butun masinlari goster\n3. Prosesi bitir");
            int choise = IntChecker("Etmek istediyiniz emeliyyata uygun reqemi daxil edin: ");
            switch (choise)
            {
                case 1:
                    double min = DoubleChecker("Min yurusu girin: ");
                    double max = DoubleChecker("Max yurusu girin: ");
                    Console.WriteLine("\n============Filtered Cars============\n");
                    foreach (var item in MillageFilter(min, max, cars))
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                    break;
                case 2:
                    Console.WriteLine("\n============Cars============\n");
                    foreach (var item in cars)
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                    break;
                case 3:
                    Console.WriteLine("The End");
                    break;
                default:
                    Console.WriteLine("1-3 arasi reqem daxil edin");
                    break;
            }
            #region Drive Test
            Console.WriteLine("\n=======Test=======\n");
            double km = DoubleChecker("Gedilecek mesafeni daxil edin ");
            Car car1 = new Car();
            car1.Millage = DoubleChecker("Neqliyyat vasitesinin indiye qeder olan yurus mesafesini daxil edin: ");
            car1.CurrentFuel = DoubleChecker("Neqliyyat vasitesinin hal hazidaki yanacaq miqdarini daxil edin: ");
            car1.FuelConsumption = IntChecker("Neqliyyat vasitesinin 100km ne qeder benzin istifade etdiyini daxil edin: ");
            car1.Drive(km);
            #endregion
        }
        static int IntChecker(string text)
        {
            int Value;
            string StrValue;
            do
            {
                Console.Write(text);
                StrValue = Console.ReadLine();
                if (!int.TryParse(StrValue, out Value))
                    Console.WriteLine("Yalnizca reqem daxil edin !");
            } while (!int.TryParse(StrValue, out Value));
            Value = Convert.ToInt32(StrValue);
            return Value;
        }
        static double DoubleChecker(string text)
        {
            double Value;
            string StrValue;
            do
            {
                Console.Write(text);
                StrValue = Console.ReadLine();
                if (!double.TryParse(StrValue, out Value))
                    Console.WriteLine("Yalnizca reqem daxil edin !");
            } while (!double.TryParse(StrValue, out Value));
            Value = Convert.ToDouble(StrValue);
            return Value;
        }
        static Car[] MillageFilter(double min, double max, Car[] cars)
        {
            int count = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Millage > min && cars[i].Millage < max)
                {
                    count++;
                }
            }
            Car[] result = new Car[count];
            int NewArraycount = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Millage > min && cars[i].Millage < max)
                {
                    result[NewArraycount] = cars[i];
                    NewArraycount++;
                }
            }
            return result;

        }
    }
}
