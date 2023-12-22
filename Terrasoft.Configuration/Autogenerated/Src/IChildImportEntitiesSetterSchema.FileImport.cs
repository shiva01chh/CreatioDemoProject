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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,77,106,195,48,16,70,215,49,248,14,194,171,22,138,116,128,186,222,4,167,120,23,72,47,160,56,227,116,64,63,102,36,133,154,210,187,87,178,107,213,13,53,90,88,163,55,223,27,198,72,13,110,148,61,176,55,32,146,206,14,158,239,173,25,240,26,72,122,180,134,31,80,65,167,71,75,190,44,62,203,98,23,28,154,43,59,77,206,131,142,168,82,208,39,206,241,87,48,64,216,63,103,102,155,72,192,91,227,209,35,184,8,68,100,12,103,133,61,67,227,129,134,228,239,246,239,168,46,139,105,69,79,224,227,115,164,147,120,39,132,96,181,11,90,75,154,154,181,16,17,199,224,3,157,79,74,248,105,100,222,50,156,163,114,137,231,8,113,159,81,143,146,164,102,38,238,226,165,154,255,33,106,93,213,44,211,176,223,18,175,197,124,249,191,117,85,85,77,123,63,208,159,198,155,197,75,26,252,97,201,63,230,248,141,233,137,117,173,9,26,72,158,21,212,243,66,166,38,199,61,166,45,127,149,69,60,219,239,27,45,70,70,1,206,1,0,0 };
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

