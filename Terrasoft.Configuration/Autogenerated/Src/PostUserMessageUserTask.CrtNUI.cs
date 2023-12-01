namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: PostUserMessageUserTask

	/// <exclude/>
	public partial class PostUserMessageUserTask
	{
		#region Methods: Private
			
		private List<Guid> GetTargetIds() {
			if (!TargetUserId.IsEmpty()) {
				return new List<Guid>{TargetUserId};
			}
			if (!TargetUserIdsKey.IsNullOrEmpty()) {
				return UserConnection.SessionData[TargetUserIdsKey] as List<Guid>;
			}
			return null;
		}
		
		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			MsgChannelManager channelManager = MsgChannelManager.Instance;
			if (!SendForAll) {
				List<Guid> targetIds = GetTargetIds();
				if (targetIds != null) {
					foreach(Guid id in targetIds) {	
						IMsgChannel userChannel = channelManager.FindItemByUId(id);
						PostMsgText(userChannel);
					}
				}
			} else {
				foreach(IMsgChannel userChannel in channelManager.Channels.Values) {
					PostMsgText(userChannel);
				}
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public virtual void PostMsgText(IMsgChannel userChannel) {
			IMsg msg = new SimpleMessage() {
				Id = Guid.NewGuid(),
				Body = MessageText
			};
			msg.Header.Sender = SenderName;
			userChannel.PostMessage(msg);
		}
		
		#endregion

	}

	#endregion

}

