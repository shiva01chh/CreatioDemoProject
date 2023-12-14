namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoProviderSchema

	/// <exclude/>
	public class ISysCultureInfoProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoProviderSchema(ISysCultureInfoProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8d77611-044f-49a7-9b8f-472b0b015ec7");
			Name = "ISysCultureInfoProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,146,77,106,195,48,16,133,215,9,228,14,34,217,180,27,123,159,184,222,120,97,12,45,132,38,23,80,173,113,50,96,141,204,72,42,13,161,119,175,44,97,67,93,74,119,213,74,122,250,222,204,211,15,73,13,118,144,45,136,51,48,75,107,58,151,85,134,58,188,120,150,14,13,101,103,150,100,251,56,223,172,239,155,245,202,91,164,139,56,221,172,3,125,88,172,131,183,239,161,29,97,155,213,64,192,216,6,38,80,59,134,75,80,69,67,14,184,11,13,247,162,9,158,202,247,206,51,52,212,153,35,155,119,84,192,17,31,252,91,143,173,192,137,254,29,94,221,163,97,110,240,2,238,106,148,221,139,99,44,145,54,243,60,23,133,245,90,75,190,149,147,80,131,179,194,198,220,162,77,165,67,195,206,176,78,39,159,141,249,210,89,12,146,165,22,20,46,239,105,139,106,91,158,22,85,20,144,195,14,129,179,34,143,108,180,46,206,32,94,65,170,135,218,163,10,134,199,195,63,36,37,5,31,63,195,142,234,223,57,195,83,36,116,74,250,140,214,21,11,180,76,236,132,140,158,202,120,114,179,178,3,82,233,161,226,250,51,253,141,111,98,212,198,241,5,71,58,62,50,156,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8d77611-044f-49a7-9b8f-472b0b015ec7"));
		}

		#endregion

	}

	#endregion

}

