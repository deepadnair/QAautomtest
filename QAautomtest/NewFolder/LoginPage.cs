﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAautomtest.NewFolder
{
    public class LoginPage
    {
        public void Login(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-locked-24-field_form_locker_password]")).SendKeys("Testing");
            driver.FindElement(By.CssSelector("button[id='wpforms-submit-locked-24']")).Click();
            
        }
    }
}
