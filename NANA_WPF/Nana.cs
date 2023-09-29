using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NANA_WPF {
	class Nana {
		protected ChromeDriverService DriverService = null;
		protected ChromeOptions Options = null;
		protected ChromeDriver Driver = null;
	
		public void Setup() {
			DriverService = ChromeDriverService.CreateDefaultService();
			DriverService.HideCommandPromptWindow = true;

			Options = new ChromeOptions();
			Options.AddArgument("disable-gpu");
		}

		public void NaverLogin(string ID, string PW) {
			Driver = new ChromeDriver(DriverService, Options);
			Driver.Navigate().GoToUrl("https://www.naver.com"); // 웹 사이트에 접속합니다.
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			var Element = Driver.FindElement(By.XPath("//*[@id='account']/div/a/i"));
			Element.Click();

			Driver.ExecuteScript("document.getElementsByName('id')[0].value=\'" + ID + "\'");
			Driver.ExecuteScript("document.getElementsByName('pw')[0].value=\'" + PW + "\'");

			Element = Driver.FindElement(By.XPath("//*[@id='log.login']"));
			Element.Click();
		}

		private void WaitNextWindow() {

		}

		public void FindNeighborhoodsList() {

		}

		public void PurposeToNeighborhoods() {

		}
	}
}
