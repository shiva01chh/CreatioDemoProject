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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,207,78,132,48,16,198,207,144,240,14,19,188,232,133,222,149,229,66,214,132,139,49,254,121,128,202,14,216,100,59,37,211,214,100,99,124,119,91,96,5,178,94,180,151,102,166,147,223,247,245,203,144,212,104,7,217,34,188,32,179,180,166,115,69,109,168,83,189,103,233,148,161,98,255,252,144,165,159,89,154,120,171,168,135,218,48,222,101,105,168,175,24,251,48,0,208,144,67,238,2,227,22,154,189,165,26,99,125,47,91,103,248,52,78,10,33,160,180,94,107,201,167,106,174,31,217,124,168,3,90,208,232,222,205,193,66,103,24,90,198,32,26,84,20,89,39,41,184,50,29,40,61,28,81,7,104,96,32,198,153,110,151,47,66,57,136,170,56,139,136,149,202,224,223,142,170,13,168,217,221,111,230,146,248,177,11,127,99,163,142,94,240,63,78,46,173,76,157,65,178,212,64,33,241,93,238,45,114,200,153,176,141,33,231,85,179,146,89,193,95,183,99,81,160,20,35,103,193,50,58,207,100,171,167,241,254,179,225,82,156,1,145,184,60,206,1,252,212,215,91,47,176,253,193,77,216,137,228,107,218,11,164,195,180,26,89,58,118,214,231,27,146,114,141,229,112,2,0,0 };
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

