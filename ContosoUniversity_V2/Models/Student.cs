using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_V2.Models
{
    public class Student
    {
        [Key] //specifies that ID is the primary key for the student model
        public int ID { get; set; }
        /*[Required]*/ //make this a required field. Not needed for non-nullable types
                       //like DateTimes, ints, doubles, floats, etc.
        [StringLength(50, MinimumLength = 1)] //specifies that the max string length a user can input for 
                           //first and last names are 50 characters the MaxLength attribute
                           //can be used in a similar fashion to the StringLength attribute
                           //but doesn't provide client side validation
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")] //this RegularExpression attribute
                                                        //ensures that the first letter of the
                                                        //name is inputted uppercase and the rest
                                                        //of the characters are alphabetical
        [Display(Name = "Last Name")] //the Display attribute specifies that the caption for text boxes and 
                                      //anywhere that uses @Model.DisplayName in the .cshtml files should use
                                      //these strings as opposed to the member names
        public string LastName { get; set; }
        /*[Required]*/
        [StringLength(50, MinimumLength = 1)] //adding minimum length to the StringLength attribute
                                              //makes this a non-nullable string now. This means
                                              //we do not need the Required attribute anymore
        [Column("FirstName")] //maps the Student.FirstMidName member to 
                              //a column called FirstName in the SQL db to make queries
                              //easier. The EF would usually just use the member name as 
                              //the column header.
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)] //specifies a date type that is more specific
                                  //than the DBs intrinsic date type and allows the
                                  //browser to add a calender selector for changing the date
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //this specifies the date format and gets rid of the time of day that the student 
        //enrolled which we don't care about. ApplyFormatInEditMode specifies that the 
        //formatting should also be applied when the value is displayed in a text box for editing
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName //because FullName only has an accessor method and cannot be set
                               //or changed explicitly it will not have its own column in the db
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; } //a Student typed object has navigation in SQL tables
                                                                 //to the number of classes they are taking worth of 
                                                                 //enrollments. These enrollments connect to one class
                                                                 //and a class has as many enrollments as it does students.
                                                                 //IMPORTANT^^
    }
}
