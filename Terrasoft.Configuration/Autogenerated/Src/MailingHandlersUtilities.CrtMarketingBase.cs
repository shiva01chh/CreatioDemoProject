namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core.Factories;


	#region Class: MailingHandlersUtilities
	/// <summary>
	/// Utilities for interaction with mailing handlers.
	/// </summary>
	public static class MailingHandlersUtilities
	{

		#region Constants: Private

		private const string LogPattern = "MailingHandlersUtilities.{0}";

		#endregion

		#region Methods: Private

		private static string GetFormattedMessage(string message, IMailingHandler handler) {
			string typeName = handler.GetType().Name;
			return GetFormattedMessage(message, typeName);
		}

		private static string GetFormattedMessage(string message, string typeName) {
			message = string.Format(message, typeName);
			return string.Format(LogPattern, message);
		}

		private static void LogError(string message, IMailingHandler handler, Exception exception = null) {
			message = GetFormattedMessage(message, handler);
			LogError(message, exception);
		}

		private static void LogError(string message, string typeName, Exception exception = null) {
			message = GetFormattedMessage(message, typeName);
			LogError(message, exception);
		}

		private static void LogError(string message, Exception exception = null) {
			if (exception == null) {
				MailingUtilities.Log.Error(message);
			} else {
				MailingUtilities.Log.Error(message, exception);
			}
		}

		private static void LogInfo(string message, IMailingHandler handler) {
			message = GetFormattedMessage(message, handler);
			MailingUtilities.Log.Info(message);
		}

		private static EntityCollection GetMailingHandlers(UserConnection userConnection) {
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysMailingHandler");
			esq.AddColumn("Name");
			esq.AddColumn("ClassName");
			var collection = esq.GetEntityCollection(userConnection);
			return collection;
		}
		
		private static void ActivateHandlers(IEnumerable<IMailingHandler> handlers, UserConnection userConnection) {
			foreach(var handler in handlers) {
				try {
					handler.CreateInstance(userConnection);
					LogInfo("Instance of {0} created.", handler);
				} catch (Exception e) {
					LogError("ActivateHandlers. Creating instance of {0} fails.", handler, e);
				}
			}
		}
		
		private static IEnumerable<IMailingHandler> InstantiateHandlers(IEnumerable<string> handlersClassNames) {
			List<IMailingHandler> handlers = new List<IMailingHandler>();
			foreach(string className in handlersClassNames) {
				var workspaceTypeProvider = ClassFactory.Get<IWorkspaceTypeProvider>();
				Type classType = workspaceTypeProvider.GetType(className);
				if (classType != null) {
					try {
						var mailingHandler = Activator.CreateInstance(classType) as IMailingHandler;
						handlers.Add(mailingHandler);
					} catch (Exception e) {
						LogError("InstantiateHandlers. Failed to create instance of {0}.", className, e);
					}
				}
			}
			return handlers;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Enables handlers of the active mailing provider.
		/// </summary>
		/// <param name="userConnection">Instance of user connection.</param>
		public static void EnableActiveProviderHandlers(UserConnection userConnection) {
			EntityCollection mailingHandlers = GetMailingHandlers(userConnection);
			IEnumerable<string> activeHandlersNames =
				mailingHandlers.Select(_ => _.GetTypedColumnValue<string>("ClassName")).Distinct();
			IEnumerable<IMailingHandler> activeHandlers = InstantiateHandlers(activeHandlersNames);
			ActivateHandlers(activeHandlers, userConnection);
		}



		#endregion

	}

	#endregion

}














