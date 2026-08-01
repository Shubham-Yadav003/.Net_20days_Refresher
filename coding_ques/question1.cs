using System;
using System.Collections.Generic;

namespace question1;
public class ParkingFeeCalculator
{
    public static void Question1()
    {
        Console.WriteLine(" PARKING FEE CALCULATOR \n");

        // Sample data: VehicleType, Hours
        List<(char, double)> parkingRecords = new List<(char, double)>
        {
            ('C', 2.5),   // Car, 2.5 hours
            ('C', 12.0),  // Car, 12 hours (max fee applies)
            ('M', 4.0),   // Motorcycle, 4 hours
            ('T', 6.5),   // Truck, 6.5 hours
            ('C', 0.25),  // Car, 15 minutes (free)
            ('M', 10.0)   // Motorcycle, 10 hours (discount)
        };

        foreach (var record in parkingRecords)
        {
            CalculateAndDisplayFee(record.Item1, record.Item2);
            Console.WriteLine("--");
        }
    }

    static void CalculateAndDisplayFee(char vehicleType, double hours)
    {
        double hourlyRate = GetHourlyRate(vehicleType);
        double dailyMax = GetDailyMaximum(vehicleType);
        string vehicleName = GetVehicleName(vehicleType);

        double fee = CalculateParkingFee(hours, hourlyRate, dailyMax);

        Console.WriteLine($"Vehicle: {vehicleName}");
        Console.WriteLine($"Parking Duration: {hours:F2} hours");
        Console.WriteLine($"Hourly Rate: ${hourlyRate:F2}");
        Console.WriteLine($"Daily Maximum: ${dailyMax:F2}");
        Console.WriteLine($"Total Fee: ${fee:F2}");
    }

    static double CalculateParkingFee(double hours, double hourlyRate, double dailyMax)
    {
        // First 30 minutes free
        if (hours <= 0.5)
        {
            return 0;
        }

        // Remove first 30 minutes from calculation
        double billableHours = hours - 0.5;

        // Calculate base fee
        double fee = billableHours * hourlyRate;

        // Apply daily maximum
        if (fee > dailyMax)
        {
            fee = dailyMax;
        }

        // Apply discount for long parking (> 8 hours total duration)
        if (hours > 8)
        {
            fee = fee * 0.9;
        }

        return fee;
    }

    static double GetHourlyRate(char vehicleType)
    {
        switch (char.ToUpper(vehicleType))
        {
            case 'C': return 3.0;
            case 'M': return 2.0;
            case 'T': return 5.0;
            default: return 0.0;
        }
    }

    static double GetDailyMaximum(char vehicleType)
    {
        switch (char.ToUpper(vehicleType))
        {
            case 'C': return 25.0;
            case 'M': return 15.0;
            case 'T': return 40.0;
            default: return 0.0;
        }
    }

    static string GetVehicleName(char vehicleType)
    {
        switch (char.ToUpper(vehicleType))
        {
            case 'C': return "Car";
            case 'M': return "Motorcycle";
            case 'T': return "Truck";
            default: return "Unknown";
        }
    }
}