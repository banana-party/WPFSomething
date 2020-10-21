using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLessionWPF.Interfaces
{
	interface IDialogService
	{
		bool ShowQuestion(string text, string caption);
	}
}
