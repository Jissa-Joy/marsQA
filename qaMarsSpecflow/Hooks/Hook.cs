using qaMarsSpecflow.Helpers;
using qaMarsSpecflow.Steps;
using qaMarsSpecflow.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace qaMarsSpecflow.Hooks
{
    [Binding]
   public class Hook
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver.Initialize();
            ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "Login");
            Start.SigninStep();
        }


        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Quit();
        }
    }
}
