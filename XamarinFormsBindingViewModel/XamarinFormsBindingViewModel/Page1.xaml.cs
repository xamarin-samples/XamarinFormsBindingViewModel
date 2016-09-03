using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsBindingViewModel
{
	
	public partial class Page1 : ContentPage
	{
		MyViewModel m_model = new MyViewModel();

		public Page1()
		{
			InitializeComponent();

			// Bind MyViewModel
			m_model = new MyViewModel();
			this.BindingContext = m_model;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			// Change binding value
			m_model.MainText = "<" + m_model.MainText + ">";
		}
	}
}
