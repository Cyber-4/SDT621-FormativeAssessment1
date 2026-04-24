namespace SectionB_Question1
{
    public class ServiceRequest
    {
        public Resident RequestingResident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public int EstimatedResolutionHours { get; set; }

        public int UrgencyScore { get; set; }
        public int AdjustedResolutionHours { get; set; }
        public double HouseholdImpactScore { get; set; }
    }
}
