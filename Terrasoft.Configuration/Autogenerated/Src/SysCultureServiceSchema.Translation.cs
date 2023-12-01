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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,111,219,48,12,61,59,64,255,3,145,94,18,32,179,239,109,90,160,205,176,98,3,178,6,77,130,30,130,29,20,155,78,133,218,146,43,74,14,140,97,255,125,148,236,124,180,41,210,35,31,31,31,201,71,42,81,34,85,34,69,88,160,49,130,116,110,227,137,86,185,220,56,35,172,212,234,162,247,247,162,23,57,146,106,3,243,134,44,150,215,31,226,120,142,166,150,41,78,117,134,197,217,100,124,151,90,89,7,217,243,188,103,92,31,8,135,193,24,230,225,202,50,148,115,254,210,224,134,181,96,82,8,162,43,175,52,113,133,117,6,59,177,64,74,146,4,198,228,202,82,152,230,182,139,103,70,215,50,67,130,45,174,191,81,75,134,92,27,216,106,243,10,91,105,95,32,71,225,149,40,222,73,36,71,26,171,174,1,59,101,141,72,237,31,143,221,81,245,27,45,207,87,241,134,107,89,72,219,60,225,155,147,6,75,84,150,6,199,129,95,19,110,224,139,18,207,138,59,32,27,250,38,149,91,23,50,133,212,47,124,186,47,92,193,189,160,195,246,145,63,221,222,165,41,218,23,157,177,79,179,32,18,204,57,113,39,0,79,200,162,138,32,195,92,112,3,72,219,46,224,148,124,115,200,198,41,43,115,137,38,222,43,36,31,37,198,166,213,184,253,254,149,198,56,217,81,125,237,234,177,194,246,241,142,189,141,86,124,250,159,170,214,175,56,104,215,96,243,250,179,199,249,162,63,130,165,145,11,44,171,66,88,111,105,255,1,109,215,179,51,135,41,247,58,107,230,182,41,60,129,149,166,72,36,54,184,71,227,103,35,170,10,179,145,111,21,121,195,145,236,15,109,74,97,223,21,180,80,252,139,180,26,177,73,84,105,69,120,158,23,174,182,59,219,131,147,25,156,204,55,24,66,184,83,84,11,3,180,191,233,210,250,127,144,252,164,55,160,112,123,116,237,125,102,176,228,223,101,159,20,166,222,177,225,117,144,105,237,252,76,41,254,164,119,168,249,215,62,195,37,170,172,125,150,16,183,232,123,144,177,94,239,63,170,104,27,227,53,4,0,0 };
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

