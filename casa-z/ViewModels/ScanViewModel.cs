using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing.Mobile;

namespace casaz
{
	public class ScanViewModel : INotifyPropertyChanged
	{
		public String _ScannedText;
		public ICommand ScanCommand {get; set;}

		public ScanViewModel ()
		{
			ScannedText = "Welcome to Scan View";
			ScanCommand = new Command (OnScanCommand);
		}

		public String ScannedText {
			get { return _ScannedText;}
			set
			{
				_ScannedText = value;
				onPropertyChange ("ScannedText");
			}
		}

		public async void OnScanCommand()
		{
			var scanner = new ZXing.Mobile.MobileBarcodeScanner();
			var result = await scanner.Scan();
			if (result != null)
				ScannedText = result.Text;
			else
				ScannedText = "NULL";
		}

		#region INotifyPropertyChanged implementation
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

