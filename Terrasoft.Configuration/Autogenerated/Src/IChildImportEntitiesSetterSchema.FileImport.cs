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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,207,74,196,48,16,135,207,91,232,59,132,158,20,36,121,0,107,47,75,87,122,19,214,23,200,118,167,235,64,254,148,100,42,22,241,221,157,180,54,174,139,37,135,102,242,205,239,27,198,105,11,113,212,61,136,87,8,65,71,63,144,220,123,55,224,101,10,154,208,59,121,64,3,157,29,125,160,178,248,44,139,221,20,209,93,196,113,142,4,150,81,99,160,79,92,148,207,224,32,96,255,152,153,235,196,0,178,117,132,132,16,25,96,100,156,78,6,123,129,142,32,12,201,223,237,223,208,156,87,211,134,30,129,248,153,233,36,222,41,165,68,29,39,107,117,152,155,173,192,72,20,240,129,145,146,18,126,26,5,121,129,75,84,46,201,28,161,110,51,234,81,7,109,133,227,93,60,85,203,63,176,54,86,205,58,141,248,45,201,90,45,151,255,91,55,85,213,180,183,3,253,105,124,247,120,78,131,223,173,249,47,57,254,202,244,32,186,214,77,22,130,62,25,168,151,133,204,77,142,187,79,91,254,42,11,62,252,125,3,96,173,31,73,197,1,0,0 };
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

