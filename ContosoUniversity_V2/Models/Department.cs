using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity_V2.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")] //this is not changing the display name of Budget in the 
                                     //SQL db, it is changing the data type mapping so that the
                                     //column will be defined using the SQL Server money type
        public decimal Budget { get; set; }

        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; } //this is nullable because it points to the
                                               //Administrator navigational property which
                                               //a Department may or may not have.
                                               //IMPORTANT: Also if this was not nullable and
                                               //the instructor was deleted from the db, EF enables
                                               //cascade delete for non-nullable foreign keys which 
                                               //would delete the department as well as the instructor

        //navigational properties
        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; } //the courses this department offers
    }
}
