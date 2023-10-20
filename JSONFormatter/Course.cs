namespace JSONFormatter
{
    public class Course
    {
        public string? Title { get; set; }
        public Instructor? Teacher { get; set; }
        public List<Topic>? Topics { get; set; }
        public double Fees { get; set; }
        public List<AdmissionTest>? Tests { get; set; }
    }

    public class AdmissionTest
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double ExamFees { get; set; }
    }

    public class Topic
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Session>? Sessions { get; set; }
    }

    public class Session
    {
        public int DurationInHour { get; set; }
        public string? LearningObjective { get; set; }
    }

    public class Instructor
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
