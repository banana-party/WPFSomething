using System;
using System.Globalization;
using System.Linq;

namespace LastLessionWPF.Base
{
	internal static class Parser
	{
		public static Schooler Parse(string text)
		{
			var lst = text.Split(',').ToList();
			return new Schooler()
			{ 
				Name = lst[0], Group = lst[1], Age = int.Parse(lst[2]), Avg = float.Parse(lst[3], CultureInfo.InvariantCulture) 
			};
		}
	}
}
