namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReplicaHeaderModelSchema

	/// <exclude/>
	public class ReplicaHeaderModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReplicaHeaderModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReplicaHeaderModelSchema(ReplicaHeaderModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3621dd38-75e4-442f-bb93-2a3c04ec45c8");
			Name = "ReplicaHeaderModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,77,106,195,48,16,133,215,49,248,14,3,217,219,251,184,116,147,150,164,139,208,208,230,2,138,53,118,68,44,201,204,72,139,16,122,247,142,236,56,184,37,116,81,33,16,243,247,222,55,114,202,34,247,170,70,56,32,145,98,223,132,98,237,93,99,218,72,42,24,239,242,236,154,103,139,200,198,181,240,121,225,128,182,146,88,238,146,176,149,58,172,59,197,188,130,15,236,59,83,171,45,42,141,180,243,26,187,60,147,174,178,44,225,137,163,181,138,46,207,183,88,90,9,25,93,96,120,57,188,131,111,224,52,76,49,52,158,32,156,16,142,177,59,3,90,101,58,16,195,190,83,1,129,70,131,98,18,45,103,170,125,60,74,13,234,132,242,128,4,86,240,154,196,126,192,45,174,3,224,125,143,61,249,30,41,24,148,101,246,131,222,88,255,189,193,144,216,160,192,11,44,167,55,17,223,232,192,42,62,23,247,177,57,227,4,105,92,152,16,119,210,12,87,104,49,84,73,169,130,175,255,88,26,45,95,105,26,131,244,183,241,38,26,61,57,191,233,71,190,75,116,122,252,141,33,30,179,243,164,100,210,249,6,244,240,63,39,53,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3621dd38-75e4-442f-bb93-2a3c04ec45c8"));
		}

		#endregion

	}

	#endregion

}

