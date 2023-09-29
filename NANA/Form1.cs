﻿using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MahApps.Metro;

namespace NANA {
	public partial class NANAForm : MahApps.Metro {
		protected ChromeDriverService DriverService = null;
		protected ChromeOptions Options = null;

		public NANAForm() {
			InitializeComponent();

			Random rng = new Random();

			var themes = MetroStyleManager.Styles.Themes.Keys;
			MetroStyleManager.Default.Theme = themes.ElementAt(rng.Next(themes.Count));

			var styles = MetroStyleManager.Styles.Styles.Keys;
			MetroStyleManager.Default.Style = styles.ElementAt(rng.Next(styles.Count));

			DriverService = ChromeDriverService.CreateDefaultService();
			DriverService.HideCommandPromptWindow = true;

			Options = new ChromeOptions();
			Options.AddArgument("disable-gpu");
		}

		private void BtnLogin_Click(object sender, EventArgs e) {
			string ID = TB_ID.Text;
			string PW = TB_PW.Text;

			var Driver = new ChromeDriver(DriverService, Options);
			Driver.Navigate().GoToUrl("https://www.naver.com"); // 웹 사이트에 접속합니다.
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
				
			var Element = Driver.FindElement(By.XPath("//*[@id='account']/div/a/i"));
			Element.Click();

			Driver.ExecuteScript("document.getElementsByName('id')[0].value=\'" + ID + "\'");
			Driver.ExecuteScript("document.getElementsByName('pw')[0].value=\'" + PW + "\'");

			Element = Driver.FindElement(By.XPath("//*[@id='log.login']"));
			Element.Click();
		}
	}
}
