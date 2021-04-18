using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumTest.Pages;
using seleniumTest.Data;
using System.Collections.Generic;


namespace seleniumTest.Tests
{
    [TestFixture]
    class VacanсiesTests
    {
        VacanсiesPage page;

        [SetUp]
        public void Initialize()
        {
            Properties.driver = new ChromeDriver();
            Properties.driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            Properties.driver.Manage().Window.Maximize();
            page = new VacanсiesPage();
        }
        
        [Test, TestCaseSource(typeof(TestData),"countEnglishVacancies")]
        public void CountVacancySelectEnglishLanguage(string department, int expectVacancy)
        {            
            page.SelectDepartment(department);
            page.SelectLanguage(page.checkerEnglishLanguage);
            Assert.AreEqual(expectVacancy, page.vacancyCard.Count, $"The number of vacancies {department} is not correct");
        }

        [TearDown]
        public void EndTest()
        {
            Properties.driver.Quit();
        }
    }
}
