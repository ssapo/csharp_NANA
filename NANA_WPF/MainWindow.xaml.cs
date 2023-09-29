using MahApps.Metro.Controls;
using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NANA_WPF {
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : MetroWindow {

		protected ChromeDriverService DriverService = null;
		protected ChromeOptions Options = null;

		public MainWindow() {
			InitializeComponent();

			ThemeManager.Current.ChangeTheme(this, "Dark.Green");

			DriverService = ChromeDriverService.CreateDefaultService();
			DriverService.HideCommandPromptWindow = true;

			Options = new ChromeOptions();
			Options.AddArgument("disable-gpu");
		}

		private void Btn_Login_Click(object sender, RoutedEventArgs e) {
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
