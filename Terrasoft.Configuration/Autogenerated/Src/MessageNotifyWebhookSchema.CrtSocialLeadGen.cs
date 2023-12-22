namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessageNotifyWebhookSchema

	/// <exclude/>
	public class MessageNotifyWebhookSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessageNotifyWebhookSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessageNotifyWebhookSchema(MessageNotifyWebhookSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b64b5e73-bc62-4ff2-a773-7df631ba5e5b");
			Name = "MessageNotifyWebhook";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,77,79,194,64,16,61,67,194,127,152,224,69,47,229,174,196,11,24,163,17,36,193,196,131,241,176,221,78,219,213,237,110,179,179,13,169,196,255,238,110,187,64,105,240,139,67,19,166,111,222,123,243,102,170,88,129,84,50,142,240,132,198,48,210,169,141,102,90,165,34,171,12,179,66,171,104,173,185,96,242,1,89,114,139,106,52,220,142,134,131,138,132,202,96,137,27,171,85,211,113,79,90,93,237,95,172,107,178,88,56,26,41,145,123,14,138,92,43,26,193,29,198,161,206,12,102,174,10,51,201,136,46,225,25,227,92,235,247,21,51,132,166,1,76,38,19,152,82,85,20,204,212,215,225,255,2,137,88,134,160,180,21,105,13,155,182,41,218,161,39,29,248,139,183,243,24,191,57,241,243,5,22,49,154,181,19,103,82,124,180,19,61,150,246,78,93,188,58,100,89,197,82,112,224,222,200,78,97,217,8,4,83,14,179,109,44,245,77,7,112,251,174,239,183,41,204,145,184,17,49,18,248,80,36,66,17,38,72,181,9,83,68,251,230,174,253,147,174,124,221,71,127,66,236,40,30,174,19,132,77,46,120,14,201,222,192,38,103,22,114,86,150,232,86,113,32,57,18,109,83,91,25,93,162,177,245,249,216,19,141,155,144,246,134,200,26,191,222,153,151,216,66,134,246,10,200,63,62,219,20,126,113,102,235,18,255,42,238,177,61,113,161,44,60,185,242,63,148,231,104,153,144,152,132,36,74,191,124,208,233,110,17,127,53,211,233,62,29,200,188,67,223,115,55,24,4,139,103,168,146,246,130,142,207,41,200,8,116,55,181,106,88,127,56,169,16,37,185,45,239,62,173,111,78,168,55,66,152,152,130,255,96,255,238,70,85,5,26,22,75,156,6,234,235,131,198,137,156,123,67,180,213,227,162,171,117,127,95,216,206,108,107,95,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b64b5e73-bc62-4ff2-a773-7df631ba5e5b"));
		}

		#endregion

	}

	#endregion

}

