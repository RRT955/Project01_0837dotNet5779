using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {

        #region Constructor

        public Test()
        {
            CriteriaOfTheTest = new List<CriteriaOfTheTest>();
            CriteriaOfTheTest.Add(new CriteriaOfTheTest("Keeping distance"));
            CriteriaOfTheTest.Add(new CriteriaOfTheTest("Reverse parking"));
            CriteriaOfTheTest.Add(new CriteriaOfTheTest("Signaling"));
        }

        #endregion

        #region Properties

        public string TestNumber { get; set; } // unique and consists of 8 digits => option: use random.
        public int TestId { get; set; }
        public int TraineeId { get; set; }
        public DateTime DateOfTest { get; set; }
        public Address TestDepartureAddress { get; set; }
        public List<CriteriaOfTheTest> CriteriaOfTheTest { get; set; }
        public bool Passed { get; set; }
        public string Remarks { get; set; } 

        #endregion

        #region Overloads

        public override string ToString()
        {
            return "Test number: " + TestNumber + "\nTester Id: " + TestId + "\nTrainee Id: " + TraineeId;
        }

        #endregion

    }
}
