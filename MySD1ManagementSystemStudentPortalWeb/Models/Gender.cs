using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MySD1ManagementSystemStudentPortalWeb.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Student> Students { get; set; }

    }
}
