using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Fordonsbesiktning
{
    internal class Vehicle
    {
        public int VehicleAge { get; set; }
        public bool HasInsurance { get; set; }

        public void CheckInspection()
        {
            Console.WriteLine("Hur gammal är din bil?");
            VehicleAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Har bilen försäkring (true/false)? ");
            string insuranceInput = Console.ReadLine(); 
            HasInsurance = Convert.ToBoolean(insuranceInput); //konvertar bool



            if (VehicleAge < 5 && HasInsurance) //if else, under 5 år och kolla om den har insurance med bool true eller false
            {
                Console.WriteLine("Godkänd");
            }
            else if (VehicleAge < 5 && !HasInsurance) //om yngre och har insurance
            {
                Console.WriteLine("Ej godkänd måste ordna försäkring");
            }
            else if (VehicleAge >= 5) // annars fix it
            {
                Console.WriteLine("Måste kompletteras");
            }
        }
    }
}
