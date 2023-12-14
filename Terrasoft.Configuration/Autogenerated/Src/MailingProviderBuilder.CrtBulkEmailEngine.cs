namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Core.Factories;
	using System.Reflection;

	#region Class: MailingProviderBuilder

	[DefaultBinding(typeof(IMailingProviderBuilder))]
	public class MailingProviderBuilder : IMailingProviderBuilder
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public MailingProviderBuilder(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private IMailingProviderConfigFactory CreateConfigFactory(string factoryClassName) {
			if (string.IsNullOrEmpty(factoryClassName)) {
				return null;
			}
			var workspaceTypeProvider = ClassFactory.Get<IWorkspaceTypeProvider>();
			Type factoryType = workspaceTypeProvider.GetType(factoryClassName);
			if (factoryType == null) {
				return null;
			}
			return Activator.CreateInstance(factoryType) as IMailingProviderConfigFactory;
		}

		private IMailingProvider CreateProviderInstance(Type providerType,
			IMailingProviderConfigFactory configFactory) {
			IMailingProvider mailingProvider = null;
			ConstructorInfo configurableConstructor = providerType.GetConstructor(new[] {
				typeof(UserConnection), typeof(IMailingProviderConfigFactory)
			});
			if (configurableConstructor != null) {
				mailingProvider =
					Activator.CreateInstance(providerType, _userConnection, configFactory) as IMailingProvider;
			} else {
				ConstructorInfo simpleConstructor = providerType.GetConstructor(new[] { typeof(UserConnection) });
				if (simpleConstructor != null) {
					mailingProvider = Activator.CreateInstance(providerType, _userConnection) as IMailingProvider;
				} else {
					mailingProvider = Activator.CreateInstance(providerType) as IMailingProvider;
					mailingProvider.UserConnection = _userConnection;
				}
			}
			return mailingProvider;
		}

		private SysMailingProvider GetProvider(UserConnection userConnection, Guid providerId) {
			var provider = new SysMailingProvider(userConnection);
			if (!provider.FetchFromDB(providerId)) {
				return null;
			}
			return provider;
		}

		#endregion

		#region Methods: Public

		public IMailingProvider Build() {
			IMailingProvider mailingProvider;
			Guid providerId = MailingUtilities.GetActiveProviderId(_userConnection);
			SysMailingProvider provider = GetProvider(_userConnection, providerId);
			if (provider == null) {
				string msg = $"Could not load provider data from DB. Provider UId: {providerId}";
				throw new Exception(msg);
			}
			var providerType = Type.GetType(provider.ClassName);
			if (providerType != null) {
				IMailingProviderConfigFactory configFactory = CreateConfigFactory(provider.ConfigFactoryClassName);
				mailingProvider = CreateProviderInstance(providerType, configFactory);
				var configurableProvider = mailingProvider as IConfigurableMailingProvider;
				if (configurableProvider != null) {
					configurableProvider.Configure();
				}
			} else {
				string msg = $"Could not initiate provider instance. Provider UId: {providerId}";
				throw new Exception(msg);
			}
			return mailingProvider;
		}

		#endregion

	}

	#endregion

}





