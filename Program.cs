using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://account.mail.ru/signup?from=main&rf=auth.mail.ru&app_id_mytracker=58519");
            Thread.Sleep(2000);
            List<IWebElement> webElements = chromeDriver.FindElementsByTagName("button").ToList();
            foreach (var item in webElements)
            {
                if (!item.Displayed)
                    continue;
                if (!item.Text.ToLower().Equals("пропустить"))
                    continue;
                item.Click();
                break;
            }
            Thread.Sleep(1000);
            NetWork netWork = new NetWork();
            netWork.InputText(chromeDriver, "fname" , "Волан");
            netWork.InputText(chromeDriver, "lname", "Де-морт");
            netWork.InputBirthday(chromeDriver, "birth-date__day", "react-select-2-option-26");
            netWork.InputBirthday(chromeDriver, "birth-date__month", "react-select-3-option-10");
            netWork.InputBirthday(chromeDriver, "birth-date__year", "react-select-4-option-19");
            
        }
    }
}
