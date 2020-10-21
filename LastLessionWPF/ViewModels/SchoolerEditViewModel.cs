using LastLessionWPF.Base;
using LastLessionWPF.Commands;
using LastLessionWPF.Interfaces;
using LastLessionWPF.Services;
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
			_dialogService = new DialogService();
		}
		public Command CancelCommand => new Command(Cancel);
		public Command SaveCommand => new Command(Save);


		private IDialogService _dialogService;
		public void Save()
		{
			bool save = _dialogService.ShowQuestion("Вы уверены?", "Сохранить изменения.");
			if (!save)
				return;

			Close();
		}
		public void Cancel()
		{
			bool close = _dialogService.ShowQuestion("Вы уверены?", "Отменить изменения.");
			if(close)
				Close();
		}
		private void Close()
		{
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
