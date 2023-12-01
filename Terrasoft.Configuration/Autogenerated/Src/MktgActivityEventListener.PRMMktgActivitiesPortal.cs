﻿namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.AsyncOperations;
	using Terrasoft.Core.Entities.AsyncOperations.Interfaces;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;

	#region Class: MktgActivityEventListener

	/// <summary>
	/// Listener for MktgActivity entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "MktgActivity")]
	public class MktgActivityEventListener : BaseEntityEventListener
	{

		#region Methods: Public

		/// <summary>
		/// Handles entity Saved event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
		/// event data.</param>
		public override void OnSaved(object sender, EntityAfterEventArgs e) {
			base.OnSaved(sender, e);
			UserConnection userConnection = ((Entity)sender).UserConnection;
			IEntityEventAsyncExecutor asyncExecutor = ClassFactory.Get<IEntityEventAsyncExecutor>(new ConstructorArgument("userConnection", userConnection));
			EntityEventAsyncOperationArgs operationArgs = new EntityEventAsyncOperationArgs((Entity)sender, e);
			asyncExecutor.ExecuteAsync<MktgActivityRightsRegulator>(operationArgs);
		}

		#endregion

	}

	#endregion

}





