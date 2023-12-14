namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IChildImportEntitiesSetterSchema

	/// <exclude/>
	public class IChildImportEntitiesSetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IChildImportEntitiesSetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IChildImportEntitiesSetterSchema(IChildImportEntitiesSetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06530102-5f59-41f5-9ac8-4a7901f07ee8");
			Name = "IChildImportEntitiesSetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,207,74,196,48,16,135,207,91,232,59,132,158,20,36,121,0,107,47,75,87,122,19,214,23,200,118,167,235,64,254,148,204,84,44,226,187,155,180,54,174,139,37,135,102,242,205,239,27,198,105,11,52,234,30,196,43,132,160,201,15,44,247,222,13,120,153,130,102,244,78,30,208,64,103,71,31,184,44,62,203,98,55,17,186,139,56,206,196,96,35,106,12,244,137,35,249,12,14,2,246,143,153,185,78,12,32,91,199,200,8,20,129,136,140,211,201,96,47,208,49,132,33,249,187,253,27,154,243,106,218,208,35,112,124,142,116,18,239,148,82,162,166,201,90,29,230,102,43,68,132,4,124,32,113,82,194,79,163,96,47,112,137,202,37,153,35,212,109,70,61,234,160,173,112,113,23,79,213,242,15,81,75,85,179,78,35,126,75,178,86,203,229,255,214,77,85,53,237,237,64,127,26,223,61,158,211,224,119,107,254,75,142,191,50,61,136,174,117,147,133,160,79,6,234,101,33,115,147,227,238,211,150,191,202,34,158,244,125,3,102,120,44,127,198,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06530102-5f59-41f5-9ac8-4a7901f07ee8"));
		}

		#endregion

	}

	#endregion

}

