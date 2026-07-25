namespace Q1.Models
{
    public class Student
    {
        public int id { get; set; }

        public string StudentNumber { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string Module { get; set; } = string.Empty;

        public double Mark { get; set; }

        public string GetResult()
        {
            return Mark >= 50 ? "Pass" : "Fail";
        }
    }
}
