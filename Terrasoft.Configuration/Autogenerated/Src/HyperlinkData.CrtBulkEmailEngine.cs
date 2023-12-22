namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	
	#region Class: HyperlinkData

	/// <summary>
	/// Represents hyperlink data to save into database.
	/// </summary>
	public class HyperlinkData
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// Gets or sets the url caption.
		/// </summary>
		public string Caption { get; set; }

		/// <summary>
		/// Gets or sets the additional columns dictionary (column name, value).
		/// </summary>
		public Dictionary<string, object> AdditionalColumns { get; set; }

		#endregion

	}

	#endregion
}













