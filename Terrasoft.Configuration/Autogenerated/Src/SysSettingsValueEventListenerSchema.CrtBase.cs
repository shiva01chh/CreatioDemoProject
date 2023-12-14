namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingsValueEventListenerSchema

	/// <exclude/>
	public class SysSettingsValueEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingsValueEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingsValueEventListenerSchema(SysSettingsValueEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b87f92fc-2bfc-4aea-b3b7-8872e42ad5ac");
			Name = "SysSettingsValueEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,75,195,64,16,61,167,208,255,48,180,151,22,74,114,175,85,208,208,155,138,208,234,69,60,172,201,52,93,72,118,195,206,110,36,22,255,187,187,27,83,146,216,250,145,75,152,175,183,239,189,25,193,10,164,146,37,8,91,84,138,145,220,233,48,150,98,199,51,163,152,230,82,140,71,135,241,40,48,196,69,214,107,81,120,113,38,31,174,133,230,154,35,253,218,16,174,43,20,186,211,231,170,155,154,54,168,181,13,9,46,135,147,61,106,97,167,245,44,198,19,203,13,254,3,200,247,91,52,139,55,85,152,217,42,196,57,35,90,194,176,201,147,191,229,164,81,160,242,3,81,20,193,138,76,81,48,85,95,125,197,126,24,74,37,43,158,34,1,122,197,176,103,34,205,29,219,157,84,64,181,197,40,128,90,213,149,67,167,176,5,140,58,136,207,222,186,186,247,244,108,147,236,177,96,247,118,147,86,231,100,72,115,50,127,177,131,165,121,205,121,2,137,103,243,163,18,88,194,13,163,174,133,189,242,234,148,191,142,218,193,91,112,52,237,14,245,94,166,214,182,7,37,53,38,26,211,166,94,182,33,200,202,174,196,154,114,122,99,177,66,166,209,149,26,201,179,71,66,101,183,38,236,176,195,55,189,112,14,238,74,131,64,161,54,74,128,192,183,147,168,179,193,148,187,154,224,227,44,177,74,242,20,174,19,109,88,206,223,255,204,101,225,153,4,39,85,37,71,140,5,52,255,216,158,66,134,219,186,68,192,65,162,21,53,64,10,143,140,60,38,13,68,45,122,143,124,195,236,74,158,162,72,155,117,249,184,201,246,147,54,7,227,145,253,62,1,174,221,248,96,41,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b87f92fc-2bfc-4aea-b3b7-8872e42ad5ac"));
		}

		#endregion

	}

	#endregion

}

