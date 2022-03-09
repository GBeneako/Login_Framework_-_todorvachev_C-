using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
//using DocumentFormat.OpenXml.Spreadsheet;

namespace testing_todorvachev_1
{
    class login
    {
        static IWebDriver driver = new ChromeDriver(@"G:\Gilbert's Documents\Selenium\Selenium 99 Location");

        static void Main(string[] args)
        {
            string url = "http://testing.todorvachev.com/selectors/name/";
            driver.Navigate().GoToUrl(url);

            Thread.Sleep(1000);

            //driver.Manage().window().maximize();

            driver.FindElement(By.CssSelector("#search-2 > form > label > input"));
            driver.FindElement(By.CssSelector("#search-2 > form > label > input")).SendKeys("ID");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("cat"));
            driver.FindElement(By.Id("cat")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#cat > option:nth-child(6)"));
            driver.FindElement(By.CssSelector("#cat > option:nth-child(6)")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#main-content > nav > div.mh-col-1-2.mh-post-nav-item.mh-post-nav-prev > a > img")).Click();

           var element = driver.FindElement(By.CssSelector("#main-content > nav > div.mh-col-1-2.mh-post-nav-item.mh-post-nav-prev > a > img"));
           Actions actions = new Actions(driver);
           actions.MoveToElement(element);
           actions.Perform();

            //Thread.Sleep(1000);
           // driver.FindElement(By.CssSelector("#post-72 > div > form > ul > li:nth-child(2) > input[type=text]")).SendKeys("Christopher");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#post-72 > div > form > ul > li:nth-child(4) > input[type=password]")).SendKeys("password");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#post-72 > div > form > ul > li:nth-child(6) > input[type=password]")).SendKeys("password");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#post-72 > div > form > ul > li:nth-child(7) > input[type=submit]")).Click();




        }
    }

}

