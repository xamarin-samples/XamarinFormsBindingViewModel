using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsBindingViewModel
{
	public class MyViewModel : INotifyPropertyChanged
	{
		private string mainText = "World";
		public string MainText
		{
			get
			{
				return mainText;
			}
			set
			{
				mainText = value;
				OnPropertyChanged("MainText");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string name)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}
