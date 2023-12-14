namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoAppEventListenerSchema

	/// <exclude/>
	public class SsoAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoAppEventListenerSchema(SsoAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aebf3d9a-9819-4190-84a0-91aa0f7bd750");
			Name = "SsoAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,82,193,78,227,48,16,61,23,137,127,24,117,47,69,90,37,119,8,149,182,21,172,180,218,5,164,128,56,187,206,164,181,72,236,104,102,92,22,33,254,157,177,147,34,168,200,193,146,223,248,189,121,51,47,222,244,200,131,177,8,247,72,100,56,180,82,172,131,111,221,54,146,17,23,252,233,201,235,233,201,44,178,243,219,47,79,8,47,190,193,31,113,163,181,190,15,94,171,90,255,65,184,85,17,88,119,134,249,28,106,14,191,134,225,106,143,94,254,58,22,244,72,249,89,89,150,80,113,236,123,67,47,203,233,158,41,48,80,216,187,6,25,148,66,47,48,4,231,5,218,64,80,215,183,96,108,114,200,160,13,34,35,1,35,115,234,198,98,72,138,131,110,249,73,120,136,155,206,89,176,89,251,27,55,112,14,199,208,202,48,42,243,53,27,253,24,232,31,202,46,52,58,210,93,86,28,139,199,99,100,160,78,102,24,226,208,24,65,96,14,96,131,23,181,14,98,248,169,248,224,149,199,196,106,48,100,122,240,154,208,229,60,113,240,191,204,151,21,35,130,37,108,47,231,7,167,235,169,86,46,193,121,157,221,91,44,170,50,179,179,216,52,116,216,107,76,186,75,216,7,215,192,173,175,199,109,101,127,139,35,45,152,250,157,65,74,127,54,115,45,44,126,119,97,99,58,125,88,163,136,198,206,197,53,26,137,132,186,199,63,78,30,157,110,36,74,109,119,216,196,14,233,64,157,165,127,165,184,215,89,57,159,69,110,120,131,207,137,240,160,177,105,75,143,57,201,234,33,47,73,245,214,227,138,86,198,62,109,41,68,223,36,230,79,216,132,208,45,23,66,17,207,46,178,248,91,58,223,166,104,208,55,99,58,249,62,162,95,65,197,210,247,14,219,87,180,163,245,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aebf3d9a-9819-4190-84a0-91aa0f7bd750"));
		}

		#endregion

	}

	#endregion

}

