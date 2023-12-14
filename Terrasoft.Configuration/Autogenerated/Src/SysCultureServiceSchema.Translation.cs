namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysCultureServiceSchema

	/// <exclude/>
	public class SysCultureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysCultureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysCultureServiceSchema(SysCultureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4865d94-8357-4f78-a417-9cd6dcdf4fff");
			Name = "SysCultureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,79,227,48,16,61,7,137,255,48,42,151,86,42,201,29,10,18,116,5,218,149,186,84,180,21,135,106,15,110,50,41,22,137,29,60,118,170,104,181,255,125,199,78,250,1,69,197,183,121,126,243,102,230,205,40,81,34,85,34,69,152,163,49,130,116,110,227,177,86,185,92,59,35,172,212,234,252,236,239,249,89,228,72,170,53,204,26,178,88,94,127,138,227,25,154,90,166,56,209,25,22,39,63,227,187,212,202,58,200,158,230,189,224,106,79,216,55,198,48,55,87,150,33,157,255,47,12,174,89,11,198,133,32,186,242,74,99,87,88,103,176,19,11,164,36,73,96,68,174,44,133,105,110,187,120,106,116,45,51,36,216,224,234,146,90,50,228,218,192,70,155,55,216,72,251,10,57,10,175,68,241,86,34,57,208,88,118,5,216,41,107,68,106,255,120,236,142,170,223,104,185,191,138,39,92,201,66,218,230,25,223,157,52,88,162,178,212,63,12,252,152,112,3,223,164,120,86,220,1,217,192,23,169,220,170,144,41,164,126,224,227,121,225,10,238,5,237,167,143,252,234,118,46,77,208,190,234,140,125,154,6,145,96,206,145,59,1,120,70,22,85,4,25,230,130,11,64,218,86,1,167,228,187,67,54,78,89,153,75,52,241,78,33,249,44,49,50,173,198,237,143,239,52,70,201,150,234,115,151,79,21,182,135,119,232,109,180,228,213,255,84,181,126,195,126,59,6,155,215,155,62,205,230,189,33,44,140,156,99,89,21,194,122,75,123,143,104,187,154,157,57,76,185,215,89,51,179,77,225,9,172,52,65,34,177,198,29,26,191,24,81,85,152,13,125,169,200,27,142,100,31,180,41,133,253,144,208,66,241,47,210,106,200,38,81,165,21,225,105,94,216,218,118,109,143,78,102,112,212,95,127,0,97,79,81,45,12,208,110,167,11,235,239,65,242,145,222,128,194,205,193,182,119,63,253,5,223,46,251,164,48,245,142,13,174,131,76,107,231,87,74,241,23,181,67,206,191,246,24,46,80,101,237,177,132,184,69,63,130,140,241,251,15,13,87,55,4,54,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4865d94-8357-4f78-a417-9cd6dcdf4fff"));
		}

		#endregion

	}

	#endregion

}

