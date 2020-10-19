using LastLessionWPF.Base;
using LastLessionWPF.Commands;
using LastLessionWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Navigation;

namespace LastLessionWPF.ViewModels
{
	class MainWindowViewModel : INotifyPropertyChanged, IDisposable
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private List<Schooler> _schoolers;
		private StreamReader _stream;
		private Schooler _selectedScooler;
		public Schooler SelectedScooler
		{
			get => _selectedScooler;
			set
			{
				_selectedScooler = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedScooler"));
			}
		}
		public List<Schooler> Schoolers
		{
			get => _schoolers;
			set
			{
				_schoolers = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Schoolers"));
			}
		}
		public MainWindowViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			Schoolers = new List<Schooler>();
			using (_stream = new StreamReader("Schoolers.txt"))
			{
				while (!_stream.EndOfStream)
				{
					var str = _stream.ReadLine();
					if(!string.IsNullOrEmpty(str))
						Schoolers.Add(Parser.Parse(str));
				}
			}
		}
		public void Dispose()
		{
			_stream.Close();
		}
		public Command EditCommand => new Command(EditSchooler);
		private INavigationService _navigationService;
		public void EditSchooler()
		{
			_navigationService.Navigate(SelectedScooler);
			SelectedScooler = null;
		}
	}
}
