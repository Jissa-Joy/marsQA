using qaMarsSpecflow.Helpers;
using qaMarsSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace qaMarsSpecflow.Steps
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"add skills to profile")]
        public void GivenAddSkillsToProfile()
        {
            //ScenarioContext.Current.Pending();

            ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "Skills");
            SkillsPage.AddSkills();
        }
        
        [Given(@"edit skills")]
        public void GivenEditSkills()
        {
            // ScenarioContext.Current.Pending();

            ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "Skills");
            SkillsPage.EditSkills();
        }
    }
}
