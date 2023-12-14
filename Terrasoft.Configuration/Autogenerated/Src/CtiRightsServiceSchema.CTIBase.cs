namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CtiRightsServiceSchema

	/// <exclude/>
	public class CtiRightsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CtiRightsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CtiRightsServiceSchema(CtiRightsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6c64027-2137-42ca-b41d-24afcb039a7e");
			Name = "CtiRightsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c124cf91-dc7b-4db8-b77e-ff0b639610dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,111,219,48,12,61,171,64,255,131,218,67,145,2,129,127,192,190,128,52,192,218,12,205,50,196,29,122,8,118,80,108,58,17,34,75,158,72,7,48,210,254,247,81,178,147,56,93,145,205,7,25,36,31,31,223,147,104,85,9,88,169,12,228,19,120,175,208,21,148,140,157,45,244,170,246,138,180,179,151,23,187,203,11,81,163,182,43,153,54,72,80,114,221,24,200,66,17,147,123,176,224,117,246,241,45,38,5,191,213,25,76,93,14,230,108,49,121,134,229,121,192,136,71,109,163,150,191,112,220,203,88,68,174,165,164,8,142,128,163,155,128,25,187,178,140,237,92,95,116,228,236,146,188,202,232,87,200,141,176,250,14,196,176,138,7,45,181,209,212,204,225,119,173,61,148,96,9,7,253,32,168,146,159,229,63,90,2,42,233,18,249,109,24,82,213,75,163,51,153,25,133,40,199,164,231,122,181,38,236,212,124,144,119,10,161,11,134,114,50,7,149,207,172,105,250,238,152,99,23,45,136,197,172,130,246,121,250,46,196,130,189,78,236,214,109,96,48,5,90,187,156,101,94,255,152,165,79,215,67,121,231,242,38,165,198,4,233,12,155,50,175,90,193,33,155,60,123,85,85,144,15,3,143,8,186,1,233,171,243,165,162,147,134,54,149,124,67,103,135,114,206,171,195,75,0,231,113,209,252,222,253,210,57,35,239,129,126,34,248,7,133,7,31,143,108,155,153,6,143,26,233,19,146,231,55,252,34,221,190,138,195,182,81,227,200,54,135,158,91,185,139,106,183,202,75,223,73,97,17,228,235,184,8,66,20,206,131,202,214,114,16,16,7,50,169,109,143,121,79,34,226,128,108,13,217,134,181,76,108,225,152,42,168,228,27,182,237,182,39,92,120,0,195,173,188,246,244,158,122,119,148,246,242,210,19,34,116,33,7,87,39,228,55,55,242,234,125,59,66,244,204,20,202,224,158,68,44,217,206,166,11,94,229,145,249,45,241,127,240,246,180,157,210,198,95,123,122,160,218,219,195,213,70,196,107,92,192,120,198,35,124,127,0,228,162,232,252,68,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6c64027-2137-42ca-b41d-24afcb039a7e"));
		}

		#endregion

	}

	#endregion

}

