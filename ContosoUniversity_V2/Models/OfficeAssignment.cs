using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity_V2.Models
{
    public class OfficeAssignment
    {
        [Key] //the Instructor foreign key is used as the OfficeAssignment primary
              //key because there is a one-to-zero-or-one relationship between an 
              //Instructor and OfficeAssignment. An OfficeAssignment only exists in
              //relation to the Instructor it is assigned to
        public int InstructorID { get; set; } //non-nullable because it is an int and
                                              //because an OfficeAssignment cannot exist
                                              //without an Instructor

        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Office Location")]
        [DisplayFormat(NullDisplayText = "No office")]
        public string Location { get; set; }

        [Required] //redundant but enforces that an OfficeAssignment cannot exist without an Instructor
        public Instructor Instructor { get; set; } //this is non-nullable by virtue of the 
                                                   //InstructorID of an OfficeAssignment being
                                                   //non-nullable
    }
}
