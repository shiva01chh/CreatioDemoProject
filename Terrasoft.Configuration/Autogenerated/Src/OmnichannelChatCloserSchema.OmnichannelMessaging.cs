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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,201,106,195,64,12,61,187,144,127,16,201,37,133,98,223,219,44,7,119,161,133,208,208,229,92,38,142,146,76,177,103,140,52,206,66,233,191,87,30,39,110,236,134,18,159,36,205,188,167,39,189,177,81,25,114,174,18,132,55,36,82,108,23,46,140,173,89,232,101,65,202,105,107,194,231,204,232,100,165,140,193,52,156,32,179,90,106,179,236,92,124,117,46,130,130,37,132,216,18,222,212,217,235,142,29,102,194,145,166,152,148,4,28,62,160,65,210,137,220,145,91,61,194,165,84,33,78,21,51,92,195,17,125,188,82,46,78,45,35,249,155,81,20,193,128,139,44,83,180,27,237,243,23,204,9,25,141,99,80,109,40,84,88,248,180,179,240,0,143,142,240,121,49,75,117,2,137,111,124,178,173,200,121,124,178,179,187,45,38,133,179,162,34,40,167,172,37,223,107,76,231,165,230,41,233,181,114,232,85,6,121,149,64,73,35,242,44,107,129,238,224,131,234,184,26,60,232,161,153,87,76,251,124,79,59,65,183,178,103,243,62,160,107,86,250,239,162,92,44,51,213,186,161,104,164,151,224,71,8,8,93,65,230,88,21,140,199,208,63,206,135,96,112,211,106,215,111,177,93,150,70,7,223,103,15,228,87,94,157,182,237,244,5,191,247,63,70,110,86,104,64,59,208,12,78,103,24,214,240,168,141,31,228,138,84,6,70,94,241,176,219,212,218,29,149,139,129,164,46,132,131,200,223,62,13,246,49,58,36,238,142,166,117,220,192,236,31,208,90,147,43,84,10,107,171,231,80,189,21,252,223,132,43,120,188,213,62,18,237,3,118,36,63,202,21,216,217,167,28,143,224,183,243,193,172,181,18,221,77,219,135,39,140,111,121,227,173,9,154,184,208,47,248,110,155,107,194,121,9,231,254,127,22,86,213,102,81,106,229,247,3,234,204,248,10,41,4,0,0 };
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

