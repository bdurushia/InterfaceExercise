using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In your IVehicle:

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */

    public interface IVehicle
    {

        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string DriveTrain { get; set; }

        public void DisplayDetails();

    }
}
