namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPrimaryImportEntitiesGetterSchema

	/// <exclude/>
	public class IPrimaryImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPrimaryImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPrimaryImportEntitiesGetterSchema(IPrimaryImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6f63fcc-5fd6-4ac9-8d4c-acfa8b8d627e");
			Name = "IPrimaryImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,65,106,195,48,16,69,215,49,248,14,67,86,45,20,233,0,117,189,41,73,48,221,4,218,11,40,102,28,68,173,177,25,73,11,83,122,247,142,172,218,49,105,133,22,154,209,251,250,127,16,25,135,126,52,45,194,7,50,27,63,116,65,189,14,212,217,107,100,19,236,64,234,104,123,108,220,56,112,40,139,175,178,216,69,111,233,10,239,147,15,232,4,237,123,108,19,231,213,9,9,217,182,207,43,179,125,145,81,29,40,216,96,209,11,32,200,24,47,189,109,193,82,64,238,146,127,115,102,235,12,79,217,107,129,79,24,4,16,62,89,239,180,214,80,249,232,18,87,47,13,65,60,140,89,12,248,171,83,43,174,239,249,106,52,108,28,144,76,254,178,159,207,40,22,126,95,103,103,184,181,84,165,231,226,127,233,39,78,50,126,116,36,210,55,156,160,205,197,95,17,99,136,76,190,62,223,103,172,244,114,149,216,230,64,209,33,155,75,143,213,60,254,84,167,217,30,114,172,243,154,106,19,240,9,182,162,12,230,76,53,220,226,61,166,47,249,46,11,217,105,253,0,156,8,207,15,243,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6f63fcc-5fd6-4ac9-8d4c-acfa8b8d627e"));
		}

		#endregion

	}

	#endregion

}

