using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CriteriaOfTheTest
    {

        #region Constructor

        public CriteriaOfTheTest(string description)
        {
            CriterionDescription = description;
        }

        #endregion

        #region Properties

        public string CriterionDescription { get; set; }
        public bool SuccessfullyPassed { get; set; }

        #endregion
    }
}
