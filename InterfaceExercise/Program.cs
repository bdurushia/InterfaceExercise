using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //Now, create objects of your 3 classes and give their members values.

            var truck01 = new Truck() 
            { 
                Name = "Toyota",
                Logo = "(T)",
                Model = "Tacoma",
                Engine = "4.0L V6",
                Transmission = "6-Speed Manual",
                FuelType = "Gasoline",
                DriveTrain = "4-Wheel Drive",
                HasFlatBed = true,
                CabinSize = "Double Cab"
            };

            var suv01 = new SUV() 
            { 
                Name = "Audi",
                Logo = "OOOO",
                Model = "SQ5",
                Engine = "Turbo 3.0L V6",
                Transmission = "8-Speed Tiptronic",
                FuelType = "Gasoline",
                DriveTrain = "All-Wheel-Drive",
                HasBetterVisibility = true,
                HasExtraRoom = true
            };

            var car01 = new Car()
            {
                Name = "Volkswagen",
                Logo = "VW",
                Model = "Golf TDI",
                Engine = "Turbo 2.0L I4",
                Transmission = "6-Speed Manual",
                FuelType = "Diesel",
                DriveTrain = "Front-Wheel-Drive",
                FuelEfficiencyMPG = 43,
                CompactBodyType = "Hatchback"
            };

            //Creatively display and organize their values
            truck01.DisplayDetails();
            suv01.DisplayDetails();
            car01.DisplayDetails();

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
