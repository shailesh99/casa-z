using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;


namespace casaz
{
	public class BetterViewModel : INotifyPropertyChanged
	{
		private String _greeting;
	
		public String Name { get; set; }

		public ICommand SayHelloCommand {get; set;}

		public String Greeting 
		{
			get { return _greeting; }

			set 
			{
				_greeting = value;
				onPropertyChange ("Greeting");
			}
		}

		public BetterViewModel ()
		{
			Greeting = "Welcome to Xamarin forms from MVVM!";
			Name = "Enter Name";
			SayHelloCommand = new Command (SayHello);
		}

		public void SayHello()
		{
			Greeting = "Hello " + Name;
		}

		#region INPC
		public void onPropertyChange (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

	}
}

