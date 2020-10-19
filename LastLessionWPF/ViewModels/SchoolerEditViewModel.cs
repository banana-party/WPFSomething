using LastLessionWPF.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public SchoolerEditViewModel(Schooler schooler)
		{
		}
	}
}
