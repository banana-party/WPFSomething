using LastLessionWPF.Base;
using LastLessionWPF.Delegates;

namespace LastLessionWPF.Interfaces
{
	interface INavigationService
	{
		void Navigate(Schooler SelectedScooler);
		void Navigate<T>(NavigationActionDelegate<T> action);
	}
}
