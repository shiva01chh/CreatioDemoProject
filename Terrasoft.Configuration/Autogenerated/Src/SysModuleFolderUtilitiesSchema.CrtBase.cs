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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,193,106,194,64,16,61,43,248,15,139,39,5,89,122,151,30,68,80,60,180,20,181,244,88,214,205,104,151,38,217,176,51,17,68,252,247,110,118,99,154,196,68,114,168,13,36,187,153,153,205,123,111,222,36,22,17,96,34,36,176,45,24,35,80,239,137,207,117,188,87,135,212,8,82,58,30,244,207,131,126,47,69,21,31,216,230,132,4,209,180,120,47,31,137,34,29,55,103,12,180,197,249,134,124,214,230,147,116,23,42,201,144,44,170,100,50,20,136,25,222,139,14,210,16,22,58,12,192,188,147,10,21,41,64,91,158,145,106,60,51,23,242,11,86,150,230,107,166,44,171,114,165,181,90,36,147,11,242,0,248,38,136,192,196,204,23,247,14,64,215,109,207,0,165,54,51,156,27,16,4,101,66,91,177,251,60,63,93,134,83,95,121,113,139,127,118,192,156,201,172,191,93,144,235,71,90,64,47,174,145,53,212,163,86,1,91,3,2,125,104,243,237,172,70,215,163,209,202,45,206,2,38,139,237,56,71,255,141,240,53,68,250,8,163,150,1,225,238,51,133,55,188,128,113,241,165,209,105,50,158,118,160,151,27,225,185,45,83,27,198,170,253,171,96,194,238,115,62,10,227,163,87,255,217,115,222,117,190,208,38,18,52,170,78,7,191,241,127,114,11,234,201,55,244,163,130,84,72,244,214,183,137,172,57,217,36,246,145,50,171,35,55,41,131,254,169,204,89,44,194,147,13,225,26,18,109,232,161,243,214,132,213,145,166,215,254,15,28,61,4,214,184,217,219,253,19,165,235,7,207,230,175,39,143,5,0,0 };
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

