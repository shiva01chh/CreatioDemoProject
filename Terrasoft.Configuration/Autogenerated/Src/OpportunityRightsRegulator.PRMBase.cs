namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.AsyncOperations;
	using Terrasoft.Core.Entities.AsyncOperations.Interfaces;
	using Terrasoft.Core.Factories;

	#region Class: OpportunityRightsRegulator

	/// <summary>
	/// Class which executes operation for changing rights on opportunity. 
	/// </summary>
	public class OpportunityRightsAsyncRegulator : IEntityEventAsyncOperation
	{

		#region Fields: Private

		private SspEntityRightsRegulator _rightsRegulator;

		#endregion

		#region Methods: Private

		private void ManageOpportunityOrganizationRights(EntityEventAsyncOperationArgs arguments) {
			_rightsRegulator.ManageEntityOrganizationRights(arguments.EntityId,
				arguments.EntityColumnValues.GetTypedValue<Guid>("PartnerId"),
				arguments.OldEntityColumnValues.GetTypedValue<Guid>("PartnerId"));
		}

		private void ManageOpportunityOwnerRights(EntityEventAsyncOperationArgs arguments) {
			_rightsRegulator.ManageEntityOwnerRights(
				arguments.EntityId,
				arguments.EntityColumnValues.GetTypedValue<Guid>("OwnerId"),
				arguments.OldEntityColumnValues.GetTypedValue<Guid>("OwnerId")); ;
		}
		#endregion

		#region Methods: Public

		public void Execute(UserConnection userConnection, EntityEventAsyncOperationArgs arguments) {
			_rightsRegulator = ClassFactory.Get<SspEntityRightsRegulator>(
				new ConstructorArgument("userConnection", userConnection), 
				new ConstructorArgument("entitySchemaName", arguments.EntitySchemaName));
			ManageOpportunityOrganizationRights(arguments);
			ManageOpportunityOwnerRights(arguments);
		}

		#endregion

	}

	#endregion

}






