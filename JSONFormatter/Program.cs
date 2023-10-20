using JSONFormatter;

//Course course = new();
//Console.WriteLine(course.ConvertJson());

Course course = new ();
course.Title = "Asp.Net";
course.Fees = 30000;
course.Teacher = new Instructor()
{
    Name = "Jalal Uddin",
    Age = 40
};
course.Topics = new List<Topic>()
{
    new Topic
    {
        Title = "C# Basic-1",
        Description = "C# Basics",
        Sessions = new List<Session>()
        {
            new Session()
            {
                DurationInHour = 2,
                LearningObjective = "Environment Setup",
            },
            new Session()
            {
                DurationInHour = 2,
                LearningObjective = "Variable, Data.",
            }
        }
    },
    new Topic
    {
        Title = "C# Basic-2",
        Description = "C# Basics",
        Sessions = new List<Session>()
        {
            new Session()
            {
                DurationInHour = 2,
                LearningObjective = "Array",
            },
            new Session()
            {
                DurationInHour = 2,
                LearningObjective = "Linked List",
            }
        }
    }
};
course.Tests = new List<AdmissionTest>
{
    new AdmissionTest
    {
        StartDateTime = DateTime.Now,
        EndDateTime = DateTime.Now,
        ExamFees = 200
    },
    new AdmissionTest
    {
        StartDateTime = DateTime.Now,
        EndDateTime = DateTime.Now,
        ExamFees = 300
    }
};

Console.WriteLine(course.ConvertJson());
