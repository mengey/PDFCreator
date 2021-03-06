using pdfforge.DataStorage.Storage;
using pdfforge.DataStorage;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System;

// ! This file is generated automatically.
// ! Do not edit it outside the sections for custom code.
// ! These changes will be deleted during the next generation run

namespace pdfforge.PDFCreator.Conversion.Settings
{
	[ImplementPropertyChanged]
	public partial class HttpAccount : INotifyPropertyChanged {
		#pragma warning disable 67
		public event PropertyChangedEventHandler PropertyChanged;
		#pragma warning restore 67
		
		
		public string AccountId { get; set; } = "";
		
		/// <summary>
		/// If true, basic authenification with user-.name and password is used
		/// </summary>
		public bool IsBasicAuthentication { get; set; } = false;
		
		/// <summary>
		/// Password that is used to authenticate at the server
		/// </summary>
		private string _password = "";
		public string Password { get { try { return Data.Decrypt(_password); } catch { return ""; } } set { _password = Data.Encrypt(value); } }
		
		/// <summary>
		/// HTTP upload Url
		/// </summary>
		public string Url { get; set; } = "";
		
		/// <summary>
		/// User-name that is used to authenticate at the server
		/// </summary>
		public string UserName { get; set; } = "";
		
		
		public void ReadValues(Data data, string path) {
			try { AccountId = Data.UnescapeString(data.GetValue(@"" + path + @"AccountId")); } catch { AccountId = "";}
			try { IsBasicAuthentication = bool.Parse(data.GetValue(@"" + path + @"IsBasicAuthentication")); } catch { IsBasicAuthentication = false;}
			_password = data.GetValue(@"" + path + @"Password");
			try { Url = Data.UnescapeString(data.GetValue(@"" + path + @"Url")); } catch { Url = "";}
			try { UserName = Data.UnescapeString(data.GetValue(@"" + path + @"UserName")); } catch { UserName = "";}
		}
		
		
		public void StoreValues(Data data, string path) {
			data.SetValue(@"" + path + @"AccountId", Data.EscapeString(AccountId));
			data.SetValue(@"" + path + @"IsBasicAuthentication", IsBasicAuthentication.ToString());
			data.SetValue(@"" + path + @"Password", _password);
			data.SetValue(@"" + path + @"Url", Data.EscapeString(Url));
			data.SetValue(@"" + path + @"UserName", Data.EscapeString(UserName));
		}
		
		public HttpAccount Copy()
		{
			HttpAccount copy = new HttpAccount();
			
			copy.AccountId = AccountId;
			copy.IsBasicAuthentication = IsBasicAuthentication;
			copy.Password = Password;
			copy.Url = Url;
			copy.UserName = UserName;
			
			return copy;
		}
		
		public override bool Equals(object o)
		{
			if (!(o is HttpAccount)) return false;
			HttpAccount v = o as HttpAccount;
			
			if (!AccountId.Equals(v.AccountId)) return false;
			if (!IsBasicAuthentication.Equals(v.IsBasicAuthentication)) return false;
			if (!Password.Equals(v.Password)) return false;
			if (!Url.Equals(v.Url)) return false;
			if (!UserName.Equals(v.UserName)) return false;
			
			return true;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine("AccountId=" + AccountId.ToString());
			sb.AppendLine("IsBasicAuthentication=" + IsBasicAuthentication.ToString());
			sb.AppendLine("Password=" + Password.ToString());
			sb.AppendLine("Url=" + Url.ToString());
			sb.AppendLine("UserName=" + UserName.ToString());
			
			return sb.ToString();
		}
		
		public override int GetHashCode()
		{
			// ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
			return base.GetHashCode();
		}
		
// Custom Code starts here
// START_CUSTOM_SECTION:GENERAL
// END_CUSTOM_SECTION:GENERAL
// Custom Code ends here. Do not edit below
		
	}
}
