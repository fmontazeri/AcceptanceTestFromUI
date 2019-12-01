using System;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleTest.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace XUnitTestDotNetCore
{
    [Binding]
    public class StudentSteps
    {
        private readonly IWebDriver _webDriver;

        public StudentSteps()
        {
            _webDriver = new ChromeDriver(@"C:\Git\XUnitTestDotNetCore\XUnitTestDotNetCore\bin\Debug\netcoreapp2.2");
        }

        [Given(@"I have entered personal information below")]
        public void GivenIHaveEnteredPersonalInformationBelow(Table table)
        {

            var student = table.CreateInstance<Student>();
            _webDriver.Navigate().GoToUrl("http://localhost:5000/Student");
            _webDriver.FindElement(By.Id("name")).SendKeys(student.Name);
            _webDriver.FindElement(By.Id("family")).SendKeys(student.Family);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _webDriver.FindElement(By.XPath(@"//input[@type='submit']")).Click();
        }
        
        [Then(@"I should see new student's information in page")]
        public void ThenIShouldSeeNewStudentSInformationInPage()
        {
            var student = new Student()
            {
                Name =  _webDriver.FindElement(By.Id("lbl-name")).Text ,
                Family =  _webDriver.FindElement(By.Id("lbl-family")).Text ,
            };

            var expectedStudent = new Student(){Name = "Fatemeh" , Family = "Montazeri" };

            student.Should().BeEquivalentTo(expectedStudent);

        }
    }
}
