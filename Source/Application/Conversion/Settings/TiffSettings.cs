using pdfforge.DataStorage.Storage;
using pdfforge.DataStorage;
using pdfforge.PDFCreator.Conversion.Settings.Enums;
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
	/// <summary>
	/// Settings for the TIFF output format
	/// </summary>
	[ImplementPropertyChanged]
	public partial class TiffSettings : INotifyPropertyChanged {
		#pragma warning disable 67
		public event PropertyChangedEventHandler PropertyChanged;
		#pragma warning restore 67
		
		
		/// <summary>
		/// Number of colors.
		/// </summary>
		public TiffColor Color { get; set; } = TiffColor.Color24Bit;
		
		/// <summary>
		/// Resolution of the TIFF files
		/// </summary>
		public int Dpi { get; set; } = 150;
		
		
		public void ReadValues(Data data, string path)
		{
			try { Color = (TiffColor) Enum.Parse(typeof(TiffColor), data.GetValue(@"" + path + @"Color")); } catch { Color = TiffColor.Color24Bit;}
			try { Dpi = int.Parse(data.GetValue(@"" + path + @"Dpi"), System.Globalization.CultureInfo.InvariantCulture); } catch { Dpi = 150;}
		}
		
		public void StoreValues(Data data, string path)
		{
			data.SetValue(@"" + path + @"Color", Color.ToString());
			data.SetValue(@"" + path + @"Dpi", Dpi.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public TiffSettings Copy()
		{
			TiffSettings copy = new TiffSettings();
			
			copy.Color = Color;
			copy.Dpi = Dpi;
			
			return copy;
		}
		
		public override bool Equals(object o)
		{
			if (!(o is TiffSettings)) return false;
			TiffSettings v = o as TiffSettings;
			
			if (!Color.Equals(v.Color)) return false;
			if (!Dpi.Equals(v.Dpi)) return false;
			
			return true;
		}
		
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.AppendLine("Color=" + Color.ToString());
			sb.AppendLine("Dpi=" + Dpi.ToString());
			
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
		
// Custom Code starts here
// START_CUSTOM_SECTION:INCLUDES

// END_CUSTOM_SECTION:INCLUDES
// Custom Code ends here. Do not edit below
		
	}
}
