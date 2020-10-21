using LastLessionWPF.Interfaces;
using System.Windows;

namespace LastLessionWPF.Services
{
	class DialogService : IDialogService
	{
		public bool ShowQuestion(string text, string caption)
		{
			var result = MessageBox.Show(text, caption, MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No, MessageBoxOptions.None);
			return result == MessageBoxResult.Yes;
		}
	}
}
