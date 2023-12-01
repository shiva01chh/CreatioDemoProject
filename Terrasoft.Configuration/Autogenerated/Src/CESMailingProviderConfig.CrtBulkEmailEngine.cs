namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Configuration.CES;

	#region class: CESMailingProviderConfig

	/// <summary>
	/// Provides config of the mailing provider.
	/// </summary>
	public class CESMailingProviderConfig : IMailingProviderConfig
	{

		#region Properties: Public

		/// <summary>
		/// Instance of the <see cref="IMailingTemplateFactory"/>.
		/// </summary>
		public IMailingTemplateFactory TemplateFactory {
			get;
			set;

		}

		/// <summary>
		/// Instance of the <see cref="ICESApi"/>.
		/// </summary>
		public ICESApi ServiceApi {
			get;
			set;
		}

		#endregion

	}

	#endregion

}





