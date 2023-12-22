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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,146,77,106,195,48,16,133,215,9,228,14,34,217,180,27,123,159,184,222,120,97,12,45,132,38,23,80,173,113,58,96,141,204,72,42,13,161,119,175,44,97,211,186,148,238,170,149,244,244,189,153,167,31,146,26,236,32,91,16,103,96,150,214,116,46,171,12,117,120,241,44,29,26,202,206,44,201,246,113,190,89,223,54,235,149,183,72,23,113,186,90,7,250,176,88,7,111,223,67,59,194,54,171,129,128,177,13,76,160,118,12,151,160,138,134,28,112,23,26,238,69,19,60,149,239,157,103,104,168,51,71,54,111,168,128,35,62,248,151,30,91,129,19,253,59,188,186,69,195,220,224,9,220,171,81,118,47,142,177,68,218,204,243,92,20,214,107,45,249,90,78,66,13,206,10,27,115,139,54,149,14,13,59,195,58,157,124,54,230,75,103,49,72,150,90,80,184,188,135,45,170,109,121,90,84,81,64,14,59,4,206,138,60,178,209,186,56,131,120,6,169,238,106,143,42,24,238,15,255,144,148,20,188,255,12,59,170,127,231,12,79,145,208,41,233,35,90,87,44,208,50,177,19,50,122,42,227,201,205,202,14,72,165,135,138,235,143,244,55,190,137,81,251,58,62,1,221,127,115,9,164,2,0,0 };
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

