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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,193,138,194,48,16,61,91,240,31,130,39,5,9,123,151,61,136,160,120,216,101,81,151,61,46,177,29,221,176,109,83,50,19,65,196,127,223,52,169,93,91,91,233,97,221,67,155,116,102,210,247,222,188,73,42,18,192,76,132,192,54,160,181,64,181,35,62,83,233,78,238,141,22,36,85,218,15,78,253,160,103,80,166,123,182,62,34,65,50,41,191,175,143,36,137,74,155,51,26,218,226,124,77,62,107,243,153,217,198,50,100,72,22,53,100,97,44,16,115,188,23,21,153,24,230,42,142,64,191,147,140,37,73,64,91,158,147,106,60,51,19,225,23,44,45,205,215,92,89,94,229,74,107,181,72,186,16,228,1,240,77,16,129,78,153,47,238,237,129,46,219,158,6,50,54,51,152,105,16,4,215,132,54,98,251,121,122,58,15,38,190,242,236,22,255,238,128,57,13,243,254,118,65,174,31,105,1,61,187,70,214,80,15,74,70,108,5,8,244,161,244,183,179,26,93,143,134,75,183,56,11,88,88,110,71,5,250,111,132,175,32,81,7,24,182,12,8,119,191,41,189,225,37,140,139,47,180,50,217,104,210,129,94,97,132,231,182,48,54,140,85,251,151,209,152,221,231,124,16,218,71,47,254,179,231,162,235,124,174,116,34,104,88,157,14,126,227,255,248,22,212,147,111,232,71,5,169,148,232,173,111,19,89,115,178,73,236,35,101,86,71,110,124,13,250,167,50,167,169,136,143,54,132,43,200,148,166,135,206,91,19,86,71,154,94,251,63,112,244,16,88,227,102,31,119,39,130,224,7,216,246,186,88,134,5,0,0 };
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

