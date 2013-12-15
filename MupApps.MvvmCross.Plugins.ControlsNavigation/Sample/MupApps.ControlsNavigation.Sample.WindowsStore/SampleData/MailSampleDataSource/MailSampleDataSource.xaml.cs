// MailSampleDataSource.xaml.cs
// (c) Copyright Christian Ruiz @_christian_ruiz
// MvvmCross - Controls Navigation Plugin is licensed using Microsoft Public License (Ms-PL)
// 

namespace Blend.SampleData.MailSampleDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class MailSampleDataSource { }
#else

	public class MailSampleDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public MailSampleDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/MailSampleDataSource/MailSampleDataSource.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Mail _Mail = new Mail();

		public Mail Mail
		{
			get
			{
				return this._Mail;
			}

			set
			{
				if (this._Mail != value)
				{
					this._Mail = value;
					this.OnPropertyChanged("Mail");
				}
			}
		}
	}

	public class Mail : INotifyPropertyChanged
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

		private string _Body = string.Empty;

		public string Body
		{
			get
			{
				return this._Body;
			}

			set
			{
				if (this._Body != value)
				{
					this._Body = value;
					this.OnPropertyChanged("Body");
				}
			}
		}
	}
#endif
}
