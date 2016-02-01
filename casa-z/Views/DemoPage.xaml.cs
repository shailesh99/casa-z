using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace casaz
{
	public partial class DemoPage : ContentPage
	{
		public DemoPage ()
		{
			InitializeComponent ();
		}

		private void StartButton_OnClicked(object sender, EventArgs e)
		{
			var name = StartEntry.Text;
			var greeting = "Hello " + name;
			StartLabel.Text = greeting;
		}
	}
}

