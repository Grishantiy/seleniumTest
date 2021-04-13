using OpenQA.Selenium;

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
            element.Click(); // created only for interviews and code reviews, but it's logical not to use it
        }
    }
}
