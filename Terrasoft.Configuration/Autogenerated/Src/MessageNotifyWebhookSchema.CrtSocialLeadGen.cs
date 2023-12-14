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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,203,78,195,48,16,60,183,18,255,176,42,23,184,164,119,138,184,180,8,21,209,135,84,36,14,136,131,227,108,18,131,99,71,94,71,85,168,248,119,236,196,125,69,5,74,15,145,186,153,157,153,157,221,40,86,32,149,140,35,60,163,49,140,116,106,163,177,86,169,200,42,195,172,208,42,90,105,46,152,124,66,150,60,160,186,232,111,46,250,189,138,132,202,96,142,107,171,85,211,241,72,90,141,118,47,86,53,89,44,28,141,148,200,61,7,69,174,21,141,224,14,227,80,151,6,51,87,133,177,100,68,55,240,130,113,174,245,199,146,25,66,211,0,134,195,33,220,82,85,20,204,212,119,225,255,12,137,88,134,160,180,21,105,13,235,182,41,218,162,135,7,240,87,111,103,17,191,59,241,171,25,22,49,154,149,19,103,82,124,182,19,45,74,59,85,215,111,14,89,86,177,20,28,184,55,178,85,152,55,2,193,148,195,108,26,75,93,211,1,220,190,235,250,109,10,19,36,110,68,140,4,62,20,137,80,132,9,82,109,194,20,209,174,249,208,254,73,87,190,238,163,63,33,118,20,15,215,9,194,58,23,60,135,100,103,96,157,51,11,57,43,75,116,171,216,147,28,137,182,169,45,141,46,209,216,250,106,224,137,6,77,72,59,67,100,141,95,239,216,75,108,32,67,59,2,242,143,175,54,133,63,156,217,186,196,115,197,61,182,35,46,148,133,103,87,254,135,242,4,45,19,18,147,144,68,233,151,15,58,221,46,226,92,51,7,221,167,3,153,28,208,119,220,245,122,193,226,37,170,164,189,160,227,115,10,50,2,221,77,45,27,214,95,78,42,68,73,110,203,219,79,235,135,19,234,140,16,38,166,224,63,216,159,222,171,170,64,195,98,137,183,129,250,110,175,113,34,231,206,16,109,245,184,232,106,254,247,13,182,227,4,205,87,4,0,0 };
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

