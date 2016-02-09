using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace casaz
{
	public partial class ScanView : ContentPage
	{
		public ScanView ()
		{
			InitializeComponent ();
			this.BindingContext = new ScanViewModel ();
		}
	}
}

