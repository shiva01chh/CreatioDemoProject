namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChainOfCircumstancesExtensionsSchema

	/// <exclude/>
	public class ChainOfCircumstancesExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChainOfCircumstancesExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChainOfCircumstancesExtensionsSchema(ChainOfCircumstancesExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c54472f-f2a2-4576-973d-73866d39766e");
			Name = "ChainOfCircumstancesExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,207,78,195,48,12,198,207,155,180,119,48,227,192,38,161,245,14,91,37,52,118,4,38,216,11,100,169,187,70,106,146,146,56,136,105,226,221,201,159,182,235,38,36,122,104,155,207,254,185,159,237,42,38,209,54,140,35,236,208,24,102,117,73,139,181,86,165,56,56,195,72,104,53,25,159,38,227,145,179,66,29,224,227,104,9,229,227,100,236,149,91,131,7,31,134,117,205,172,125,128,117,197,132,122,43,215,194,112,39,45,49,197,209,110,190,9,149,245,73,54,18,89,150,193,210,58,41,153,57,230,237,57,98,160,75,224,67,16,176,39,23,29,152,13,200,198,237,107,193,193,103,147,127,240,224,224,95,3,163,83,52,209,251,126,65,170,116,225,157,111,99,177,20,188,182,24,133,39,224,90,74,143,52,218,18,215,170,16,97,46,254,36,20,133,169,80,197,200,223,16,12,90,87,19,72,103,73,221,17,236,17,186,18,12,10,44,89,8,126,177,218,97,104,120,217,48,195,164,193,18,148,95,193,106,186,123,143,244,52,203,23,61,118,209,116,82,232,216,96,36,175,176,124,231,3,161,110,50,177,88,102,125,230,25,30,130,60,204,203,99,222,119,124,245,196,85,182,65,114,70,217,124,59,108,219,167,117,122,72,188,220,196,214,96,33,56,35,92,182,182,114,120,213,244,156,90,239,181,25,85,226,239,125,157,177,104,105,14,225,215,27,141,210,7,187,241,174,114,184,217,124,58,86,219,89,82,238,187,225,206,90,124,62,127,12,220,79,187,112,84,69,218,121,60,39,245,82,244,218,240,250,5,92,147,169,73,20,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c54472f-f2a2-4576-973d-73866d39766e"));
		}

		#endregion

	}

	#endregion

}

