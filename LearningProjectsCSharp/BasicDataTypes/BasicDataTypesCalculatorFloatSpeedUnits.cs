using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesCalculatorFloatSpeedUnits
    {
        static void Main(string[] args)
        {
            /*
            Create a program to ask the user for a distance (in meters) and the time taken(as three numbers: hours, minutes, seconds),
            and display the speed, in meters per second, kilometers per hour and miles per hour(hint: 1 mile = 1609 meters).
            */

            float SpeedInMeters = 0;
            float SpeedInKilometers = 0;
            float SpeedInMiles = 0;

            float DistanceInMeters = 0;
            float TimeTakenHours = 0;
            float TimeTakenMinutes = 0;
            float TimeTakenSeconds = 0;

            Console.Write("Distance (in meters): ");
            DistanceInMeters = Convert.ToSingle(Console.ReadLine());

            Console.Write("Time taken (Hours): ");
            TimeTakenHours = Convert.ToSingle(Console.ReadLine());

            Console.Write("Time taken (Minutes): ");
            TimeTakenMinutes = Convert.ToSingle(Console.ReadLine());

            Console.Write("Time taken (Seconds): ");
            TimeTakenSeconds = Convert.ToSingle(Console.ReadLine());

            SpeedInMeters = DistanceInMeters / ((TimeTakenSeconds * 3600) + (TimeTakenMinutes * 60) + TimeTakenSeconds);
            SpeedInKilometers = (DistanceInMeters / 1000.0f) / TimeTakenHours;
            SpeedInMiles = (DistanceInMeters / 1609.0f) / TimeTakenHours;

            Console.WriteLine("Speed in meters per second: {0}", SpeedInMeters);
            Console.WriteLine("Speed in kilometers per hour: {0}", SpeedInKilometers);
            Console.WriteLine("Speed in miles per hour: {0}", SpeedInMiles);

            Console.ReadLine();
        }
    }
}
