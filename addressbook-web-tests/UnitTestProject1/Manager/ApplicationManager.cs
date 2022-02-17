﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace mantis_tests
{
    public class ApplicationManager
    {
        protected string baseURL = "http://localhost/mantisbt-2.25.2";
        
        protected IWebDriver driver;
        //private StringBuilder verificationErrors;

        public APIHelper API { get;  set; }

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {

            driver = new FirefoxDriver();

            // Registration = new RegistrationHalper(this);
            baseURL = "http://localhost/mantisbt-2.25.2";
            Projects = new ProjectsHalper(this);
            Login = new LoginHalper(this);
            //verificationErrors = new StringBuilder();
            API = new APIHelper(this);
            //Ftp = new FTPHelper(this);
            //James = new JamesHelper(this);
            //Mail = new MailHelper(this);
            //Admin = new AdminHelper(this, baseURL);
        }
        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        public IWebDriver Driver 
        {
            get 
            {
                return driver;
            }
        }
        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager NewInstance = new ApplicationManager();
                NewInstance.Driver.Url = "http://localhost/mantisbt-2.25.2/login_page.php";
                app.Value = NewInstance;
            }
            return app.Value;
        }
       // public RegistrationHalper Registration { get; set; }
        public LoginHalper Login { get; set; }
        public ProjectsHalper Projects { get; set; }
        //public FTPHelper Ftp  { get; set; }
        //public JamesHelper James { get;  set; }
        //public MailHelper Mail { get; set; }
        //public AdminHelper Admin { get; set; }
    }
}

