using System;
using System.ComponentModel;

namespace LastLessionWPF.Base
{
	public class Schooler : ICloneable, INotifyPropertyChanged
	{
		public string _name;
		public string Name 
		{
			get => _name;

			set
			{
				_name = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
			}
		}
		public string _group;
		public string Group 
		{
			get => _group;

			set
			{
				_group = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Group"));
			}
		}
		private int _age;
		public int Age 
		{
			get => _age;

			set
			{
				_age = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
			}
		}
		public float _avg;
		public float Avg 
		{
			get => _avg;

			set
			{
				_avg = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Avg"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Clone(Schooler schooler)
		{
			Name = schooler.Name;
			Group = schooler.Group;
			Age = schooler.Age;
			Avg = schooler.Avg;
		}
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
