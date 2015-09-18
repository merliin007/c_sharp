using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;




namespace SeleniumTest
{
    class SymcManage
    {
        public void browsePage(string url)
        {
            IWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            IWebElement userName = driver.FindElement(By.Id("txtEmail"));
            IWebElement passWord = driver.FindElement(By.Id("txtPassword"));

            string login_user = "qaadmin@liveoffice.com";
            string login_pass = "Test@123";

            userName.SendKeys(login_user);
            passWord.SendKeys(login_pass);

            IWebElement btonClick = driver.FindElement(By.Id("bLogin"));
            btonClick.Click();

            Thread.Sleep(5000);
            //IWebElement partnerMgmt = driver.FindElement(By.XPath("//div[contains(@class, 'folderText') and text()='Partner Management']"));
            //IWebElement partnerMgmt = driver.FindElement(By.XPath("//div[@class='folderText' and contains(., 'Partner Management')]"));
            IWebElement partnerMgmt = driver.FindElement(By.XPath("//span[contains(text(), 'Partner Management')]"));
            partnerMgmt.Click();
            IWebElement reports = driver.FindElement(By.XPath("//span[contains(text(), 'Reports')]"));
            reports.Click();
            IWebElement report_name = driver.FindElement(By.XPath("//select[id()='ddlReports']"));
            SelectElement se = new SelectElement(report_name);
            se.SelectByIndex(2);

        }
    }
}
