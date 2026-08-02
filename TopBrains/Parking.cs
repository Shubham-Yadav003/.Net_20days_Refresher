// File: ParkingFeeCalculator.cs
using System;
using System.Collections.Generic;

class ParkingFeeCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== PARKING FEE CALCULATOR ===\n");

        List<(char, double)> parkingRecords = new List<(char, double)>
        {
            ('C', 2.5),
            ('C', 12.0),
            ('M', 4.0),
            ('T', 6.5),
            ('C', 0.25),
            ('M', 10.0)
        };

        foreach (var record in parkingRecords)
        {
            CalculateAndDisplayFee(record.Item1, record.Item2);
            Console.WriteLine("------------------------");
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
        if (hours <= 0.5)
            return 0;

        double chargeableHours = hours - 0.5;

        double fee = chargeableHours * hourlyRate;

        if (fee > dailyMax)
            fee = dailyMax;

        if (hours > 8)
            fee = fee * 0.90;

        return fee;
    }

    static double GetHourlyRate(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => 3.00,
            'M' => 2.00,
            'T' => 5.00,
            _ => 0.00
        };
    }

    static double GetDailyMaximum(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => 25.00,
            'M' => 15.00,
            'T' => 40.00,
            _ => 0.00
        };
    }

    static string GetVehicleName(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => "Car",
            'M' => "Motorcycle",
            'T' => "Truck",
            _ => "Unknown"
        };
    }
}