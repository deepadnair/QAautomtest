using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAautomtest.NewFolder
{
   public class BillingPage
    {
        public void Billing(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_0]")).SendKeys("Suzane");
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_0-last]")).SendKeys("Dezuza");
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_1]")).SendKeys("Suzaned@gmail.com"); 
            driver.FindElement(By.CssSelector("input[id='wpforms-24-field_2']")).SendKeys("1231231234");
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3]")).SendKeys("apt 12 NewPark");
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3-address2]")).SendKeys("Sandyford");
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3-city]")).SendKeys("Dublin");
 //Dropdown for State           
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state")));
            oSelect.SelectByText("Alaska");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            SelectElement oSelect1 = new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state")));
            oSelect.SelectByIndex(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            SelectElement oSelect2 = new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state")));
            oSelect.SelectByValue("DE");
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3-postal]")).SendKeys("12121-2121");
//Radiobutton for Available Items
            driver.FindElement(By.Id("wpforms-24-field_4_1")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("wpforms-24-field_4_2")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10;
            driver.FindElement(By.Id("wpforms-24-field_4_3")).Click();
//Textarea
            driver.FindElement(By.CssSelector("textarea[id=wpforms-24-field_6]")).SendKeys("Add Some Comments Here");

            driver.FindElement(By.CssSelector("button[id='wpforms-submit-24']")).Click();

        }
    }
}
