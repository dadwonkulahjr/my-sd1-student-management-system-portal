using System;
using System.ComponentModel.DataAnnotations;


namespace MySD1ManagementSystemStudentPortalWeb.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? Date { get; set; }
    }
}
