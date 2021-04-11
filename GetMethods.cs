using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest
{
    public static class GetMethods
    {
        /// <summary>
        /// Gets the number of List elements on the page 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static int GetElementCount(this IList<IWebElement> elements)
        {
            
            return elements.Count;
        }
    }
}
