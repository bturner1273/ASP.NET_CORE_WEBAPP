using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity_V2.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date), Display(Name = "Hire Date")] //you can put multiple attribute
                                                               //assignments on one line separated
                                                               //by commas within the same square brackets
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<CourseAssignment> CourseAssignments { get; set; } //the list of courses 
                                                                             //this instructor teaches
        public OfficeAssignment OfficeAssignment { get; set; } //the instructors office, this is nullable
                                                               //due to the fact that an instructor may or 
                                                               //may not have an office
    }
}
