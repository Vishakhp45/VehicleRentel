using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentel.Model;

namespace VehicleRentel.Helper
{
    internal class Helperclass
    {
        public Car GetCarDetails(Car C)
        {
            Console.WriteLine("Enter Car Name");
            C.Name = Console.ReadLine();

            Console.WriteLine("Enter Model");
            C.Model = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price");
            C.Price = Convert.ToInt32(Console.ReadLine());
            return C;
        }
        public void DisplayCar(Car C)
        {
            Console.WriteLine("\nName       :" + C.Name);

            Console.WriteLine("\nModel      :" + C.Model);

            Console.WriteLine("\nPrice      :" + C.Price);
        }
        public Bike GetBikeDetails(Bike B)
        {
            Console.WriteLine("Enter Bike Name");
            B.Name = Console.ReadLine();

            Console.WriteLine("Enter Model");
            B.Model = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price");
            B.Price = Convert.ToInt32(Console.ReadLine());

            return B;
        }
        public void DisplayBike(Bike B)
        {
            Console.WriteLine("\nName       :" + B.Name);

            Console.WriteLine("\nModel      :" + B.Model);

            Console.WriteLine("\nPrice      :" + B.Price);


        }

        /*public void WriteAFile(Car C);
        {
        string path = @"C:\Users\user\source\repos\VehicleRentel\Notepad\" + C.Name + ".txt";
        StreamWriter ob = new StreamWriter(path, true);

        ob.Write("\nName:  "+C.Name+ + "\nModel:   "+C.Model+"\nPrice   :"+C.Price);
        ob.Cloce();
        }*/
        public void WriteaFile(Car C,Bike B)
        {
            String filepath = @"C:\Users\user\source\repos\VehicleRentel\Notepad\" + C.Name + ".txt";
            StreamWriter ob = new StreamWriter(filepath, true);
            ob.Write ("\nName:  " + C.Name + "\nModel:   " + C.Model + "\nPrice   :" + C.Price);
            ob.Write("\nName:  " + B.Name + "\nModel:   " + B.Model + "\nPrice   :" + B.Price);
            ob.Close();
        }

    }
}
