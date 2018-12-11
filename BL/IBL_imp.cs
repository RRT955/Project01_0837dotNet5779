using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace BL
{
    public class IBL_imp : IBL // implements the IBL interface
    {
        // אין אפשרות להוסיף מבחן לפני שעברו 7 ימים מהמבחן הקודם של התלמיד אם היה
        // here i need to connect a trainee to the test i want to add.
        public void AddTest(Test test)
        {
            Trainee _trainee = null;
            foreach (var trainee in DataSource.Trainees)
            {
                if (trainee.Id == test.TraineeId)
                    _trainee = trainee;
            }
            if (((DateTime.Now - _trainee.LastTestDate).TotalDays > 7) && (_trainee.NumberOfDrivingLessons > 20))
                DataSource.Tests.Add(test);
            //else
            // throw exception: (by the error)
            // 1) the minimum interval between 2 tests is 7 days
            // 2) a trainee must must have record of at least 20 drivig lessons to get a test
        }

        public void AddTester(Tester tester)
        {
            if (tester.Age > 40)
                DataSource.Testers.Add(tester);
            //else
                // throw exception: "Can't add a tester whose age < 40"
        }

        public void AddTrainee(Trainee trainee)
        {
            if (trainee.Age > 18)
                DataSource.Trainees.Add(trainee);
            //else
                // throw exception: "Can't add a trainee whose age < 18"
        }

        public void RemoveTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public void RemoveTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public void UpdateFinishedTest(Test test)
        {
            throw new NotImplementedException();
        }

        public void UpdateTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }
    }
}
