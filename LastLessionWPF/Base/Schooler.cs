using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLessionWPF.Base
{
	public class Schooler : ICloneable
	{
		public string Name { get; set; }
		public string Group { get; set; }
		public int Age { get; set; }
		public float Avg { get; set; }

		public object Clone()
		{
			return new Schooler()
			{
				Age = Age,
				Name = Name,
				Avg = Avg,
				Group = Group
			};
		}
	}
}
