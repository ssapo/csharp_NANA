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


namespace NANA_WPF {
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : MetroWindow {
		Nana nanaInstance = null;

		public MainWindow() {
			InitializeComponent();

			ThemeManager.Current.ChangeTheme(this, "Dark.Green");

			nanaInstance = new Nana();
			if (nanaInstance != null) {
				nanaInstance.Setup();
			}
		}

		private void Btn_Login_Click(object sender, RoutedEventArgs e) {
			string ID = TB_ID.Text;
			string PW = TB_PW.Text;
			
			if (nanaInstance != null) {
				nanaInstance.NaverLogin(ID, PW);
			}
		}
	}
}
