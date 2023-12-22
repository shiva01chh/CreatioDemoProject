namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: CESMailingProviderConfigFactory

	/// <summary>
	/// Provides methods for creating instancies of the <see cref="IMailingProviderConfig"/>.
	/// </summary>
	public class CESMailingProviderConfigFactory : IMailingProviderConfigFactory
	{

		#region Methods: Public

		/// <summary>
		/// Creates instance of the <see cref="CESMailingProviderConfig"/>.
		/// </summary>
		/// <param name="userConnection">Instance of <see cref="UserConnection"/>.</param>
		/// <returns>Returns instance of the <see cref="CESMailingProviderConfig"/>.</returns>
		public IMailingProviderConfig CreateInstance(UserConnection userConnection) {
			var engineArgs = new ConstructorArgument("userConnection", userConnection);
			var cloudEngine = ClassFactory.Get<BpmonlineCloudEngine>(engineArgs);
			var config = new CESMailingProviderConfig();
			config.ServiceApi = cloudEngine.ServiceApi;
			
			return config;
		}

		#endregion

	}

	#endregion

}














