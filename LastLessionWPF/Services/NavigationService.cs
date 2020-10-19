using LastLessionWPF.Base;
using LastLessionWPF.Delegates;
using LastLessionWPF.Interfaces;
using LastLessionWPF.ViewModels;
using System.ComponentModel;

namespace LastLessionWPF.Services
{
	public class NavigationService : INavigationService
	{
		public void Navigate(Schooler SelectedScooler)
		{
			SchoolerEditView view = new SchoolerEditView();
			if (view.DataContext is SchoolerEditViewModel schoolerEditViewModel)
				schoolerEditViewModel.Schooler = SelectedScooler;
			view.ShowDialog();
		}

		public void Navigate<T>(NavigationActionDelegate<T> action)
		{
			SchoolerEditView view = new SchoolerEditView();
			action?.Invoke((T)view.DataContext);
			view.ShowDialog();
		}
	}
}
