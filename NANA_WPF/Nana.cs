using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;

namespace NANA_WPF
{
	class Nana
	{
		ChromeDriverService DriverService = null;
		ChromeOptions Options = null;
		ChromeDriver Driver = null;


		public void Setup()
		{
			DriverService = ChromeDriverService.CreateDefaultService();

			Options = new ChromeOptions();
			Options.AddArgument("disable-gpu");
		}

		public void NaverLogin(string ID, string PW)
		{
			Driver = new ChromeDriver(DriverService, Options);
			Driver.Navigate().GoToUrl("https://www.naver.com");
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			var Element = Driver.FindElement(By.XPath("//*[@id='account']/div/a/i"));
			Element.Click();

			Driver.ExecuteScript("document.getElementsByName('id')[0].value=\'" + ID + "\'");
			Driver.ExecuteScript("document.getElementsByName('pw')[0].value=\'" + PW + "\'");

			Element = Driver.FindElement(By.XPath("//*[@id='log.login']"));
			Element.Click();
		}

		public void GotoBlogSectionPage()
		{
			Driver.Navigate().GoToUrl("https://section.blog.naver.com/ThemePost.naver?directoryNo=29&activeDirectorySeq=0&currentPage=1");
		}

		public void FindNeighborhoodsList()
		{
			var Elements = Driver.FindElements(By.ClassName("info_post"));
			if(Elements == null || Elements.Count() <= 0)
			{
				return;
			}

			foreach(var Element in Elements)
			{
				var title = Element.FindElement(By.ClassName("title_post"));
				if(title == null || Elements.Count() <= 0)
				{
					continue;
				}
			}
		}

		public void PurposeToNeighborhoods()
		{

		}
	}
}
