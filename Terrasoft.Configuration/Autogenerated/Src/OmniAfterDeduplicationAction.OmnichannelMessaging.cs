﻿using Terrasoft.Configuration.Deduplication;
using Terrasoft.Configuration.Omnichannel.Messaging;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

#region Class: OmniAfterDeduplicationAction

public class OmniAfterDeduplicationAction : IAfterDeduplicationAction
{

	#region Properties: Public

	public UserConnection UserConnection {
		get; private set;
	}

	#endregion


	#region Constructors: Public

	public OmniAfterDeduplicationAction(UserConnection userConnection) {
		UserConnection = userConnection;
	}

	#endregion


	#region Methods: Public

	/// <summary>
	/// Deduplication complete handler.
	/// </summary>
	/// <param name="mergedEntity">Merged result entity.</param>
	public void Execute(Entity mergedEntity) {
		if (mergedEntity.SchemaName != "Contact") {
			return;
		}
		OmnichannelContactIdentifier.FlushContactsCache(UserConnection);
	}

	#endregion

}

#endregion













