namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelChatCloserSchema

	/// <exclude/>
	public class OmnichannelChatCloserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelChatCloserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelChatCloserSchema(OmnichannelChatCloserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("495695b8-7d6f-4949-94fd-1777698ef8a2");
			Name = "OmnichannelChatCloser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,79,194,64,16,61,215,132,255,48,129,11,38,166,189,43,224,161,42,209,196,72,252,56,155,165,12,176,164,221,109,102,182,8,49,254,119,167,91,172,109,37,134,158,102,102,247,189,121,51,111,107,84,134,156,171,4,225,21,137,20,219,165,11,99,107,150,122,85,144,114,218,154,240,41,51,58,89,43,99,48,13,31,145,89,173,180,89,245,206,62,123,103,65,193,18,66,108,9,175,234,236,101,207,14,51,225,72,83,76,74,2,14,167,104,144,116,34,119,228,214,128,112,37,85,136,83,197,12,151,208,160,143,215,202,197,169,101,36,127,51,138,34,24,113,145,101,138,246,147,67,254,140,57,33,163,113,12,170,11,133,10,11,27,59,15,127,224,81,3,159,23,243,84,39,144,248,198,71,219,138,156,251,7,59,191,221,97,82,56,43,42,130,114,202,90,242,157,198,116,81,106,158,145,222,42,135,94,101,144,87,9,148,52,34,207,178,22,232,30,222,169,142,171,193,131,1,154,69,197,116,200,15,180,143,232,214,246,100,222,41,186,118,101,248,38,202,197,50,83,173,27,138,86,122,14,126,132,128,208,21,100,154,170,224,250,26,134,205,124,12,6,63,58,237,134,29,182,243,210,232,224,235,228,129,252,202,171,211,174,157,190,224,247,254,199,200,143,53,26,208,14,52,131,211,25,134,53,60,234,226,71,185,34,149,129,145,87,60,238,183,181,246,39,229,98,32,169,11,225,40,242,183,143,131,125,140,14,137,251,147,89,29,183,48,135,7,180,213,228,10,149,194,214,234,5,84,111,5,255,55,225,2,238,111,180,143,68,251,136,29,201,143,114,1,118,190,145,227,9,252,118,254,49,107,171,68,119,219,246,241,17,227,59,222,120,107,130,54,46,244,11,190,221,229,154,112,81,194,121,248,159,133,85,181,93,148,90,243,251,6,141,140,117,105,49,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("495695b8-7d6f-4949-94fd-1777698ef8a2"));
		}

		#endregion

	}

	#endregion

}

