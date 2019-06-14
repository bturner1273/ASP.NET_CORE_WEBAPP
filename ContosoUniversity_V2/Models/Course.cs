using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_V2.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //tells the db that the primary key
                                                          //property of the data model are provided
                                                          //by the user instead of db generated
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; } //foreign keys do not need to be included
                                              //in data models where the navagation properties
                                              //are available (i.e. Department in this case)
                                              //however it makes updates simpler and more efficient
                                              //it allows updating a course without having to fetch
                                              //the department navagational property first because
                                              //the key is already included

        //navigational properties
        public Department Department { get; set; } //the Department that provides this course
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; } //a course can be taught
                                                                             //by multiple instructors having
                                                                             //this course assigned. That is
                                                                             //why a collection is used
    }
}
