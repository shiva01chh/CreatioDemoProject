namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPrimaryImportEntitiesSetterSchema

	/// <exclude/>
	public class IPrimaryImportEntitiesSetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPrimaryImportEntitiesSetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPrimaryImportEntitiesSetterSchema(IPrimaryImportEntitiesSetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f3be9bf-a5b6-4e6a-a262-4785da28353f");
			Name = "IPrimaryImportEntitiesSetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,75,106,132,64,16,134,215,35,120,135,194,85,2,161,61,64,140,155,96,130,204,102,96,114,129,30,83,14,69,236,110,233,199,16,9,185,123,170,237,232,60,8,17,23,118,249,253,15,75,45,21,186,81,118,8,111,104,173,116,166,247,226,217,232,158,142,193,74,79,70,139,23,26,176,85,163,177,62,207,190,242,108,19,28,233,35,236,39,231,81,49,58,12,216,69,206,137,87,212,104,169,123,92,153,75,71,139,162,209,158,60,161,99,128,145,49,28,6,234,128,180,71,219,199,252,118,103,73,73,59,165,172,5,222,163,103,128,249,24,189,41,203,18,42,23,84,228,234,101,192,136,3,252,36,231,99,40,254,10,193,27,160,217,106,29,137,213,162,188,245,168,70,105,165,2,205,219,120,42,230,103,228,88,87,212,169,13,156,71,162,42,231,195,223,210,37,170,168,155,219,66,255,11,63,112,226,93,6,165,89,186,197,9,186,116,184,18,157,12,189,199,175,189,75,165,118,107,167,139,122,15,208,54,58,40,180,242,48,96,53,111,113,170,215,14,215,111,147,77,138,173,225,220,224,62,254,194,239,60,227,155,175,31,137,217,11,18,34,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f3be9bf-a5b6-4e6a-a262-4785da28353f"));
		}

		#endregion

	}

	#endregion

}

