using System;

namespace Fordonsbesiktning
{
    internal class Vehicle
    {
        public int VehicleAge { get; set; }
        public bool HasInsurance { get; set; }

        public void CheckInspection()
        {
            Console.Write("Hur gammal är din bil? ");
            VehicleAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Har bilen försäkring (true/false)? ");
            string insuranceInput = Console.ReadLine();
            HasInsurance = Convert.ToBoolean(insuranceInput);

            if (VehicleAge < 5 && HasInsurance)
            {
                Console.WriteLine("Godkänd");
            }
            else if (VehicleAge < 5 && !HasInsurance)
            {
                Console.WriteLine("Ej godkänd — du måste ordna försäkring.");
            }
            else if (VehicleAge >= 5 && HasInsurance)
            {
                Console.WriteLine("Måste kompletteras, bilen är äldre än 5 år.");
            }
            else if (VehicleAge >= 5 && !HasInsurance)
            {
                Console.WriteLine("Ej godkänd — måste ordna försäkring och komplettera besiktning.");
            }
        }
    }
}
