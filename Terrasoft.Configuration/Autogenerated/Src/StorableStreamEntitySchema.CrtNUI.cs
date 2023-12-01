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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,193,106,2,49,16,61,43,248,15,83,189,180,151,172,45,148,130,150,130,85,15,189,40,116,45,30,68,202,172,206,46,129,236,102,153,204,22,182,210,127,111,98,92,40,54,135,201,188,151,121,51,111,82,97,73,174,198,3,193,134,152,209,217,92,212,220,86,185,46,26,70,209,182,26,244,79,131,126,175,113,186,42,32,109,157,80,57,189,194,234,109,237,41,79,142,152,10,175,128,185,65,231,38,144,138,101,204,12,165,194,132,229,185,34,73,18,120,118,77,89,34,183,47,23,188,101,172,107,98,200,45,131,59,151,130,88,200,200,3,203,116,84,157,44,249,163,219,165,196,26,141,254,14,253,247,158,168,155,204,232,3,28,194,228,171,193,203,74,180,180,48,129,87,116,212,61,69,210,11,195,114,189,145,206,225,102,181,220,164,155,217,106,49,123,95,60,124,142,207,118,123,187,117,230,172,33,161,219,225,86,27,19,92,49,149,246,139,142,128,185,120,211,79,234,254,81,141,21,124,56,130,5,10,66,205,214,47,35,173,26,222,5,95,157,177,104,165,187,78,80,144,76,193,133,240,19,39,141,168,58,234,60,230,23,77,214,10,237,246,177,237,127,69,140,65,22,127,61,64,207,249,243,11,127,61,134,208,211,1,0,0 };
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

