using System;
using TechTalk.SpecFlow;

namespace Training_2.Step_Definations
{
    [Binding]
    public class RegistrationSteps
    {
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }
           

        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the click on signup")]
        public void WhenTheClickOnSignup()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
