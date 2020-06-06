﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Tests.Acceptance.Base;

namespace WebApplication.Tests.Acceptance.Pages
{
    public class EmployeeListPage : BasePage
    {
        public EmployeeListPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url
        {
            get
            {
                return BaseUrl + "/Employees";
            }
        }

    }
}
