using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;


namespace seleniumTest.Pages
{
    class VacanсiesPage
    {
        public VacanсiesPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//button[@id='sl'])[1]")]
        public IWebElement btnDepartment { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Разработка продуктов']")]
        public IWebElement linkDevelop { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Тех. поддержка']")]
        public IWebElement linkSupport { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Дизайн']")]
        public IWebElement linkDesign { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Продажи']")]
        public IWebElement linkSales { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Маркетинг']")]
        public IWebElement linkMarketing { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='HR']")]
        public IWebElement linkHR { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Финансовый отдел']")]
        public IWebElement linkFinance { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Разработка инф. ресурсов']")]
        public IWebElement linkResourcesDev { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Инф. технологии']")]
        public IWebElement linkIT { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Разработка внутренних систем']")]
        public IWebElement linkInternalSysDev { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='QA / Тестирование']")]
        public IWebElement linkQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Продакт менеджмент']")]
        public IWebElement linkProdManagement { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Разработка тех. документации']")]
        public IWebElement linkDocDev { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Административный отдел']")]
        public IWebElement linkAdminDepart { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Другое']")]
        public IWebElement linkOther { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[@id='sl'])[2]")]
        public IWebElement btnLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lang-option-0']")]
        public IWebElement checkerRussiaLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lang-option-1']")]
        public IWebElement checkerEnglishLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lang-option-2']")]
        public IWebElement checkerFranceLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='lang-option-3']")]
        public IWebElement checkerGermanLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='card card-no-hover card-sm']")]
        public IList<IWebElement> vacancyCard { get; set; }

        /// <summary>
        /// Select department
        /// </summary>
        /// <param name="department"></param>
        public void SelectDepartment(IWebElement department)
        {
            btnDepartment.Clicks();
            department.Clicks();
        }
        public void SelectDepartment(string departmentXpath)
        {
            btnDepartment.Clicks();
            Properties.driver.FindElement(By.XPath(departmentXpath)).Clicks();
        }
        /// <summary>
        /// Select language on the page
        /// </summary>
        /// <param name="language"></param>
        public void SelectLanguage(params IWebElement[] language)
        {
            List<IWebElement> listLanguage = new List<IWebElement>();
            for (int i = 0; i < language.Length; i++)
                listLanguage.Add(language[i]);
            List<IWebElement> listComparsion = new List<IWebElement>() { checkerEnglishLanguage, checkerFranceLanguage, checkerGermanLanguage, checkerRussiaLanguage };
            if (btnLanguage.GetAttribute("aria - expanded") != "true")
                btnLanguage.Clicks();
            for (int i = 0; i < listLanguage.Count; i++)
            {
                if (!listLanguage[i].Selected)
                    listLanguage[i].Clicks();
            }
            List<IWebElement> listUnchecked = new List<IWebElement>();
            listUnchecked = listComparsion.Where(i => !listLanguage.Contains(i)).ToList();
            for (int i = 0; i < listUnchecked.Count; i++)
            {
                if (listUnchecked[i].Selected)
                    listUnchecked[i].Clicks();
            }
            btnLanguage.Clicks();
        }     
    }
}
