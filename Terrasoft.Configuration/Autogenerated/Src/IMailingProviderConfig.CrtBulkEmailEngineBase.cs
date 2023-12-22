namespace Terrasoft.Configuration
{
	using System;

	#region Interface: IMailingProviderConfig

	/// <summary>
	/// Provides config of the mailing provider.
	/// </summary>
	public interface IMailingProviderConfig
	{

		#region Properties: Public

		/// <summary>
		/// Instance of the <see cref="IMailingTemplateFactory"/>.
		/// </summary>
		IMailingTemplateFactory TemplateFactory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}














