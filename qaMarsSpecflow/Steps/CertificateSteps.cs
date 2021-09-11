using qaMarsSpecflow.Helpers;
using qaMarsSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace qaMarsSpecflow.Steps
{
    [Binding]
    public class CertificateSteps
    {
        [Given(@"add certfication details")]
        public void GivenAddCertficationDetails()
        {
            // ScenarioContext.Current.Pending();

            ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "Certifications");
            CertificationPage.AddCertifications();
         
        }
        
        [Given(@"edit the certification detials")]
        public void GivenEditTheCertificationDetials()
        {
           // ScenarioContext.Current.Pending();

            /*ExcelLibHelper.PopulateInCollection($@"{LoginSteps.path}Data\Data.xlsx", "Certifications");
            CertificationPage.EditCertifications();*/
        }
        
        [Given(@"delete certification")]
        public void GivenDeleteCertification()
        {
           
        }
    }
}
