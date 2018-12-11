using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        void AddTester(Tester tester);
        void RemoveTester(Tester tester);
        void UpdateTester(Tester tester);

        void AddTrainee(Trainee trainee);
        void RemoveTrainee(Trainee trainee);
        void UpdateTrainee(Trainee trainee);

        void AddTest(Test test);
        void UpdateFinishedTest(Test test);
    }
}
