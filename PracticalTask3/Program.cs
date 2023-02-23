using System;

namespace PracticalTask3
{

    class CarPark
    {
        static void Main(string[] args)
        {
            PassengerCar Engine = new PassengerCar();
            Engine.power = "100";
            Engine.volume = "1.5";
            Engine.type = "manual";
            Engine.serialNumber = "1a2b3c";

            PassengerCar Chassis = new PassengerCar();
            Chassis.wheelNumber = "RN25/25";
            Chassis.number = "55ac142";
            Chassis.permissionLoad = 1450;

            PassengerCar Transmision = new PassengerCar();
            Transmision.types = "12CCSA11";
            Transmision.numbergear = "5";
            Transmision.manufacturer = "ACT CPM";

            Console.WriteLine("++++++++++++++++ PASSENGER ++++++++++++++++");
            Console.WriteLine("Passenger Car Engine Power :" + Engine.power);
            Console.WriteLine("Passenger Car Engine Volume :" + Engine.volume);
            Console.WriteLine("Passenger Car Engine Type :" + Engine.type);
            Console.WriteLine("Passenger Car Engine Serial Number :" + Engine.serialNumber);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Passenger Car Chassis Wheel Number : " + Chassis.wheelNumber);
            Console.WriteLine("Passenger Car Chassis Number : " + Chassis.number);
            Console.WriteLine("Passenger Car Chassis Permission Load : " + Chassis.permissionLoad);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Passenger Car Transmission Type :" + Transmision.types);
            Console.WriteLine("Passenger Car Transmission Number of Gear :" + Transmision.numbergear);
            Console.WriteLine("Passenger Car Transmission Manufacturer :" + Transmision.manufacturer);


            new Truck();
            Engine.power = "1000";
            Engine.volume = "4.5";
            Engine.type = "manual";
            Engine.serialNumber = "asdfas5df555";

            new Truck();
            Chassis.wheelNumber = "RSR/52255";
            Chassis.number = "43acr379";
            Chassis.permissionLoad = 15200;

            new Truck();
            Transmision.types = "885aWEfds";
            Transmision.numbergear = "6";
            Transmision.manufacturer = "RRADCCCC";

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++ T R U C K ++++++++++++++++");
            Console.WriteLine("Truck Engine Power :" + Engine.power);
            Console.WriteLine("Truck Engine Volume :" + Engine.volume);
            Console.WriteLine("Truck Engine Type :" + Engine.type);
            Console.WriteLine("Truck Engine Serial Number :" + Engine.serialNumber);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Truck Chassis Wheel Number : " + Chassis.wheelNumber);
            Console.WriteLine("Truck Chassis Number : " + Chassis.number);
            Console.WriteLine("Truck Chassis Permission Load : " + Chassis.permissionLoad);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Truck Transmission Type :" + Transmision.types);
            Console.WriteLine("Truck Transmission Number of Gear :" + Transmision.numbergear);
            Console.WriteLine("Truck Transmission Manufacturer :" + Transmision.manufacturer);



            _ = new AutoBus();
            Engine.power = "1500";
            Engine.volume = "8";
            Engine.type = "manual";
            Engine.serialNumber = "tgdfg747411";

            new AutoBus();
            Chassis.wheelNumber = "wweww/sfasda";
            Chassis.number = "adfas8555";
            Chassis.permissionLoad = 24100;

            new AutoBus();
            Transmision.types = "885aWEfds";
            Transmision.numbergear = "6";
            Transmision.manufacturer = "RRADCCCC";

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++   B U S   ++++++++++++++++");
            Console.WriteLine("Bus Engine Power :" + Engine.power);
            Console.WriteLine("Bus Engine Volume :" + Engine.volume);
            Console.WriteLine("Bus Engine Type :" + Engine.type);
            Console.WriteLine("Bus Engine Serial Number :" + Engine.serialNumber);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Bus Chassis Wheel Number : " + Chassis.wheelNumber);
            Console.WriteLine("Bus Chassis Number : " + Chassis.number);
            Console.WriteLine("Bus Chassis Permission Load : " + Chassis.permissionLoad);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Bus Transmission Type :" + Transmision.types);
            Console.WriteLine("Bus Transmission Number of Gear :" + Transmision.numbergear);
            Console.WriteLine("Bus Transmission Manufacturer :" + Transmision.manufacturer);
            




            _ = new Scooter();
            Engine.power = "1500";
            Engine.volume = "8";
            Engine.type = "manual";
            Engine.serialNumber = "tgdfg747411";

            new Scooter();
            Chassis.wheelNumber = "RSR/52255";
            Chassis.number = "43acr379";
            Chassis.permissionLoad = 15200;

            new Scooter();
            Transmision.types = "885aWEfds";
            Transmision.numbergear = "6";
            Transmision.manufacturer = "RRADCCCC";

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++   SCOOTER   ++++++++++++++++");
            Console.WriteLine("Scooter Engine Power :" + Engine.power);
            Console.WriteLine("Scooter Engine Volume :" + Engine.volume);
            Console.WriteLine("Scooter Engine Type :" + Engine.type);
            Console.WriteLine("Scooter Engine Serial Number :" + Engine.serialNumber);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Scooter Chassis Wheel Number : " + Chassis.wheelNumber);
            Console.WriteLine("Scooter Chassis Number : " + Chassis.number);
            Console.WriteLine("Scooter Chassis Permission Load : " + Chassis.permissionLoad);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Scooter Transmission Type :" + Transmision.types);
            Console.WriteLine("Scooter Transmission Number of Gear :" + Transmision.numbergear);
            Console.WriteLine("Scooter Transmission Manufacturer :" + Transmision.manufacturer);
            Console.ReadLine();
        }
    }

}