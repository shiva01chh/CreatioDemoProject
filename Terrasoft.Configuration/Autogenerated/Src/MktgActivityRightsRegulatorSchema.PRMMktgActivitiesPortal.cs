namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MktgActivityRightsRegulatorSchema

	/// <exclude/>
	public class MktgActivityRightsRegulatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MktgActivityRightsRegulatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MktgActivityRightsRegulatorSchema(MktgActivityRightsRegulatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd6f3ed9-1bd8-42f5-9da1-eedf8c901d2e");
			Name = "MktgActivityRightsRegulator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0d7ed7ad-953f-4448-9eef-c702acc0afc1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,201,110,219,48,16,61,43,64,254,97,144,94,108,32,144,239,118,154,192,48,140,192,7,199,65,156,246,206,80,99,138,136,72,10,92,236,170,65,255,189,20,233,56,146,98,181,89,90,221,102,123,111,230,105,134,146,8,52,37,161,8,247,168,53,49,106,99,211,153,146,27,206,156,38,150,43,121,122,242,116,122,146,56,195,37,131,117,101,44,138,201,193,110,150,8,161,228,241,136,198,62,127,58,151,150,91,142,38,157,154,74,210,85,137,145,211,188,187,32,93,72,139,122,227,231,168,107,125,245,23,141,204,7,96,86,16,99,198,176,124,180,108,74,45,223,114,91,221,113,150,91,115,135,204,21,196,42,29,210,71,163,17,92,24,39,4,209,213,229,222,14,165,176,203,57,205,1,127,32,117,22,13,168,103,74,216,40,13,52,39,146,213,109,234,128,9,222,221,100,74,225,25,122,212,192,46,221,67,193,41,208,0,255,135,198,96,12,139,48,111,53,223,162,180,237,137,61,206,83,232,252,48,233,173,174,123,171,197,25,195,109,164,136,9,123,190,181,41,35,90,151,166,47,48,217,227,163,204,34,69,155,111,137,54,87,89,77,166,249,150,88,220,147,69,3,182,138,103,176,36,146,48,108,142,184,210,140,72,254,51,140,16,233,6,189,35,78,53,51,64,52,115,194,135,204,16,234,61,76,146,190,110,211,72,22,99,71,104,14,64,113,135,170,69,118,30,240,146,110,96,166,10,39,228,119,82,56,191,102,215,104,239,171,18,179,96,94,92,59,158,93,14,206,166,148,42,39,237,34,59,27,190,194,88,21,217,7,96,134,245,194,39,191,222,38,225,78,162,254,159,218,53,240,143,43,244,9,233,2,248,103,133,59,128,12,39,208,20,238,239,155,26,46,161,117,21,65,228,121,188,238,193,55,131,218,63,126,18,105,184,112,215,50,207,225,31,169,13,95,251,111,241,234,10,36,238,122,227,131,110,75,221,63,176,166,57,10,114,227,31,245,184,82,201,155,78,240,165,245,222,162,198,82,116,178,143,139,31,189,109,103,240,53,191,223,159,55,125,123,125,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd6f3ed9-1bd8-42f5-9da1-eedf8c901d2e"));
		}

		#endregion

	}

	#endregion

}

