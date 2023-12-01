﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: TouchQueueMessageProcessorLoader

	/// <summary>
	/// Class to loads all available touch queue message processors.
	/// </summary>
	public class TouchQueueMessageProcessorLoader
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of the class.
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		public TouchQueueMessageProcessorLoader(UserConnection userConnection) {
			_userConnection = userConnection;
			InitProcessorTypes();
		}

		#endregion

		#region Fields: Private

		private static readonly object _lockObject = new object();

		private static IEnumerable<Type> _processorTypes;

		private UserConnection _userConnection;

		#endregion

		#region Methods: Private

		private bool HasTouchProcessorAttribute(Type type) {
			return type.GetCustomAttributes(typeof(TouchQueueProcessorAttribute), true)
				.OfType<TouchQueueProcessorAttribute>().Any();
		}

		private IEnumerable<Type> GetProcessorTypes() { 
			var workspaceTypeProvider = ClassFactory.Get<IWorkspaceTypeProvider>();
			var assemblyTypes = workspaceTypeProvider.GetTypes();
			return assemblyTypes.Where(type =>
				type.IsSubclassOf(typeof(BaseTouchQueueMessageProcessor))
					&& HasTouchProcessorAttribute(type));
		}

		private void InitProcessorTypes() {
			if (_processorTypes != null) {
				return;
			}
			lock (_lockObject) {
				if (_processorTypes != null) {
					return;
				}
				var processorTypes = GetProcessorTypes();
				_processorTypes = processorTypes.ToList();
			}
		}

		private BaseTouchQueueMessageProcessor CreateProcessorInstance(Type type) {
			return Activator.CreateInstance(type, _userConnection) as BaseTouchQueueMessageProcessor;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns all available touch queue message processors for current assembly.
		/// </summary>
		/// <returns>List of <see cref="BaseTouchQueueMessageProcessor"/> instances.</returns>
		public virtual IEnumerable<BaseTouchQueueMessageProcessor> GetProcessors() {
			var processors = new List<BaseTouchQueueMessageProcessor>();
			_processorTypes.ForEach(type => {
				var instance = CreateProcessorInstance(type);
				processors.AddIfNotExists(instance);
			});
			return processors;
		}

		#endregion

	}

	#endregion

}




