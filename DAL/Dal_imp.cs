using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    class Dal_imp : Idal
    {
        public void AddTest(Test test)
        {
            DataSource.Tests.Add(test);
        }

        public void AddTester(Tester tester)
        {
            DataSource.Testers.Add(tester);
        }

        public void AddTrainee(Trainee trainee)
        {
            DataSource.Trainees.Add(trainee);
        }

        // we don't send the data itself but a copy. implement ICloneable ???
        public List<Tester> GetTesters()
        {
            List<Tester> testers = new List<Tester>();
            foreach (var tester in DataSource.Testers)
            {
                Tester temp = tester;
                testers.Add(temp);
            }
            return testers;
        }

        // we don't send the data itself but a copy. implement ICloneable ???
        public List<Test> GetTests()
        {
            List<Test> tests = new List<Test>();
            foreach (var test in DataSource.Tests)
            {
                Test temp = test;
                tests.Add(temp);
            }
            return tests;
        }

        // we don't send the data itself but a copy. implement ICloneable ???
        public List<Trainee> GetTrainees()
        {
            List<Trainee> trainees = new List<Trainee>();
            foreach (var trainee in DataSource.Trainees)
            {
                Trainee temp = trainee;
                trainees.Add(temp);
            }
            return trainees;
        }

        public void RemoveTester(Tester tester) // can we get just the id of the tester ???
        {
            // using linq ???
            DataSource.Testers.Remove(tester);
        }

        public void RemoveTrainee(Trainee trainee)
        {
            DataSource.Trainees.Remove(trainee);
        }

        public void UpdateFinishedTest(Test test)
        {
            for (int i = 0; i < DataSource.Tests.Count; i++)
            {
                if (DataSource.Tests[i].TestId == test.TestId)
                    DataSource.Tests[i] = test;
            }
        }

        public void UpdateTester(Tester tester)
        {
            for (int i = 0; i < DataSource.Testers.Count; i++)
            {
                if (DataSource.Testers[i].Id == tester.Id)
                    DataSource.Testers[i] = tester;
            }
        }

        public void UpdateTrainee(Trainee trainee)
        {
            for (int i = 0; i < DataSource.Trainees.Count; i++)
            {
                if (DataSource.Trainees[i].Id == trainee.Id)
                    DataSource.Trainees[i] = trainee;
            }
        }
    }
}
