﻿namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.AsyncOperations;
	using Terrasoft.Core.Entities.AsyncOperations.Interfaces;

	#region Class: EntityProcessElementDataAsyncOwner

	/// <summary>
	/// Class wich executes operation for changing owner of entity process elements data. 
	/// </summary>
	public class EntityProcessElementDataOwnerAsyncExecutor : IEntityEventAsyncOperation
	{

		#region Methods: Public

		/// <summary>
		/// <see cref="IEntityEventAsyncOperation.Execute"/>
		/// <remarks>Executes operation by changing process elements data owner.</remarks>
		/// </summary>
		public void Execute(UserConnection userConnection, EntityEventAsyncOperationArgs arguments) {
			var operationArgs = (EntityOwnerEventAsyncOperationArgs)arguments;
			var ownerProcessInfo = new SysProcessElementDataOwnerInfo {
				EntityId = operationArgs.EntityId,
				NewOwnerId = operationArgs.EntityColumnValues.GetTypedValue<Guid>(operationArgs.OwnerColumnName),
				OldOwnerId = operationArgs.OldEntityColumnValues.GetTypedValue<Guid>(operationArgs.OwnerColumnName),
			};
			new SysProcessElementDataOwner(userConnection).Change(ownerProcessInfo);
		}

		#endregion

	}

	#endregion

}





