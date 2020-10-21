using LastLessionWPF.Base;
using LastLessionWPF.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LastLessionWPF.ViewModels
{
	class SchoolerEditViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private Schooler _schooler;
		public Schooler Schooler
		{
			get => _schooler;
			set
			{
				_schooler = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Schooler"));
			}
		}
		public SchoolerEditViewModel()
		{

		}
		public Command CancelCommand => new Command(Cancel);
		public void Cancel()
		{
			var result = MessageBox.Show("Вы уверены?", "Отменить изменения",MessageBoxButton.YesNo,MessageBoxImage.Question, MessageBoxResult.No, MessageBoxOptions.None);
			if (result != MessageBoxResult.Yes) return;
			Window window = null;
			foreach (var el in App.Current.Windows)
			{
				if (el is Window o && el.GetType().Namespace.Contains("LastLessionWPF") && !o.Equals(App.Current.MainWindow))
				{
					window = o;
					break;
				}
			}
			window?.Close();
		}
	}
}
