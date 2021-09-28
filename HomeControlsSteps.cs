using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSpecflowStarter.StepBindings
{
    [Binding]
    public class HomeControlsSteps
    {
        private String submitKey;
        private ChromeDriver chromeDriver;

        public HomeControlsSteps() => chromeDriver = new ChromeDriver();
        [Given(@"I have navigated to HomeControls website")]
        public void GivenIHaveNavigatedToHomeControlsWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://www.homecontrols.com/");
            chromeDriver.Manage().Window.Maximize();
            //Assert.IsTrue(chromeDriver.Title.ToLower().Contains("Home Controls Incorporate"));

        }
        
        [Given(@"I have entered username and password")]
        public void GivenIHaveEnteredUsernameAndPassword()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div[3]/div/div/header/div[3]/nav/div[3]/div[2]/div[2]/div/ul/li[1]/a")).Click();
            chromeDriver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/div/section/div/div[1]/div/form/fieldset/div[1]/div/input")).Click();
            chromeDriver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/div/section/div/div[1]/div/form/fieldset/div[1]/div/input")).SendKeys("ashutoshsamantasinghar1@gmail.com");
            chromeDriver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/div/section/div/div[1]/div/form/fieldset/div[2]/div/input")).Click();
            chromeDriver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/div/section/div/div[1]/div/form/fieldset/div[2]/div/input")).SendKeys("ashutosh");
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/div/section/div/div[1]/div/form/fieldset/div[6]/button")).Submit();
        }
        
        [Then(@"I should see the homepage")]
        public void ThenIShouldSeeTheHomepage()
        {
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("home controls - smart home automation leader"));
        }

        public void Dispose()
        {
            if(chromeDriver !=null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }

        }

    }
}
