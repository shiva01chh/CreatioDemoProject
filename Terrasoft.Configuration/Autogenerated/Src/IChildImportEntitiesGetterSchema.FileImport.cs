namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IChildImportEntitiesGetterSchema

	/// <exclude/>
	public class IChildImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IChildImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IChildImportEntitiesGetterSchema(IChildImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080");
			Name = "IChildImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,144,193,110,195,32,12,64,207,141,148,127,64,61,109,23,248,128,101,185,68,93,149,219,164,237,7,40,115,58,36,112,34,27,14,209,180,127,159,73,150,180,27,226,0,246,179,31,6,109,4,158,172,3,245,14,68,150,199,33,233,110,196,193,95,51,217,228,71,212,47,62,64,31,167,145,82,93,125,213,213,33,179,199,171,122,155,57,65,20,52,4,112,133,99,125,6,4,242,238,105,103,238,59,18,232,19,38,159,60,176,0,130,76,249,18,188,83,30,19,208,80,252,125,247,233,195,199,106,218,208,51,36,73,11,93,196,7,99,140,106,56,199,104,105,110,183,128,32,172,92,41,85,240,91,165,119,216,252,167,155,201,146,141,10,101,234,231,227,114,6,17,240,177,93,189,234,22,210,141,89,46,183,82,130,148,9,185,237,254,202,26,179,37,10,217,159,48,71,32,123,9,208,44,83,204,109,121,226,195,218,255,117,111,127,103,122,44,63,246,93,87,178,101,253,0,121,140,163,210,145,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080"));
		}

		#endregion

	}

	#endregion

}

