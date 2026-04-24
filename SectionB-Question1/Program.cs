using SectionB_Question1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmfuleniMunicipalityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilitiesManager manager = new UtilitiesManager();
            List<Resident> residents = new List<Resident>();
            List<ServiceRequest> requests = new List<ServiceRequest>();

            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            Console.Write("How many residents do you want to register? ");
            int residentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < residentCount; i++)
            {
                Console.WriteLine($"\n--- Resident {i + 1} ---");
                Resident newResident = new Resident();

                Console.Write("Name: ");
                newResident.Name = Console.ReadLine();

                Console.Write("Address: ");
                newResident.Address = Console.ReadLine();

                Console.Write("Account Number: ");
                newResident.AccountNumber = Console.ReadLine();

                Console.Write("Monthly Utility Usage (kWh or litres): ");
                newResident.MonthlyUtilityUsage = double.Parse(Console.ReadLine());

                residents.Add(newResident);
            }

            Console.WriteLine();
            Console.Write("How many service requests do you want to log? ");
            int requestCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < requestCount; i++)
            {
                Console.WriteLine($"\n--- Service Request {i + 1} ---");
                ServiceRequest newRequest = new ServiceRequest();

                Console.Write($"Select resident by number (1 to {residents.Count}): ");
                int resIndex = int.Parse(Console.ReadLine()) - 1;
                newRequest.RequestingResident = residents[resIndex];

                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                newRequest.RequestType = Console.ReadLine();

                Console.Write("Priority Level (1-5): ");
                newRequest.PriorityLevel = int.Parse(Console.ReadLine());

                Console.Write("Severity Level (1-10): ");
                newRequest.SeverityLevel = int.Parse(Console.ReadLine());

                Console.Write("Estimated Resolution Hours: ");
                newRequest.EstimatedResolutionHours = int.Parse(Console.ReadLine());

                manager.ProcessRequest(newRequest);
                requests.Add(newRequest);
            }

            foreach (var req in requests)
            {
                manager.GenerateReport(req);
            }

            if (requests.Count > 0)
            {
                Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");
                Console.WriteLine("Highest priority issue:");

                var highestUrgencyRequest = requests.OrderByDescending(r => r.UrgencyScore).First();

                Console.WriteLine($"Resident: {highestUrgencyRequest.RequestingResident.Name}");
                Console.WriteLine($"Service Type: {highestUrgencyRequest.RequestType}");
                Console.WriteLine($"Urgency Score: {highestUrgencyRequest.UrgencyScore}");

                Console.WriteLine($"Adjusted Resolution: {highestUrgencyRequest.AdjustedResolutionHours} hours");
                Console.WriteLine($"Household Impact Score: {highestUrgencyRequest.HouseholdImpactScore:F2}");
            }

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
            Console.ReadLine();
        }
    }
}