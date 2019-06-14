using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_V2.Models
{
    //CourseAssignment acts as a regular many-to-many join table without payload 
    //in the db or a "pure join table". CourseAssignment does not contain any info
    //besides the foreign keys and navigational properties of the Course and Instructor
    //that it joins.
    public class CourseAssignment
    {
        //the Course and Instructor foreign keys will
        //be combined by EF into a composite primary key
        //for this CourseAssignment using fluent API. A 
        //composite primary key is used in this case because
        //it ensures that although you can have multiple rows
        //for a Course in the CourseAssignments table, and multiple
        //rows for an instructor, you cannot have multiple rows
        //for the same instructor and the same course (duplicates)
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        
        //navigational properties
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
