using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest
{
    public static class SetMethods
    {
        /// <summary>
        /// Extended method for Click
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
    }
}
