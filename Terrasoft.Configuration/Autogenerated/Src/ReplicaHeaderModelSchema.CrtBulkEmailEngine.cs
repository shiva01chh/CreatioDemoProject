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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,203,106,195,48,16,69,215,49,248,31,6,178,183,247,113,233,38,45,73,23,161,161,205,15,40,214,216,17,209,195,204,72,139,16,250,239,29,219,113,112,75,232,162,66,32,230,117,239,25,121,229,144,59,85,35,28,144,72,113,104,98,177,14,190,49,109,34,21,77,240,121,118,205,179,69,98,227,91,248,188,112,68,87,73,44,119,73,216,74,29,214,86,49,175,224,3,59,107,106,181,69,165,145,118,65,163,205,51,233,42,203,18,158,56,57,167,232,242,124,139,165,149,144,209,71,134,151,195,59,132,6,78,195,20,67,19,8,226,9,225,152,236,25,208,41,99,65,12,59,171,34,2,141,6,197,36,90,206,84,187,116,148,26,212,61,202,3,18,88,193,107,47,246,3,110,113,29,0,239,123,236,41,116,72,209,160,44,179,31,244,198,250,239,13,134,196,6,5,94,96,185,127,123,226,27,29,56,197,231,226,62,54,103,156,32,141,143,19,226,78,154,225,10,45,198,170,87,170,224,235,63,150,70,203,87,154,198,32,253,109,188,73,70,79,206,111,250,145,239,18,189,30,127,99,136,199,236,60,41,25,57,223,93,46,219,50,52,2,0,0 };
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

