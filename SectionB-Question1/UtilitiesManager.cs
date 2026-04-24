using System;

namespace SectionB_Question1
{
    public class UtilitiesManager
    {
        public void ProcessRequest(ServiceRequest request)
        {
            request.UrgencyScore = request.PriorityLevel * request.SeverityLevel * 2;
            request.AdjustedResolutionHours = request.EstimatedResolutionHours + request.PriorityLevel;
            request.HouseholdImpactScore = request.RequestingResident.MonthlyUtilityUsage * 0.8;
        }

        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine("\n==== Service Report ====");
            Console.WriteLine($"Resident: {request.RequestingResident.Name}");
            Console.WriteLine($"Service Type: {request.RequestType}");
            Console.WriteLine($"Urgency Score: {request.UrgencyScore}");
            Console.WriteLine($"Adjusted Resolution: {request.AdjustedResolutionHours} hours");
            Console.WriteLine($"Household Impact Score: {request.HouseholdImpactScore:F2}");
        }
    }
}
