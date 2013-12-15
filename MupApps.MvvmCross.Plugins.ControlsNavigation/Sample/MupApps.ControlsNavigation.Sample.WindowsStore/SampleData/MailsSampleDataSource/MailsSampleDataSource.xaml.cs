// MailsSampleDataSource.xaml.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

namespace Blend.SampleData.MailsSampleDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class MailsSampleDataSource { }
#else

	public class MailsSampleDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public MailsSampleDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/MailsSampleDataSource/MailsSampleDataSource.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Mails _Mails = new Mails();

		public Mails Mails
		{
			get
			{
				return this._Mails;
			}
		}

		private Folder _Folder = new Folder();

		public Folder Folder
		{
			get
			{
				return this._Folder;
			}

			set
			{
				if (this._Folder != value)
				{
					this._Folder = value;
					this.OnPropertyChanged("Folder");
				}
			}
		}
	}

	public class Mails : System.Collections.ObjectModel.ObservableCollection<MailsItem>
	{ 
	}

	public class MailsItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _From = string.Empty;

		public string From
		{
			get
			{
				return this._From;
			}

			set
			{
				if (this._From != value)
				{
					this._From = value;
					this.OnPropertyChanged("From");
				}
			}
		}

		private string _To = string.Empty;

		public string To
		{
			get
			{
				return this._To;
			}

			set
			{
				if (this._To != value)
				{
					this._To = value;
					this.OnPropertyChanged("To");
				}
			}
		}

		private string _Date = string.Empty;

		public string Date
		{
			get
			{
				return this._Date;
			}

			set
			{
				if (this._Date != value)
				{
					this._Date = value;
					this.OnPropertyChanged("Date");
				}
			}
		}

		private string _Subject = string.Empty;

		public string Subject
		{
			get
			{
				return this._Subject;
			}

			set
			{
				if (this._Subject != value)
				{
					this._Subject = value;
					this.OnPropertyChanged("Subject");
				}
			}
		}
	}

	public class Folder : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
	}
#endif
}
