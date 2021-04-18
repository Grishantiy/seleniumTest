using NUnit.Framework;
using seleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest.Data
{
    class TestData
    {
        public static IEnumerable<TestCaseData> countEnglishVacancies()
        {
            yield return new TestCaseData("//a[text()='Продажи']", 10);
            yield return new TestCaseData("//a[text()='Разработка продуктов']", 6);
        }
      
    }
}
