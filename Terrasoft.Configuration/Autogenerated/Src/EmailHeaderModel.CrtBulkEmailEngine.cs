namespace Terrasoft.Configuration
{
	using System;
	
	#region Class: EmailHeaderModel

	/// <summary>
	/// Represents DTO of headers for the bulk email template.
	/// </summary>
	public class EmailHeaderModel
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets sender name.
		/// </summary>
		public string SenderName { get; set; }

		/// <summary>
		/// Gets or sets sender email.
		/// </summary>
		public string SenderEmail { get; set; }

		/// <summary>
		/// Gets or sets the email subject.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// Gets or sets the email preheader.
		/// </summary>
		public string Preheader { get; set; }

		#endregion

	}

	#endregion
}













