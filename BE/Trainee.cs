using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {

        #region Constructor

        public Trainee()
        {

        }

        #endregion

        #region Properties

        // Custom fields
        public int Age { get; set; }
        public DateTime LastTestDate { get; set; }

        // Required fields
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public int YearsOfExperience { get; set; }
        public int MaximumPossibleWeeklyTests { get; set; }
        public CarType CarType { get; set; }
        public GearboxType GearboxType { get; set; }
        public string DrivingSchoolName { get; set; }
        public int NumberOfDrivingLessons { get; set; }
        public string TeacherName { get; set; }
        
        #endregion

        #region Overloads

        public override string ToString()
        {
            return "Trainee name: " + FirstName + " " + LastName + "\nPhone number: " + PhoneNumber;
        }

        #endregion
    }
}
