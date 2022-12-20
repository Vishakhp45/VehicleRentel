using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentel.Helper;
using VehicleRentel.Model;

namespace VehicleRentel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car C = new Car();
            Bike B = new Bike();
            Helperclass help = new Helperclass();

            help.GetCarDetails(C);
            help.GetBikeDetails(B);

            help.DisplayCar(C);
            help.DisplayBike(B);
            help.WriteaFile(C,B);

            Process.Start("notepad.exe", @"C:\Users\user\source\repos\VehicleRentel\Notepad\" + C.Name + ".txt");

        }
    }
}
