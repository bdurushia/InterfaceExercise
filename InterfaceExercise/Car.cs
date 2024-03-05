using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In your Car class

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public class Car : ICompany, IVehicle
    {
        public int FuelEfficiencyMPG { get; set; }
        public string CompactBodyType { get; set; }

        // ICompany inheritence
        public string Logo { get; set; }
        public string Name { get; set; }

        // IVehicle ingeritence
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string DriveTrain { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"\n--------------------------------------");
            Console.WriteLine($"Make:\t\t{Name}\nLogo:\t\t{Logo}\nModel:\t\t{Model}\nEngine:\t\t{Engine}\n" +
                              $"Transmission:\t{Transmission}\nFuel Type:\t{FuelType}\nDrive Train:\t{DriveTrain}\n" +
                              $"MPG:\t\t{FuelEfficiencyMPG}\nBody Size:\t{CompactBodyType}\n");
        }
    }
}
