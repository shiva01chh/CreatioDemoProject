namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StorableStreamEntitySchema

	/// <exclude/>
	public class StorableStreamEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StorableStreamEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StorableStreamEntitySchema(StorableStreamEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0a87ec1-0968-41f6-a659-4da5f3e39a17");
			Name = "StorableStreamEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,193,106,2,49,16,61,43,248,15,83,189,180,151,172,45,148,130,150,130,85,15,189,40,116,45,30,68,202,172,206,46,129,236,102,153,204,22,182,210,127,111,98,92,144,54,135,201,188,151,121,51,111,82,97,73,174,198,3,193,134,152,209,217,92,212,220,86,185,46,26,70,209,182,26,244,79,131,126,175,113,186,42,32,109,157,80,57,253,131,213,219,218,83,158,28,49,21,94,1,115,131,206,77,32,21,203,152,25,74,133,9,203,115,69,146,36,240,236,154,178,68,110,95,46,120,203,88,215,196,144,91,6,119,46,5,177,144,145,7,150,233,168,58,89,114,165,219,165,196,26,141,254,14,253,247,158,168,155,204,232,3,28,194,228,63,131,151,149,104,105,97,2,175,232,168,123,138,164,23,134,229,122,35,157,195,205,106,185,73,55,179,213,98,246,190,120,248,28,159,237,246,118,235,204,89,67,66,183,195,173,54,38,184,98,42,237,23,29,1,115,241,166,159,212,253,163,26,43,248,112,4,11,20,132,154,173,95,70,90,53,188,11,190,58,99,209,74,119,157,160,32,153,130,11,225,39,78,26,81,117,212,121,204,47,154,172,21,218,237,99,219,255,138,24,131,44,254,122,128,158,187,62,191,24,11,134,29,220,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0a87ec1-0968-41f6-a659-4da5f3e39a17"));
		}

		#endregion

	}

	#endregion

}

