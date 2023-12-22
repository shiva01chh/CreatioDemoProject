namespace Terrasoft.Configuration
{
	using Terrasoft.Common;
	using Terrasoft.Core;

	#region Class: StringLczHelper

	/// <summary>
	/// Helper for work with localize strings.
	/// </summary>
	public static class StringLczHelper
	{

		#region Methods: Public

		/// <summary>
		/// Get localize string.
		/// </summary>
		/// <param name="lczName">LocalizableStrings parameter  value</param>
		/// <param name="userConnection">User connection service</param>
		/// <param name="resourceManagerName">Name of resource contain object</param>
		/// <returns></returns>
		public static string GetLczStringValue(this string lczName, UserConnection userConnection, string resourceManagerName = nameof(BulkEmailSplitValidator)) {
			var localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(userConnection.Workspace.ResourceStorage,
				resourceManagerName, localizableStringName);
			string value = localizableString.Value ?? localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			return value;
		}

		#endregion

	}

	#endregion

}














