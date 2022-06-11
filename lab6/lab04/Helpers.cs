using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public static class Helpers
    {

        public static void ClearAndType(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
