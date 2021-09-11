using qaMarsSpecflow.Helpers;
using qaMarsSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace qaMarsSpecflow.Steps
{
    [Binding]
    public class LanguageSteps
    {
        [Given(@"Add language details")]
        public void GivenAddLanguageDetails()
        {
            //ScenarioContext.Current.Pending();

            ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "LanguageDetails");
            LanguagePage.AddLanguage();


        }
        
        [Given(@"Edit language details")]
        public void GivenEditLanguageDetails()
        {
            // ScenarioContext.Current.Pending();
         ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "LanguageDetails");
            LanguagePage.EditLanguage();
        
        }
        
        [Given(@"delete language details")]
        public void GivenDeleteLanguageDetails()
        {
            Console.WriteLine("test");
            //LanguagePage.DeleteLanguage();
        }
    }
}
