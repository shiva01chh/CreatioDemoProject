namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermIntervalSelectorSchema

	/// <exclude/>
	public class ITermIntervalSelectorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermIntervalSelectorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermIntervalSelectorSchema(ITermIntervalSelectorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ad912a0-8f79-46f0-9654-054938f2e9ef");
			Name = "ITermIntervalSelector";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,81,203,78,196,48,12,60,83,169,255,96,237,9,36,212,124,0,165,18,2,105,213,3,167,237,15,100,131,219,13,202,163,74,28,164,21,226,223,113,66,187,91,32,202,193,177,103,38,99,219,73,139,113,150,10,97,192,16,100,244,35,53,207,222,141,122,74,65,146,246,174,174,62,235,234,38,69,237,38,56,156,35,161,229,186,49,168,114,49,54,123,116,24,180,122,96,140,16,2,218,152,172,149,225,220,45,239,222,17,134,49,203,251,17,56,180,160,115,230,67,26,136,152,69,124,104,86,170,216,112,231,116,52,90,253,128,11,189,103,123,182,95,184,135,133,218,14,25,155,253,253,251,188,36,94,145,78,254,13,232,36,9,2,82,10,46,2,105,139,87,19,163,15,160,164,81,201,148,102,155,139,148,248,171,213,206,50,72,11,142,231,245,184,147,97,74,22,29,197,93,247,180,134,69,43,18,79,13,39,141,177,105,69,97,92,5,22,7,221,176,117,192,176,53,159,129,191,218,228,246,96,143,116,251,162,203,176,217,77,203,250,188,136,123,240,199,119,158,64,7,23,35,119,121,3,95,117,197,183,174,182,231,27,92,218,248,57,225,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ad912a0-8f79-46f0-9654-054938f2e9ef"));
		}

		#endregion

	}

	#endregion

}

