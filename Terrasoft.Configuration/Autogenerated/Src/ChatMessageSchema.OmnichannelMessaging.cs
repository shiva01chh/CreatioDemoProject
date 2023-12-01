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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,93,79,194,48,20,125,150,132,255,112,195,147,190,116,63,64,36,81,48,132,68,212,8,111,198,135,210,93,224,38,107,75,122,59,35,26,255,187,183,27,67,166,100,203,178,220,238,124,244,236,116,78,91,228,157,54,8,75,12,65,179,95,71,53,246,110,77,155,50,232,72,222,169,39,235,200,108,181,115,88,168,57,50,235,13,185,77,191,247,213,239,93,148,44,35,156,16,158,131,127,167,28,3,171,137,183,154,156,186,119,145,34,33,95,31,217,139,61,71,180,127,215,178,103,81,160,73,27,178,154,162,195,64,230,31,231,165,20,55,139,106,33,168,46,232,179,202,39,44,225,101,89,6,67,46,173,213,97,63,58,172,199,133,102,6,227,93,148,36,24,96,237,3,72,206,8,182,250,10,100,213,8,179,19,229,235,68,71,45,13,196,160,77,124,147,23,187,114,85,144,1,83,185,141,69,95,151,128,2,165,14,106,193,28,237,10,195,229,163,180,9,55,48,160,124,112,149,180,141,120,90,82,14,179,188,206,122,86,161,203,184,245,161,173,74,155,165,36,18,4,110,43,188,195,32,53,211,150,115,12,169,188,165,0,93,58,252,136,231,117,2,116,232,114,10,245,121,181,197,135,114,38,13,10,199,169,43,195,126,135,103,109,150,2,64,122,116,53,23,165,160,173,69,23,185,237,241,64,28,135,7,163,219,35,105,4,191,51,119,216,18,223,249,230,168,219,190,43,239,11,152,157,192,233,71,253,238,247,228,150,235,7,193,155,216,199,81,3,0,0 };
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

