using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using seleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest.Tests
{
    class VacansiesTests
    {
        VacansiesPage page;

        [SetUp]
        public void Initialize()
        {
            Properties.driver = new ChromeDriver();
            Properties.driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            Properties.driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_Count_Vacancy_Select_DevelopDepart_And_English_Language()
        {
            page = new VacansiesPage();

            page.SelectDepartment(page.lnkDevelop);
            page.SelectLanguage(page.checkerEnglishLanguage);

            Assert.AreEqual(6, GetMethods.GetElementCount(page.vacancyCard), "The number of vacancies is not correct ");
        }

        [Test]
        public void test_Count_Vacancy_Select_DocDevDepart_And_France_German_Language()
        {
            page = new VacansiesPage();

            page.SelectDepartment(page.lnkDocDev);
            page.SelectLanguage(page.checkerFranceLanguage, page.checkerGermanLanguage);

            Assert.AreEqual(0, GetMethods.GetElementCount(page.vacancyCard), "The number of vacancies is not correct ");
        }
        
        [Test]
        public void test_Count_Vacancy_Select_HRDepart_And_Russia_English_Language()
        {
            page = new VacansiesPage();

            page.SelectDepartment(page.lnkHR);
            page.SelectLanguage(page.checkerRussiaLanguage, page.checkerEnglishLanguage);

            Assert.AreEqual(3, GetMethods.GetElementCount(page.vacancyCard), "The number of vacancies is not correct ");
        }
        [Test]
        public void test_Count_Vacancy_Select_FinanceDepart_And_Russia_Language()
        {
            page = new VacansiesPage();

            page.SelectDepartment(page.lnkFinance);
            page.SelectLanguage(page.checkerRussiaLanguage);

            Assert.AreEqual(1, GetMethods.GetElementCount(page.vacancyCard), "The number of vacancies is not correct ");
        }

        [TearDown]
        public void EndTest()
        {
            Properties.driver.Quit();
        }
    }
}
