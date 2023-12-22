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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,205,78,132,48,16,199,207,75,194,59,76,56,105,98,202,3,136,92,12,26,226,101,147,245,5,186,56,108,38,210,150,76,91,35,49,190,187,45,21,150,221,24,9,7,58,252,254,31,12,90,42,180,163,236,16,94,145,89,90,211,59,241,104,116,79,39,207,210,145,209,226,137,6,108,213,104,216,229,217,87,158,237,188,37,125,130,195,100,29,170,128,14,3,118,145,179,226,25,53,50,117,247,43,179,117,100,20,141,118,228,8,109,0,2,50,250,227,64,29,144,118,200,125,204,111,247,76,74,242,148,178,22,248,128,46,0,129,143,209,187,178,44,161,178,94,69,174,94,6,1,177,128,159,100,93,12,197,95,33,56,3,52,91,173,35,177,90,148,215,30,213,40,89,42,208,97,27,15,197,252,140,33,214,22,117,106,3,231,145,168,202,249,240,183,116,137,42,234,230,186,208,255,194,119,156,194,46,189,210,65,250,130,19,116,233,112,33,250,48,244,22,191,246,38,149,218,175,157,54,245,238,160,109,180,87,200,242,56,96,53,111,113,170,215,14,151,111,147,77,138,173,225,220,224,54,254,194,239,60,11,247,246,250,1,30,174,17,74,43,2,0,0 };
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

