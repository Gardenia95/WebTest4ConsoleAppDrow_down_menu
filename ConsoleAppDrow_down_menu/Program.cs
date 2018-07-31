using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class Program
    {

    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

        static void Main()
        {
        string Url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(4)";
        driver.Navigate().GoToUrl(Url);
        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));
        Thread.Sleep(5000);
        Console.WriteLine(dropDownMenu.GetAttribute("value"));
        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
        Console.WriteLine("The third option from the drop menu is " + elementFromTheDropDownMenu);
        elementFromTheDropDownMenu.Click();
        Console.WriteLine("The selected value is:" + dropDownMenu.GetAttribute("value"));
        driver.Quit();

        

        }
    }

