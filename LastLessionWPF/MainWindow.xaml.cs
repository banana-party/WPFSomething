using LastLessionWPF.Services;
using LastLessionWPF.ViewModels;
using System.Windows;


namespace LastLessionWPF
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			DataContext = new MainWindowViewModel(new NavigationService());
			InitializeComponent();
		}
	}
}
