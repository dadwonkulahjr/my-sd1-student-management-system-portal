namespace MySD1ManagementSystemStudentPortalWeb.Models
{
    public class StudentAssignment
    {
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
    }
}
