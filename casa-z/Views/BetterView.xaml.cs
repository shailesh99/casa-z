using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace casaz
{
	public partial class BetterView : ContentPage
	{
		public BetterView ()
		{
			InitializeComponent ();
			this.BindingContext = new BetterViewModel ();
		}
	}
}

