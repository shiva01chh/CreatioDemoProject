namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleFolderUtilitiesSchema

	/// <exclude/>
	public class SysModuleFolderUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleFolderUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleFolderUtilitiesSchema(SysModuleFolderUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da6824aa-e582-4158-850d-dede529eb3c0");
			Name = "SysModuleFolderUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,81,107,194,48,16,126,86,216,127,8,62,41,72,216,187,236,65,4,197,135,141,161,142,61,142,152,158,46,172,77,74,238,42,136,248,223,151,38,181,179,181,29,125,152,43,180,73,239,46,253,190,239,190,171,22,9,96,42,36,176,13,88,43,208,236,136,207,140,222,169,125,102,5,41,163,31,250,167,135,126,47,67,165,247,108,125,68,130,100,82,190,95,31,73,18,163,155,51,22,218,226,124,77,33,235,242,105,182,141,149,100,72,14,85,50,25,11,196,28,239,217,68,89,12,115,19,71,96,223,72,197,138,20,160,43,207,73,53,158,153,9,249,9,75,71,243,37,87,150,87,249,210,90,45,146,45,4,5,0,124,21,68,96,53,11,197,189,61,208,101,219,179,64,153,203,12,102,22,4,193,53,161,141,216,126,156,30,207,131,73,168,60,251,37,60,59,96,78,101,222,223,46,200,245,35,45,160,103,223,200,26,234,193,168,136,173,0,129,222,141,253,242,86,163,239,209,112,233,23,111,1,147,229,118,84,160,255,68,248,10,18,115,128,97,203,128,112,255,153,210,27,94,194,248,248,194,154,44,29,77,58,208,43,140,8,220,22,153,11,99,213,254,101,52,102,191,115,62,8,27,162,23,255,217,83,209,117,62,55,54,17,52,172,78,7,191,241,127,124,11,26,200,55,244,163,130,84,74,12,214,183,137,172,57,217,36,246,158,50,171,35,55,190,6,253,83,153,83,45,226,163,11,225,10,82,99,233,174,243,214,132,213,145,102,208,254,15,28,3,4,214,184,185,219,255,19,238,250,6,131,230,135,186,135,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da6824aa-e582-4158-850d-dede529eb3c0"));
		}

		#endregion

	}

	#endregion

}

