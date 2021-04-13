using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumTest.Pages;
using System.Collections.Generic;


namespace seleniumTest.Tests
{

    class VacanсiesTests
    {
        VacanсiesPage page = new VacanсiesPage();

        public static IEnumerable<TestCaseData> countEnglishVacancies()
        {
            yield return new TestCaseData(page.linkDevelop,6);
            yield return new TestCaseData(page.linkSales,8);
            yield return new TestCaseData(page.linkSupport,3);
            
        }

        [SetUp]
        public void Initialize()
        {
            Properties.driver = new ChromeDriver();
            Properties.driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            Properties.driver.Manage().Window.Maximize();
            page = new VacanсiesPage();
        }
        
        [Test, TestCaseSource("countEnglishVacancies")]
        public void CountVacancySelectEnglishLanguage(IWebElement department,int expectVacancy)
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
