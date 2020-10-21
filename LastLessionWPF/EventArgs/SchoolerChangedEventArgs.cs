using LastLessionWPF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLessionWPF.EventArgs
{
	public class SchoolerChangedEventArgs : System.EventArgs
	{
		public Schooler OldSchooler { get; }
		public Schooler NewSchooler { get; }
		public SchoolerChangedEventArgs(Schooler oldSchooler, Schooler newSchooler)
		{
			OldSchooler = oldSchooler;
			NewSchooler = newSchooler;
		}
	}
}
