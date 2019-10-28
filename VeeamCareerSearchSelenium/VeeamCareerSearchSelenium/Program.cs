using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace VeeamCareerSearchSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Search("Romania","English",214);
        
        }
        
        
        public void Search(string country, string language, int expected_number)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://careers.veeam.com");
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/a")).Click();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(1000);
            IWebElement clearfilter = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[7]/a"));
            if(clearfilter.Displayed)
            {
                clearfilter.Click();
                Console.WriteLine("Filter Cleared");
            }
            else
            {
                Console.WriteLine("Filter Clear option is not displayed. Filters are already cleared!");
            }

            //Both Xpath and Id is not able to locate Country DropdownList
            SelectElement countrylist = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[2]/dd/select")));
            IWebElement countrlistdisplayed = driver.FindElement(By.Id("country"));

            if (countrlistdisplayed.Displayed)
            {
                countrylist.SelectByValue(country);
            }
            else
            {

                Console.WriteLine("Country list is not displayed");

            }


            var languagefield = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/span"));

            if (languagefield.Displayed)
            {
                languagefield.Click();
                switch (language)
                {

                    case "Chinese":
                       
                        IWebElement Chinese = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[2]/span"));
                        if (Chinese.Displayed)
                        {
                            Chinese.Click();
                        }
                        else
                        {
                         Console.WriteLine("Chinese option is not displayed");
                        }
                        break;
                    case "Czech":
                        IWebElement Czech = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[3]/span"));
                        if (Czech.Displayed)
                        {
                            Czech.Click();
                        }
                        else
                        {
                            Console.WriteLine("Czech option is not displayed");
                        }
                        break;                       
                    case "Dutch":
                        IWebElement Dutch = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[4]/span"));
                        if (Dutch.Displayed)
                        {
                            Dutch.Click();
                        }
                        else
                        {
                            Console.WriteLine("Dutch option is not displayed");
                        }
                        break;
                    case "English":
                        IWebElement English = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[5]/span"));
                        if (English.Displayed)
                        {
                            English.Click();
                        }
                        else
                        {
                            Console.WriteLine("English option is not displayed");
                         }
                        break;
                    case "French":
                        IWebElement French = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[6]/span"));
                        if (French.Displayed)
                        {
                            French.Click();
                        }
                        else
                        {
                            Console.WriteLine("French option is not displayed");
                        }
                        break;

                    case "German":
                        IWebElement German = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[7]/span"));
                        if (German.Displayed)
                        {
                            German.Click();
                        }
                        else
                        {
                            Console.WriteLine("German option is not displayed");
                        }
                        break;
                    case "Italian":
                        IWebElement Italian = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[8]/span"));
                        if (Italian.Displayed)
                        {
                            Italian.Click();
                        }
                        else
                        {
                            Console.WriteLine("Italian option is not displayed");
                        }
                        break;
                    case "Russian":
                        IWebElement Russian = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[9]/span"));
                        if (Russian.Displayed)
                        {
                            Russian.Click();
                        }
                        else
                        {
                            Console.WriteLine("Russian option is not displayed");
                        }
                        break;
                    case "Serbian":
                        IWebElement Serbian = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[10]/span"));
                        if (Serbian.Displayed)
                        {
                            Serbian.Click();
                        }
                        else
                        {
                            Console.WriteLine("Serbian option is not displayed");
                        }
                        break;
                    case "Spanish":
                        IWebElement Spanish = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[11]/span"));
                        if (Spanish.Displayed)
                        {
                            Spanish.Click();
                        }
                        else
                        {
                            Console.WriteLine("Spanish option is not displayed");
                        }
                        break;
                    case "Turkish":
                        IWebElement Turkish = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[1]/div[2]/div/div/fieldset/label[12]/span"));
                        if (Turkish.Displayed)
                        {
                            Turkish.Click();
                        }
                        else
                        {
                            Console.WriteLine("Turkish option is not displayed");
                        }
                        break;
                    default:
                        Console.WriteLine("Language Choise is not available");
                        break;
               }

            }
            // Apply Changes
            IWebElement apply = driver.FindElement(By.XPath("/html/body/div[1]/article/section[2]/div/div/div[5]/div/div[2]/div/div/a"));
            if (apply.Displayed)
            {
                apply.Click();
            }
            else
            {
                Console.WriteLine("Couldn't find the apply button under Language Preferences");
            }

            // Comparasion of the available job vacancies 
            IWebElement count = driver.FindElement(By.XPath("/html/body/div[1]/article/section[3]/div/div[1]/div[1]/h3"));

            if (count.Displayed)
            {
                string number = count.Text;
                int result = int.Parse(Regex.Match(number, @"\d+").Value);
                Console.WriteLine("There are currently '" + result +"' available jobs for "+country+" with "+language+" Language Preference");
                if (result == expected_number)
                {

                    Console.WriteLine(" Number of available vacancies is :'" + result + "' and it is matching with expected number :'" +expected_number+ "' Test Case is Succeed!");
                    driver.Close();
                }
                else
                {
                    Console.WriteLine(" Number of available vacancies is :'" + result + "' and it is not matching with the expected number :'" + expected_number+"' Test Case is Failed!");
                    driver.Close();
                }
            }


        
        }
    

     



        
    }
}