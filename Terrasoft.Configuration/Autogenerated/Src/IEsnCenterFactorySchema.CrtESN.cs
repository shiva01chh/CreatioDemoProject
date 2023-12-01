namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnCenterFactorySchema

	/// <exclude/>
	public class IEsnCenterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnCenterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnCenterFactorySchema(IEsnCenterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5db535e2-9bbb-4b57-8890-3bdffc4020de");
			Name = "IEsnCenterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,207,78,132,48,16,198,207,144,240,14,19,188,232,133,222,149,229,66,214,132,139,49,254,121,128,202,14,216,100,219,146,105,107,178,49,190,187,83,96,5,178,94,180,151,102,166,147,223,247,245,203,24,169,209,13,178,69,120,65,34,233,108,231,139,218,154,78,245,129,164,87,214,20,251,231,135,44,253,204,210,36,56,101,122,168,45,225,93,150,114,125,69,216,243,0,64,99,60,82,199,140,91,104,246,206,212,24,235,123,217,122,75,167,113,82,8,1,165,11,90,75,58,85,115,253,72,246,67,29,208,129,70,255,110,15,14,58,75,208,18,178,40,171,40,227,188,52,236,202,118,160,244,112,68,205,80,102,32,198,153,110,151,47,66,57,136,170,56,139,136,149,202,16,222,142,170,101,212,236,238,55,115,73,252,216,133,191,177,81,71,47,248,31,39,151,86,166,206,32,73,106,48,156,248,46,15,14,137,115,54,216,198,144,243,170,89,201,172,224,175,219,177,40,80,138,145,179,96,9,125,32,227,170,167,241,254,179,225,82,156,1,145,184,60,206,1,252,212,215,91,47,176,253,193,13,239,68,242,53,237,5,154,195,180,26,89,58,118,248,124,3,173,208,166,32,103,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5db535e2-9bbb-4b57-8890-3bdffc4020de"));
		}

		#endregion

	}

	#endregion

}

