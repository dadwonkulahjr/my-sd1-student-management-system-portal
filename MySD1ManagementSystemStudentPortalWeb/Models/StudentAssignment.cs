namespace MySD1ManagementSystemStudentPortalWeb.Models
{
    public class StudentAssignment
    {
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}
