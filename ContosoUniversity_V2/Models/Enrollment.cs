using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_V2.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    //this is a many-to-many join table with payload in the db. It joins many students
    //with many courses. It is "with payload" because it contains grade information
    //about the course
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
