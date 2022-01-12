using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {


        public GroupHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

      

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            return this;
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups = new List<GroupData>();
            manager.Navigator.GoToGroupsPage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            foreach(IWebElement element in elements)
            {
                //GroupData group = new GroupData(element.Text);
                //groups.Add(group); 
                //groups.Add(new GroupData(element.Text));
                GroupData group = new GroupData();
                group.Name = element.Text;
                groups.Add(group);

            }

            return groups;
        }

        public GroupHelper Modify(int v, GroupData group, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            GroupExistenceVer(group);
            SelectGroup(v);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();


            return this;
            
        }

        

        public GroupHelper Remove(GroupData group, int v)
        {
            manager.Navigator.GoToGroupsPage();
            GroupExistenceVer(group);
            SelectGroup(v);
            RemoveGroup();
            return this;

        }




        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }


        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }







      

        public GroupHelper InitGroupModification()
        {

            driver.FindElement(By.Name("edit")).Click();

            return this;
        }
        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();

            return this;
        }


        public void GroupExistenceVer(GroupData group)
        {
            if (GroupExist())
            {
                return;
            }
            manager.Navigator.GoToGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            manager.Navigator.GoToGroupsPage();

        }

        public bool GroupExist()
        {
            return IsElementPresent(By.XPath("//div[@id='content']/form/span[1]/input"));            
        }
    }
}
