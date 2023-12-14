namespace Terrasoft.Configuration.BpmonlineCloudIntegration
{
	using System;
	using System.Net.Http;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Services;
	using CoreConfig = Core.Configuration;

	#region Class: IdentityServerProvider

	/// <summary>
	/// Class to work with IdentityServer.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.Tracking.IIdentityServerProvider" />
	[DefaultBinding(typeof(IdentityServerProvider))]
	public class IdentityServerProvider
	{

		#region Constants: Private

		private const string _identityAddressSettingsName = "IdentityServerUrl";
		private const string _clientIdSettingsName = "IdentityServerClientId";
		private const string _clientSecretSettingsName = "IdentityServerClientSecret";
		private const string _invalidClient = "invalid_client";
		private const string _invalidScope = "invalid_scope";
		private const string _identityInvalidGeneralCode = "identity_general_error";

		#endregion

		#region Fields: Private

		private readonly string _serverUrl;
		private readonly string _clientId;
		private readonly string _clientSecret;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="IdentityServerProvider"/> class.
		/// </summary>
		/// <param name="userConnection">User connection parameters.</param>
		public IdentityServerProvider(UserConnection userConnection) {
			(_serverUrl, _clientId, _clientSecret) = GetConnectionParams(userConnection);
		}

		#endregion

		#region Methods: Private

		private (string serverAddress, string clientId, string clientSecret) GetConnectionParams(UserConnection userConnection) {
			var serverAddress = CoreConfig.SysSettings.GetValue(userConnection, _identityAddressSettingsName, "");
			var clientId = CoreConfig.SysSettings.GetValue(userConnection, _clientIdSettingsName, "");
			var clientSecret = CoreConfig.SysSettings.GetValue(userConnection, _clientSecretSettingsName, "");
			return (serverAddress, clientId, clientSecret);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Get access token from identity server for scope without exception handling
		/// </summary>
		/// <param name="scope">Scope to get access token</param>
		/// <returns>access token</returns>
		public string GetAccessToken(string scope) {
			var settingsProvider = new IdentityServiceSettingsProvider(_serverUrl, _clientId, _clientSecret);
			IIdentityClient identityClient = ClassFactory.Get<IIdentityClient>(
				new ConstructorArgument("settingsProvider", settingsProvider));
			var token = identityClient.RequestClientCredentialsToken(scope);			
			return token;
		}

		/// <summary>
		/// Get access token from identity server for scope with exception handling
		/// </summary>
		/// <param name="scope">Scope to get access token</param>
		/// <exception cref="RequestTokenException">Throws with error code 'invalid_scope' when <paramref name="scope"/> is invalid.</exception>		
		/// <exception cref="RequestTokenException">Throws with error code 'invalid_client' when client credentials is invalid.</exception>
		/// /// <exception cref="RequestTokenException">Throws with error code 'identity_general_error' when unknown error raised.</exception>
		/// <exception cref="InvalidIdentityServerSettingsException">Exception thrown when identity server settings is empty.</exception>		
		/// <returns>access token</returns>
		public string GetAccessTokenWithExceptionHandle(string scope) {
			if (string.IsNullOrWhiteSpace(_serverUrl) 
				|| string.IsNullOrWhiteSpace(_clientId) 
				|| string.IsNullOrWhiteSpace(_clientSecret)) {
				throw new InvalidIdentityServerSettingsException();
			}			
			try {
				var token = GetAccessToken(scope);
				return token;
			} catch (Exception ex) when (ex.Message.Contains(_invalidClient)) {
				throw new RequestTokenException { ErrorCode = _invalidClient };
			} catch (Exception ex) when (ex.Message.Contains(_invalidScope)) {
				throw new RequestTokenException { ErrorCode = _invalidScope };
			} catch (Exception ex) {
				throw new RequestTokenException(ex.Message, ex) { ErrorCode = _identityInvalidGeneralCode };
			}
		}

		#endregion

	}

	#endregion
}





