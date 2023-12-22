namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatMessageSchema

	/// <exclude/>
	public class ChatMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatMessageSchema(ChatMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21c9a1d7-90b7-429c-ad25-dd578ea023a7");
			Name = "ChatMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,93,79,194,48,20,125,150,132,255,112,195,147,190,116,63,64,36,81,48,132,68,212,8,111,198,135,210,93,160,201,218,146,222,59,35,26,255,187,183,131,225,166,100,203,178,220,238,124,244,236,116,94,59,164,157,54,8,75,140,81,83,88,179,26,7,191,182,155,50,106,182,193,171,39,231,173,217,106,239,177,80,115,36,210,27,235,55,253,222,87,191,119,81,146,140,208,32,60,199,240,110,115,140,164,38,193,105,235,213,189,103,203,22,233,250,196,94,236,137,209,253,93,203,158,69,129,38,109,72,106,138,30,163,53,255,56,47,165,184,57,84,11,65,117,97,63,171,124,194,18,94,150,101,48,164,210,57,29,247,163,227,122,92,104,34,48,193,179,36,193,8,235,16,65,114,50,184,234,43,144,84,45,204,26,202,215,137,102,45,13,112,212,134,223,228,197,174,92,21,214,128,169,220,198,162,63,148,128,2,165,14,14,130,57,186,21,198,203,71,105,19,110,96,96,243,193,85,210,214,226,105,105,115,152,229,135,172,103,21,186,228,109,136,109,85,218,44,37,145,32,112,91,225,29,6,169,153,182,156,56,166,242,150,2,116,233,240,131,207,235,4,232,208,229,54,30,206,171,45,62,150,51,169,81,56,77,93,25,246,59,60,107,179,20,0,210,163,171,57,150,130,182,14,61,83,219,227,193,18,15,143,70,183,39,210,8,126,103,234,176,181,116,23,234,163,110,251,174,66,40,96,214,128,211,143,250,221,239,201,221,188,126,0,213,94,59,156,90,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21c9a1d7-90b7-429c-ad25-dd578ea023a7"));
		}

		#endregion

	}

	#endregion

}

